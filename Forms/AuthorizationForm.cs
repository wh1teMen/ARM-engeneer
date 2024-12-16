using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using PogectE;
using ProgectE.DataContext;
using ProgectE.Forms.Admin;
using ProgectE.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProgectE
{
    public partial class Authorization : Form
    {
        private Model.User user;
        private bool Vlogin = false;
        private bool Vpassword = false;

        public Authorization()
        {

            InitializeComponent();
            Start();



        }

        private  void Start()
        {
            using (var context = new AppDbContext())
            {
                bool isCreated = context.Database.EnsureCreated();                
                if (isCreated)
                {                   
                    context.Roles.Add(new Role() { Name = "User" });
                    context.Roles.Add(new Role() { Name = "Admin" });
                    context.SaveChanges();
                }
                else return;
            }

        }

        //Начальные настройки картинок валидации
        private void StartSettingsPictures()
        {
            pictureBoxLoginGood.Hide();
            pictureBoxLoginBad.Hide();
            pictureBoxPasswordGood.Hide();
            pictureBoxPasswordBad.Hide();
        }
        private void StartSettingsTextBox()
        {
            textBox_Login.PlaceholderText = "Введите логин";
            textBox_Password.PlaceholderText = "Введите пароль";
        }
        //Первоначальные настройки полей ввода textbox
        private void Authorization_Load(object sender, EventArgs e)
        {

            StartSettingsTextBox();
            StartSettingsPictures();
            try
            {
              //  label2.Text = System.Configuration.ConfigurationManager.ConnectionStrings["connectionStrings"].ConnectionString;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }
        //Проверка статуса пользователя
        private bool GetStatusUser(int idUser)
        {
            bool status = false;
            using (var context = new AppDbContext())
            {

                status = context.Users.FirstOrDefault(x => x.UserId == idUser).Status;

                return status;
            }

        }
        //Изменение статуса пользователя
        private void ChangeStatus(int idUser)
        {
            using (var context = new AppDbContext())
            {

                var User = context.Users.FirstOrDefault(x => x.UserId == idUser);
                if (User != null)
                {
                    User.Login = User.Login;
                    User.ImageData = User.ImageData;
                    User.Name = User.Name;
                    User.Surname = User.Surname;
                    User.Patronymic = User.Patronymic;
                    User.Email = User.Email;
                    User.Password = User.Password;
                    User.Telephone = User.Telephone;
                    User.Percent = User.Percent;
                    User.Tax = User.Tax;
                    User.Salary = User.Salary;
                    User.RoleId = User.RoleId;
                    User.Status = validstatus(User.Status);
                }
                context.Users.Update(User);
                context.SaveChanges();
            }
        }
        private bool validstatus(bool status)
        {
            if (status == true) return false;
            return true;
        }


        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (IsValidLogin(textBox_Login.Text) == true)
                {
                    pictureBoxLoginGood.Show(); pictureBoxLoginBad.Hide(); Vlogin = true;
                }
                else { pictureBoxLoginGood.Hide(); pictureBoxLoginBad.Show(); Vlogin = false; }


                if (IsValidPassword(textBox_Password.Text, user) == true)
                {
                    pictureBoxPasswordGood.Show(); pictureBoxPasswordBad.Hide(); Vpassword = true;

                }
                else
                {
                    pictureBoxPasswordGood.Hide(); pictureBoxPasswordBad.Show(); Vpassword = false; return;
                }

                if (Vlogin == true && Vpassword == true)
                {
                    if (GetStatusUser(getUserId(textBox_Login.Text)) == true)
                    {
                        MessageBox.Show("Пользователь уже онлайн"); return;
                    }
                    if (GetStatusUser(getUserId(textBox_Login.Text)) == false)
                    {

                        switch (GetRole(getUserId(textBox_Login.Text)))
                        {

                            case 1:
                                ChangeStatus(getUserId(textBox_Login.Text));
                                this.Hide();
                                MainForm mainForm = new MainForm(this, getUserId(textBox_Login.Text));
                                mainForm.Show();
                                textBox_Login.Text = "";
                                textBox_Password.Text = "";
                                textBox_Login.PlaceholderText = "Введите логин";
                                textBox_Password.PlaceholderText = "Введите пароль";
                                pictureBoxLoginBad.Hide();
                                pictureBoxLoginGood.Hide();
                                pictureBoxPasswordBad.Hide();
                                pictureBoxPasswordGood.Hide(); break;
                            case 2:
                                ChangeStatus(getUserId(textBox_Login.Text));
                                this.Hide();
                                AdminMainForm adminForm = new AdminMainForm(this, getUserId(textBox_Login.Text));
                                adminForm.Show();
                                textBox_Login.Text = "";
                                textBox_Password.Text = "";
                                textBox_Login.PlaceholderText = "Введите логин";
                                textBox_Password.PlaceholderText = "Введите пароль";
                                pictureBoxLoginBad.Hide();
                                pictureBoxLoginGood.Hide();
                                pictureBoxPasswordBad.Hide();
                                pictureBoxPasswordGood.Hide(); break;
                        }
                    }

                }
            }
            catch (Exception ex) { label2.Text = "Ошибка с БД проврь путь"; }



        }
        private int GetRole(int idUser)
        {

            int role = 0;

            using (var context = new AppDbContext())
            {


                role = context.Users.FirstOrDefault(x => x.UserId == idUser).RoleId;


            }
            return role;

        }

        private int getUserId(string Login)
        {
            int userId = 0;
            using (var context = new AppDbContext())
            {
                var ListUser = context.Users.ToList();
                if (ListUser != null)
                {
                    userId = ListUser.FirstOrDefault(x => x.Login == Login).UserId;

                }
                return userId;
            }
        }
        //Валидация логина
        private bool IsValidLogin(string Login)
        {
            using (var context = new AppDbContext())
            {
                var findeLogin = context.Users.FirstOrDefault(l => l.Login == Login);
                if (findeLogin != null) { user = findeLogin; return true; }
                else return false;
            }
        }
        //Валидация пароля
        private bool IsValidPassword(string Password, Model.User otherUser)
        {
            bool isValidPass = false;
            if (otherUser != null)
            {

                if (Password == otherUser.Password) isValidPass = true;
            }
            else isValidPass = false;
            return isValidPass;


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration RegistrationForm = new Registration(this);
            RegistrationForm.Show(this);
        }

        private void textBox_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (IsValidLogin(textBox_Login.Text) == true)
                {
                    pictureBoxLoginGood.Show(); pictureBoxLoginBad.Hide(); Vlogin = true;
                }
                else { pictureBoxLoginGood.Hide(); pictureBoxLoginBad.Show(); Vlogin = false; }


                if (IsValidPassword(textBox_Password.Text, user) == true)
                {
                    pictureBoxPasswordGood.Show(); pictureBoxPasswordBad.Hide(); Vpassword = true;

                }
                else
                {
                    pictureBoxPasswordGood.Hide(); pictureBoxPasswordBad.Show(); Vpassword = false; return;
                }

                if (Vlogin == true && Vpassword == true)
                {
                    if (GetStatusUser(getUserId(textBox_Login.Text)) == true)
                    {
                        MessageBox.Show("Пользователь уже онлайн"); return;
                    }
                    if (GetStatusUser(getUserId(textBox_Login.Text)) == false)
                    {

                        switch (GetRole(getUserId(textBox_Login.Text)))
                        {
                            case 1:
                                ChangeStatus(getUserId(textBox_Login.Text));
                                this.Hide();
                                MainForm mainForm = new MainForm(this, getUserId(textBox_Login.Text));
                                mainForm.Show();
                                textBox_Login.Text = "";
                                textBox_Password.Text = "";
                                textBox_Login.PlaceholderText = "Введите логин";
                                textBox_Password.PlaceholderText = "Введите пароль";
                                pictureBoxLoginBad.Hide();
                                pictureBoxLoginGood.Hide();
                                pictureBoxPasswordBad.Hide();
                                pictureBoxPasswordGood.Hide(); break;
                            case 2:
                                ChangeStatus(getUserId(textBox_Login.Text));
                                this.Hide();
                                AdminMainForm adminForm = new AdminMainForm(this, getUserId(textBox_Login.Text));
                                adminForm.Show();
                                textBox_Login.Text = "";
                                textBox_Password.Text = "";
                                textBox_Login.PlaceholderText = "Введите логин";
                                textBox_Password.PlaceholderText = "Введите пароль";
                                pictureBoxLoginBad.Hide();
                                pictureBoxLoginGood.Hide();
                                pictureBoxPasswordBad.Hide();
                                pictureBoxPasswordGood.Hide(); break;
                        }
                    }

                }

            }
        }
    }
}
