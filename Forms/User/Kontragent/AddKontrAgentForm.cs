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
using ProgectE.DataContext;
using ProgectE.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProgectE
{
    public partial class AddKontrAgentForm : Form
    {
        public AddKontrAgentForm()
        {
            InitializeComponent();
        }
        private void KontrAgentForm_Load(object sender, EventArgs e)
        {
            SettingPlaceholderTextBox();
        }
        //Начальные настройки TextBox
        private void SettingPlaceholderTextBox()
        {           
            textBox_Title.PlaceholderText = "Введите название контрагента";
            textBox_Adress.PlaceholderText = "Введите адрес";
            textBox_Email.PlaceholderText = "Введите адрес электронной почты";
            textBox_ContactUser.PlaceholderText = "Введите имя контактного лица";
            textBox_Description.PlaceholderText = "Введите описание.....";
        }

        /*Адрес электронной почты пользователя*///----->
        //Событие проверки введенного адреса электронной почты
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
        //<----------------------------------------------

        /*Добавление новго контрагента*///---->
        //Событие добавления нового контрагента
        private void button_Add_Click(object sender, EventArgs e)
        {
            AddContrAgent();
            this.Close();
        }
        //Метод добавление новго Контрагента
        private void AddContrAgent()
        {
            using (var context = new AppDbContext())
            {
                Kontragent kontragent = new Kontragent();
                kontragent.Title = textBox_Title.Text;
                kontragent.Adress = textBox_Adress.Text;
                kontragent.Email = textBox_Email.Text;
                kontragent.Telephone = maskedTextBox_Telephone.Text;
                kontragent.ContactUserName = textBox_ContactUser.Text;
                kontragent.Discription = textBox_Description.Text;
                context.Kontragents.Add(kontragent);
                context.SaveChanges();
            }
        }
        //<-----------------------------------

      
    }
}
