using Microsoft.EntityFrameworkCore;
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

namespace ProgectE.Forms.Kontragent
{
    public partial class ShowKontrAgentForm : Form
    {
        public ShowKontrAgentForm()
        {
            InitializeComponent();           
        }

        private void ShowKontrAgentForm_Load(object sender, EventArgs e)
        {
            customizeDesign();
            LoadAutoCompleateKontragent();
            SettingPlaceholderTextBox();
            LoadAllData();
            StartSettingDataGrid();
            textBox_id.KeyPress += (object sender, KeyPressEventArgs e) => { KeyNumberPress(e); };
        }
        //Событие сохранение изменений
        private void button_update_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var kontragent = context.Kontragents.FirstOrDefault(x => x.Id == int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                if (kontragent != null)
                {
                    kontragent.Title = textBox_Title.Text;
                    kontragent.Adress = textBox_Adress.Text;
                    kontragent.Email = textBox_Email.Text;
                    kontragent.Telephone = maskedTextBox_Telephone.Text;
                    kontragent.ContactUserName = textBox_ContactUser.Text;
                    kontragent.Discription = textBox_Description.Text;
                    context.Kontragents.Update(kontragent);
                    context.SaveChanges();
                    LoadAllData();
                }
            }
        }
        //Отображение формы добавления нового контрагента
        private void button_Add_Click(object sender, EventArgs e)
        {
            Form form = new AddKontrAgentForm();
            form.ShowDialog();
        }

        //DataGridView---------------->
        //Загрузка вех конрагентов
        private void LoadAllData()
        {           
            using (var context = new AppDbContext())
            {
                dataGridView1.DataSource = context.Kontragents.ToList();
            }           
        }
        //настройка DataGridView
        private void StartSettingDataGrid()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.RowHeadersVisible = false;
        }
        //обновление 
        private void button_refresh_Click(object sender, EventArgs e)
        {
            LoadAllData();
            LoadAutoCompleateKontragent();
        }
        //Событие выбора строки
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox_Title.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[2].Value == null) { maskedTextBox_Telephone.Text = "+7(000) 000-0000"; }
            if (dataGridView1.CurrentRow.Cells[2].Value != null) { maskedTextBox_Telephone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString(); }

            if (dataGridView1.CurrentRow.Cells[3].Value == null) { textBox_Email.Text = ""; }
            if (dataGridView1.CurrentRow.Cells[3].Value != null) { textBox_Email.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString(); }

            if (dataGridView1.CurrentRow.Cells[4].Value == null) { textBox_Adress.Text = ""; }
            if (dataGridView1.CurrentRow.Cells[4].Value != null) { textBox_Adress.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString(); }

            if (dataGridView1.CurrentRow.Cells[5].Value == null) { textBox_ContactUser.Text = ""; }
            if (dataGridView1.CurrentRow.Cells[5].Value != null) { textBox_ContactUser.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString(); }

            if (dataGridView1.CurrentRow.Cells[6].Value == null) { textBox_Description.Text = ""; }
            if (dataGridView1.CurrentRow.Cells[6].Value != null) { textBox_Description.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString(); }
        }
        //DataGridView<----------------

        //Настройки TextBox----------->
        private void SettingPlaceholderTextBox()
        {            
            textBoxFindeKontrAgent.PlaceholderText = "название контрагента";
            textBox_Title.PlaceholderText = "Введите название контрагента";
            textBox_Adress.PlaceholderText = "Введите адрес";
            textBox_Email.PlaceholderText = "Введите адрес электронной почты";
            textBox_ContactUser.PlaceholderText = "Введите имя контактного лица";
            textBox_Description.PlaceholderText = "Введите описание.....";
            textBox_id.PlaceholderText = "ID";
        }
        //автозаполнение поля контрагенты
        private void LoadAutoCompleateKontragent()
        {
            List<string?> kontragentTitle = new List<string?>();
            using (var context = new AppDbContext())
            {
                kontragentTitle = context.Kontragents.Select(x => x.Title).ToList();
            }
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            kontragentTitle.ForEach(x => source.Add(x));
            textBoxFindeKontrAgent.AutoCompleteCustomSource = source;
            textBoxFindeKontrAgent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxFindeKontrAgent.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }      
        //Событие проверки Электронной почты
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
        //Настройки TextBox<----------



        //SubMenuStart---------->
        //начальные настройки
        private void customizeDesign()
        {
            panel1.Visible = false;
        }
        //скрыть
        private void hideSubmenu()
        {
            if (panel1.Visible == true) panel2.Visible = false;
        }
        //показать
        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else { submenu.Visible = false; }
        }      
        //Закрытие Submenu
        private void button_Close_Click(object sender, EventArgs e)
        {
            showSubmenu(panel1);
        }
        //SubMenuFinish<------------

       

        //Контекстно меню---->
        //Изменить
        private void Update_Click(object sender, EventArgs e)
        {
            textBox_Title.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[2].Value == null) { maskedTextBox_Telephone.Text = "+7(000) 000-0000"; }
            if (dataGridView1.CurrentRow.Cells[2].Value != null) { maskedTextBox_Telephone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString(); }

            if (dataGridView1.CurrentRow.Cells[3].Value == null) { textBox_Email.Text = ""; }
            if (dataGridView1.CurrentRow.Cells[3].Value != null) { textBox_Email.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString(); }

            if (dataGridView1.CurrentRow.Cells[4].Value == null) { textBox_Adress.Text = ""; }
            if (dataGridView1.CurrentRow.Cells[4].Value != null) { textBox_Adress.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString(); }

            if (dataGridView1.CurrentRow.Cells[5].Value == null) { textBox_ContactUser.Text = ""; }
            if (dataGridView1.CurrentRow.Cells[5].Value != null) { textBox_ContactUser.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString(); }

            if (dataGridView1.CurrentRow.Cells[6].Value == null) { textBox_Description.Text = ""; }
            if (dataGridView1.CurrentRow.Cells[6].Value != null) { textBox_Description.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString(); }
            showSubmenu(panel1);
        }
        //Удалить       
        private void Delete_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var findeElementforDeleted = context.Kontragents.FirstOrDefault(x => x.Id == int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                var order = context.Orders.Where(x => x.KontragentId == findeElementforDeleted.Id).ToList();
                if (order.Count() > 0) { MessageBox.Show("Нельзя удалить данного контрагента"); }
                else
                {
                    if (findeElementforDeleted != null)
                    {
                        context.Kontragents.Remove(findeElementforDeleted);
                        context.SaveChanges();
                    }
                    else { return; }
                }
            }
            LoadAllData();
        }
        //отображение контекстного меню при выборе
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Установите текущую строку как выбранную 
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
                // контекстное меню
                contextMenuStrip1.Show(dataGridView1, e.Location);
            }
        }
        //Контекстно меню<----


        //Поиск---------->
        //Поиск контрагента по названию
        private void FindeKontragentTitle()
        {
            using (var context = new AppDbContext())
            {
                var findeIdelement = context.Kontragents.FirstOrDefault(x => x.Title == textBoxFindeKontrAgent.Text);
                if (findeIdelement != null)
                {
                    dataGridView1.DataSource = context.Kontragents.Where(x => x.Id == findeIdelement.Id).ToList();
                }
                else return;
            }
        }
        //Поиск контрагента по id
        private void FindeKontragentID()
        {
            using (var context = new AppDbContext())
            {
                var findeIdelement = context.Kontragents.FirstOrDefault(x => x.Id == int.Parse(textBox_id.Text));
                if (findeIdelement != null)
                {
                    dataGridView1.DataSource = context.Kontragents.Where(x => x.Id == findeIdelement.Id).ToList();
                }
                else return;
            }
        }
        //Событе поиска
        private void buttonFinde_Click(object sender, EventArgs e)
        {
            if (textBoxFindeKontrAgent.Enabled != false)
            {
                FindeKontragentTitle();
            }
            if (textBox_id.Enabled != false)
            {
                FindeKontragentID();
            }
        }

        //Настройки полей для поиска----->
        //поиск по имени
        private void textBox_id_TextChanged(object sender, EventArgs e)
        {
            if (textBox_id.Text != "")
            {
                textBoxFindeKontrAgent.Enabled = false;
            }
            else textBoxFindeKontrAgent.Enabled = true;
        }
        //поиск по id
        private void textBoxFindeKontrAgent_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFindeKontrAgent.Text != "")
            {
                textBox_id.Enabled = false;
            }
            else textBox_id.Enabled = true;

        }
        //настройка вводимых символов
        private void KeyNumberPress(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }

        //Настройка полей для поиска<------

        //Поиск<-----------





    }
}
