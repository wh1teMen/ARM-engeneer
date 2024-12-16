using ProgectE.Model;
using System;
using ProgectE.DataContext;
using System.Reflection.Metadata.Ecma335;

namespace PogectE
{
    public partial class Registration : Form
    {
        Form ref_FormAuthorization;
        public Registration(Form f)
        {
            InitializeComponent();
            InitializeDatabase();
            ref_FormAuthorization = f;
        }

        private void InitializeDatabase()
        {
            using (var context = new AppDbContext())
            {
                context.Database.EnsureCreated(); // Создаем базу данных, если она не существует
            }
        }
        private bool closeParam = false;
        //Load settings forms and textbox
        private void Registration_Load(object sender, EventArgs e)
        {
            SettingPlaceholder();

            textBox_Password.Text = "Введите пароль";
            textBox_Confirm.Text = "Повторите пароль";

            textBox_Password.ForeColor = Color.Gray;
            textBox_Confirm.ForeColor = Color.Gray;
        }

        // Placeholder for textbox
        private void SettingPlaceholder()
        {
            textBox_Login.PlaceholderText = "Введите логин";
            textBox_Name.PlaceholderText = "Введите имя";
            textBox_Surname.PlaceholderText = "Введите фамилию";
        }


        private void textBox_Password_Enter(object sender, EventArgs e)
        {
            if (textBox_Password.Text == "Введите пароль")
            {
                textBox_Password.Text = "";
                textBox_Password.ForeColor = Color.Black;
                textBox_Password.PasswordChar = '*';
            }
        }
        private void textBox_Password_Leave(object sender, EventArgs e)
        {
            if (textBox_Password.Text.Trim() == "")
            {
                textBox_Password.Text = "Введите пароль";
                textBox_Password.ForeColor = Color.Gray;
                textBox_Password.PasswordChar = '\0';
            }
        }
        private void textBox_Confirm_Enter(object sender, EventArgs e)
        {
            if (textBox_Confirm.Text == "Повторите пароль")
            {
                textBox_Confirm.Text = "";
                textBox_Confirm.ForeColor = Color.Black;
                textBox_Confirm.PasswordChar = '*';
            }
        }
        private void textBox_Confirm_Leave(object sender, EventArgs e)
        {
            if (textBox_Confirm.Text.Trim() == "")
            {
                textBox_Confirm.Text = "Повторите пароль";
                textBox_Confirm.ForeColor = Color.Gray;
                textBox_Confirm.PasswordChar = '\0';
            }
        }

        //Validating enter data
        private void textBox_Login_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (textBox_Login.Text == "Введите логин" || textBox_Login.Text == " ")
            {
                MessageBox.Show("Введите логин");
            }
        }
        private void textBox_Name_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox_Name.Text == "Введите имя" || textBox_Name.Text == " ")
            {
                MessageBox.Show("Введите имя");
            }
        }
        private void textBox_Password_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox_Password.Text == "Введите пароль" || textBox_Password.Text == " ")
            {
                MessageBox.Show("Введите пароль");
            }
        }
        private void textBox_Confirm_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox_Confirm.Text == "Повторите пароль" || textBox_Confirm.Text == " ")
            {
                MessageBox.Show("Введите повторно пароль");
            }
            if (textBox_Password.Text != "" && textBox_Password.Text != textBox_Confirm.Text)
            {
                MessageBox.Show("Пароли не совпадают");
            }

        }

        //Event Closing Forms
        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            ref_FormAuthorization.Show();
        }
        private void button_Registration_MouseClick(object sender, MouseEventArgs e)
        {
            RegistrationUser();

        }
        private bool CincidenceUser(string login)
        {
            User findeUser = new User();
            using (var context = new AppDbContext())
            {
                findeUser = context.Users.FirstOrDefault(x => x.Login == login);

            }

            if (findeUser == null)
                return false;
            else return true;


        }
        //Registration new User
        private void RegistrationUser()
        {
            using (var context = new AppDbContext())
            {
                User user = new User();
                if (textBox_Login.Text == "") { MessageBox.Show("Введите логин"); return; }
                if (CincidenceUser(textBox_Login.Text) == true)
                {
                    MessageBox.Show($"Пользователь с login:{textBox_Login.Text} уже зарегистрирован");

                }
                else
                {
                    user.Login = textBox_Login.Text;
                    user.Name = textBox_Name.Text;
                    user.Surname = textBox_Surname.Text;
                    if (checkBoxReg.Checked)
                    {
                        user.RoleId = 2;

                    }
                    else
                    {
                        user.RoleId = 1;
                    }
                    user.Password = textBox_Password.Text;
                    user.Percent = 23;
                    user.Salary = 20000;
                    user.Tax = 13;
                    context.Add(user);
                    context.SaveChanges();
                    this.Close();
                    ref_FormAuthorization.Show();
                }

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            ref_FormAuthorization.Show();
        }

        private void checkBoxReg_Click(object sender, EventArgs e)
        {
            Text = "регистрация админ";
        }
    }
}
