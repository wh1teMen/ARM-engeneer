using ProgectE.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgectE
{
    public partial class ProfilForm : Form
    {
        private int refIdUser = 0;
        private int Roleid = 0;
        public ProfilForm(int idUser, int id = 1)
        {
            this.refIdUser = idUser;
            this.Roleid = id;
            InitializeComponent();
            Text = refIdUser.ToString() + id.ToString();
        }

        private void LoadData()
        {
           // Text = refIdUser.ToString();
            using (var context = new AppDbContext())
            {

                var User = context.Users.FirstOrDefault(x => x.UserId == refIdUser);

                if (Roleid == 1)
                {
                    panel_role.Visible = false;
                    button_reset.Visible = false;
                    pictureBox_key.Visible = false;

                }
                if (User != null)
                {
                    textBox_Name.Text = User?.Name != null ? User?.Name : textBox_Name.PlaceholderText = "";
                    textBox_Surname.Text = User?.Surname != null ? User?.Surname : textBox_Surname.PlaceholderText = "";
                    textBox_Patronymic.Text = User?.Patronymic != null ? User?.Patronymic : "";
                    textBox_Email.Text = User?.Email != null ? User.Email : textBox_Email.PlaceholderText = "";
                    textBox_Salary.Text = User?.Salary != null ? User?.Salary.ToString() : textBox_Salary.PlaceholderText = "";
                    textBox_Percent.Text = User?.Percent != null ? User?.Percent.ToString() : textBox_Percent.PlaceholderText = "";
                    textBox_Tax.Text = User?.Tax != null ? User?.Tax.ToString() : textBox_Tax.PlaceholderText = "";
                    maskedTextBox_Telephone.Text = User?.Telephone != null ? User?.Telephone : maskedTextBox_Telephone.Text = "+7(000) 000-0000";
                    textBox_password.Text = User.Password;
                    textBox_role.Text = User.RoleId.ToString();
                    checkBox1.Checked = User.Status;
                    if (User?.ImageData != null)
                    {
                        using (var ms = new MemoryStream(User.ImageData))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox1.Dock = DockStyle.Fill;
                        }
                    }
                }





                //  Text = User.RoleId.ToString() + "/"+ Roleid.ToString();
                /*Text = User.RoleId.ToString();
                if (Roleid != 1)
                {
                    button_reset.Visible = true;
                    pictureBox_key.Visible = true;
                    label_pass.Visible = false;
                    textBox_password.Visible = false;

                }
                panel_role.Visible = false;
                button_reset.Visible = false;
                pictureBox_key.Visible = false;
                textBox_Name.Text = User?.Name != null ? User?.Name : textBox_Name.PlaceholderText = "";
                textBox_Surname.Text = User?.Surname != null ? User?.Surname : textBox_Surname.PlaceholderText = "";
                textBox_Patronymic.Text = User?.Patronymic != null ? User?.Patronymic : "";
                textBox_Email.Text = User?.Email != null ? User.Email : textBox_Email.PlaceholderText = "";
                textBox_Salary.Text = User?.Salary != null ? User?.Salary.ToString() : textBox_Salary.PlaceholderText = "";
                textBox_Percent.Text = User?.Percent != null ? User?.Percent.ToString() : textBox_Percent.PlaceholderText = "";
                textBox_Tax.Text = User?.Tax != null ? User?.Tax.ToString() : textBox_Tax.PlaceholderText = "";
                maskedTextBox_Telephone.Text = User?.Telephone != null ? User?.Telephone : maskedTextBox_Telephone.Text = "+7(000) 000-0000";
                textBox_password.Text = User.Password;
                textBox_role.Text = User.RoleId.ToString();
                checkBox1.Checked = User.Status;
                if (User?.ImageData != null)
                {
                    using (var ms = new MemoryStream(User.ImageData))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Dock = DockStyle.Fill;
                    }
                }*/
                /*if (User != null)
                 {*/
                if (Roleid == 1)
                     {
                         panel_role.Visible = false;
                         button_reset.Visible = false;
                         pictureBox_key.Visible = false;
                         textBox_Name.Text = User?.Name != null ? User?.Name : textBox_Name.PlaceholderText = "";
                         textBox_Surname.Text = User?.Surname != null ? User?.Surname : textBox_Surname.PlaceholderText = "";
                         textBox_Patronymic.Text = User?.Patronymic != null ? User?.Patronymic : "";
                         textBox_Email.Text = User?.Email != null ? User.Email : textBox_Email.PlaceholderText = "";
                         textBox_Salary.Text = User?.Salary != null ? User?.Salary.ToString() : textBox_Salary.PlaceholderText = "";
                         textBox_Percent.Text = User?.Percent != null ? User?.Percent.ToString() : textBox_Percent.PlaceholderText = "";
                         textBox_Tax.Text = User?.Tax != null ? User?.Tax.ToString() : textBox_Tax.PlaceholderText = "";
                         maskedTextBox_Telephone.Text = User?.Telephone != null ? User?.Telephone : maskedTextBox_Telephone.Text = "+7(000) 000-0000";
                         textBox_password.Text = User.Password;
                         textBox_role.Text = User.RoleId.ToString();
                         checkBox1.Checked = User.Status;
                         if (User?.ImageData != null)
                         {
                             using (var ms = new MemoryStream(User.ImageData))
                             {
                                 pictureBox1.Image = Image.FromStream(ms);
                                 pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                 pictureBox1.Dock = DockStyle.Fill;
                             }
                         }
                     }


                     if (Roleid == 2)
                     {
                         button_reset.Visible = true;
                         pictureBox_key.Visible = true;
                         label_pass.Visible = false;
                         textBox_password.Visible = false;
                         textBox_Name.Text = User?.Name != null ? User?.Name : textBox_Name.PlaceholderText = "";
                         textBox_Surname.Text = User?.Surname != null ? User?.Surname : textBox_Surname.PlaceholderText = "";
                         textBox_Patronymic.Text = User?.Patronymic != null ? User?.Patronymic : "";
                         textBox_Email.Text = User?.Email != null ? User.Email : textBox_Email.PlaceholderText = "";
                         textBox_Salary.Text = User?.Salary != null ? User?.Salary.ToString() : textBox_Salary.PlaceholderText = "";
                         textBox_Percent.Text = User?.Percent != null ? User?.Percent.ToString() : textBox_Percent.PlaceholderText = "";
                         textBox_Tax.Text = User?.Tax != null ? User?.Tax.ToString() : textBox_Tax.PlaceholderText = "";
                         maskedTextBox_Telephone.Text = User?.Telephone != null ? User?.Telephone : maskedTextBox_Telephone.Text = "+7(000) 000-0000";
                         textBox_password.Text = User.Password;
                         textBox_role.Text = User.RoleId.ToString();
                         checkBox1.Checked = User.Status;
                         if (User?.ImageData != null)
                         {
                             using (var ms = new MemoryStream(User.ImageData))
                             {
                                 pictureBox1.Image = Image.FromStream(ms);
                                 pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                 pictureBox1.Dock = DockStyle.Fill;
                             }
                         }
                     }



               //  }
            }

        }

        private void ProfilForm_Load(object sender, EventArgs e)
        {
            LoadData();
            SettingPlaceholderTextBox();
        }
        //PlaceHolder
        private void SettingPlaceholderTextBox()
        {
            /*Начальные настройки TextBox*/
            textBox_Name.PlaceholderText = "Имя";
            textBox_Surname.PlaceholderText = "Фамилия";
            textBox_Patronymic.PlaceholderText = "Отчество";
            textBox_Email.PlaceholderText = "Ivanov@gmail.com";
            textBox_Percent.PlaceholderText = "% Сделка";
            textBox_Salary.PlaceholderText = "Оклад";
            textBox_Tax.PlaceholderText = "Подоходный налог";
        }
        //Валидация Email
        private void textBox_Email_Validating(object sender, CancelEventArgs e)
        {
            if (IsValidEmail(textBox_Email.Text) == false &&
                textBox_Email.Text != "Введите адрес электронной почты" &&
                textBox_Email.Text != "")
            {
                MessageBox.Show("Вы ввели не корректный\nадрес электронной почты!!!\n" +
                    "Пример:Ivanov@gmail.com");
            }
        }
        //Валидация введенного адреса электронной почты
        private bool IsValidEmail(string email)
        {
            const string pattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(email);
            if (matches.Count > 0)
            {
                return true;
            }
            else { return false; }

        }
        string path = string.Empty;
        //Сохранение данных
        private void button_Save_Click(object sender, EventArgs e)
        {
            SaveDateUser();
        }
        //Сохранение измененныъ данных
        private void SaveDateUser()
        {
            using (var context = new AppDbContext())
            {
                var user = context.Users.FirstOrDefault(x => x.UserId == refIdUser);
                user.Name = textBox_Name.Text != "" ? textBox_Name.Text : "null";
                user.Surname = textBox_Surname.Text != "" ? textBox_Surname.Text : textBox_Surname.PlaceholderText = "";
                user.Patronymic = textBox_Patronymic.Text != "" ? textBox_Patronymic.Text : textBox_Patronymic.PlaceholderText = "";
                user.Email = textBox_Email.Text != "" ? textBox_Email.Text : textBox_Email.PlaceholderText = "";
                user.Telephone = maskedTextBox_Telephone.Text != "" ? maskedTextBox_Telephone.Text : "";
                user.Percent = textBox_Percent.Text != "" ? Double.Parse(textBox_Percent.Text) : 0;
                user.Salary = textBox_Salary.Text != "" ? Double.Parse(textBox_Salary.Text) : 0;
                user.Tax = textBox_Tax.Text != "" ? Double.Parse(textBox_Tax.Text) : 0;
                user.ImageData = path != string.Empty ? ImageToByteArray(path) : user.ImageData;
                user.RoleId = int.Parse(textBox_role.Text);
                user.Password = textBox_password.Text;
                user.Status = checkBox1.Checked;
                context.Users.Update(user);
                context.SaveChanges();
            }
        }

        //Выгрузка картинки в БД
        static byte[] ImageToByteArray(string imagePath)
        {
            using (Image image = Image.FromFile(imagePath))
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Используйте нужный вам формат
                return ms.ToArray();
            }
        }
        //Загрузка картинки в БД
        private void button_LoadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    path = ofd.FileName;
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Dock = DockStyle.Fill;
                    SaveDateUser();
                    // Сохраните изображение в базу данных

                }
            }

        }
        //сброс пароля
        private void button_reset_Click(object sender, EventArgs e)
        {
            ResetPassword();
        }

        private void ResetPassword()
        {
            using (var context = new AppDbContext())
            {
                var user = context.Users.FirstOrDefault(x => x.UserId == refIdUser);
                user.Name = user.Name;
                user.Surname = user.Surname;
                user.Patronymic = user.Patronymic;
                user.Email = user.Email;
                user.Telephone = user.Telephone;
                user.Percent = user.Percent;
                user.Salary = user.Salary;
                user.Tax = user.Tax;
                user.ImageData = user.ImageData;
                user.RoleId = user.RoleId;
                user.Password = "0000";
                user.Status = user.Status;
                context.Users.Update(user);
                context.SaveChanges();
            }
            MessageBox.Show("Пароль успешно сброшен\nНовый пароль: 0000", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
