using Microsoft.VisualBasic.ApplicationServices;
using ProgectE.DataContext;
using ProgectE.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgectE.Forms.Order
{
    public partial class ShowOrdersForm : Form
    {
        int refIdUser = 0;

        public ShowOrdersForm(int idUser)
        {
            this.refIdUser = idUser;
            InitializeComponent();
            LoadAutoCompleateKontragent();
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            dateTimePicker1.Value = DateTime.Now;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadfromBDdate();
        }
        private void ShowOrdersForm_Load(object sender, EventArgs e)
        {
            customizeDesign();
            StartSettingDataGrid();
            LoadAllData();
            SettinInputTextBox();
            SettingPlaceholderTextBox();
            LoadComboBoxYear(refIdUser);
            LoadAutoCompleateKontragent();
            LoadAutoCompleateRemKarta();
          
        }

       
        //Настроки TEXTBOX-------->
        // формата водимых данных
        private void SettinInputTextBox()
        {
            textBox_NumberOfCard.KeyPress += (object sender, KeyPressEventArgs e) => { KeyNumberPress(e); };
            textBox_FindeRemKarta.KeyPress += (object sender, KeyPressEventArgs e) => { KeyNumberPress(e); };
            textBox_InvoiceToClient.KeyPress += (object sender, KeyPressEventArgs e) => { KeyNumberPressAndTochka(e); };
            textBox_PriceOfMaterial.KeyPress += (object sender, KeyPressEventArgs e) => { KeyNumberPressAndTochka(e); };
            textBox_CountBaraban.KeyPress += (object sender, KeyPressEventArgs e) => { KeyNumberPress(e); };
            textBox_TotalCartrige.KeyPress += (object sender, KeyPressEventArgs e) => { KeyNumberPress(e); };
        }
        //placeholder для textbox
        private void SettingPlaceholderTextBox()
        {
            textBoxFindeKontrAgent.PlaceholderText = "название контрагента";
            textBox_FindeRemKarta.PlaceholderText = "номер ремонтной карты";
            textBox_NumberOfCard.PlaceholderText = "Введите номер ремонтной карты";
            textBox_KontrAgent.PlaceholderText = "Введите название контрагента";
            textBox_InvoiceToClient.PlaceholderText = "Введите счет клиенту";
            textBox_PriceOfMaterial.PlaceholderText = "Введите стоимость материалов";
            textBox_CountBaraban.PlaceholderText = "Введите количество фотобарабанов";
            textBox_TotalCartrige.PlaceholderText = "Введите количество картриджей";
        }
        //формат ввода 1
        private void KeyNumberPress(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }
        //формат ввода 2
        private void KeyNumberPressAndTochka(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }
        //загрузка автозаполнения КонтрАгента
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
            textBox_KontrAgent.AutoCompleteCustomSource = source;
            textBox_KontrAgent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox_KontrAgent.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxFindeKontrAgent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxFindeKontrAgent.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        //загрузка автозаполнения ремКарта
        private void LoadAutoCompleateRemKarta()
        {
            List<int?> remKartaList = new List<int?>();
            using (var context = new AppDbContext())
            {
                remKartaList = context.Orders.Where(x => x.UserId == refIdUser).Select(x => x.NumberRemKart).ToList();
            }
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            remKartaList.ForEach(x => source.Add(x.ToString()));
            textBox_FindeRemKarta.AutoCompleteCustomSource = source;
            textBox_FindeRemKarta.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox_FindeRemKarta.AutoCompleteSource = AutoCompleteSource.CustomSource;
        } 

        //Настроки TEXTBOX<--------

        //Получение данных------->
        //список счетов конкретного клиента
        private List<Model.Order> GetOrderList(int idUser)
        {
            List<Model.Order> findeOrder = new List<Model.Order>();
            using (var context = new AppDbContext())
            {
                findeOrder = context.Orders.Where(x => x.UserId == idUser).ToList();
            }
            return findeOrder;
        }
        //список счетов по выбранной дате
        private void LoadfromBDdate()
        {
            using (var context = new AppDbContext())
            {
                dataGridView1.DataSource = context.Orders.Where(x => x.UserId == refIdUser && x.Created == dateTimePicker1.Value.ToString("dd.MM.yyyy")).ToList();
            }
        }
        //все счета пользователя
        private void LoadAllData()
        {
            using (var context = new AppDbContext())
            {
                dataGridView1.DataSource = GetOrderList(refIdUser);
            }
            
        }
        //процент по сделке
        private double GetPersent()
        {
            double persent;
            using (var context = new AppDbContext())
            {
                persent = Math.Round(((double)(context.Users.FirstOrDefault(x => x.UserId == refIdUser)).Percent) / 100, 2);
            }
            return persent;
        }
        //Получение списка месяцев  в заданном году
        private List<Model.Month> GetListMonthsInYear(string year, int idUser)
        {
            List<Model.Month> monthInYear = new List<Model.Month>();
            bool conteinsMoth = false;
            foreach (var order in GetOrderList(idUser))
            {
                string years = DateTime.Parse(order.Created).ToString("yyyy");
                if (years == year)
                {
                    string month = DateTime.Parse(order.Created).ToString("MMMM");
                    Model.Month statistic = new Model.Month { Month_ = month, NumbMonth_ = GetNumberMonth(month) };
                    var findeItem = monthInYear.FirstOrDefault(x => x.Month_ == statistic.Month_ && x.NumbMonth_ == statistic.NumbMonth_);
                    if (findeItem == null)
                    {
                        monthInYear.Add(statistic);
                    }
                }
            }
            var sortedList = monthInYear.OrderBy(si => si.NumbMonth_).ToList();
            return sortedList;
        }
        //Пчисловое значения месяца по его названию
        private int GetNumberMonth(string titleMonth)
        {
            int dd = DateTime.ParseExact(titleMonth, "MMMM", System.Globalization.CultureInfo.CurrentCulture).Month;
            return dd;
        }        
        private void textBoxFindeKontrAgent_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFindeKontrAgent.Text != "")
            {
                textBox_FindeRemKarta.Enabled = false;
              
            }
            else textBox_FindeRemKarta.Enabled = true;

        }
        private void textBox_FindeRemKarta_TextChanged(object sender, EventArgs e)
        {
            if (textBox_FindeRemKarta.Text != "")
            {
                textBoxFindeKontrAgent.Enabled = false;
               
            }
            else textBoxFindeKontrAgent.Enabled = true;
        }
        //Получение данных<-------


        //Вычисления---->
        //конвертор decimal in double
        private double MyConvert(decimal numb)
        {
            double result = Convert.ToDouble(numb);
            return result;
        }
        //Подсчет прибыли Profit
        private string CalculateProfit(double firstNumb, double secondNumb)
        {
            double resultCalculate = Math.Round((firstNumb - secondNumb), 2);
            resultCalculate *= GetPersent();
            return Math.Round(resultCalculate, 2).ToString();
        }
        //Вычисления<---



        //DataGridView------->
        private void StartSettingDataGrid()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.RowHeadersVisible = false;
        }
       
        //выбор строки и перенос данных в форму для изменения
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox_NumberOfCard.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox_InvoiceToClient.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox_PriceOfMaterial.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox_CountBaraban.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox_TotalCartrige.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                using (var context = new AppDbContext())
                {
                    textBox_KontrAgent.Text = context.Kontragents.FirstOrDefault(x => x.Id == int.Parse(dataGridView1.CurrentRow.Cells[8].Value.ToString())).Title;
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        //Обновить
        private void button1_Click(object sender, EventArgs e)
        {
            LoadAllData();
        }
        //удаление выбранной строки
        private void button_Delete_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var findeElementforDeleted = context.Orders.FirstOrDefault(x => x.Id == int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                if (findeElementforDeleted != null)
                {
                    context.Orders.Remove(findeElementforDeleted);
                    context.SaveChanges();
                }
                else { return; }
            }
            LoadAllData();
        }
        //DataGridView<------
        //Контекстное меню------>
        //выбор строки и отображение контекстного меню
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Установите текущую строку как выбранную 
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
                contextMenuStrip1.Show(dataGridView1, e.Location);
            }
        }     
        //Удалить      
        private void Delete_Click(object sender, EventArgs e)
        {

            using (var context = new AppDbContext())
            {
                var findeElementforDeleted = context.Orders.FirstOrDefault(x => x.Id == int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                if (findeElementforDeleted != null)
                {
                    context.Orders.Remove(findeElementforDeleted);
                    context.SaveChanges();
                }
                else { return; }
            }
            LoadAllData();

        }
        //Изменить
        private void изменить_Click(object sender, EventArgs e)
        {
            textBox_NumberOfCard.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox_InvoiceToClient.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox_PriceOfMaterial.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox_CountBaraban.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox_TotalCartrige.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            using (var context = new AppDbContext())
            {
                textBox_KontrAgent.Text = context.Kontragents.FirstOrDefault(x => x.Id == int.Parse(dataGridView1.CurrentRow.Cells[8].Value.ToString())).Title;
            }
            showSubmenu(panel2);
        }
        //Контекстное меню<------



        //изменение счета
        private void button_Update_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var findeElement = context.Orders.FirstOrDefault(x => x.Id == int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    if (findeElement != null)
                    {

                        findeElement.NumberRemKart = int.Parse(textBox_NumberOfCard.Text);
                        findeElement.CountBaraban = int.Parse(textBox_CountBaraban.Text);
                        findeElement.InvoiceToClient = Math.Round(Convert.ToDecimal(textBox_InvoiceToClient.Text), 2);
                        findeElement.PriceOfmaterials = Math.Round(Convert.ToDecimal(textBox_PriceOfMaterial.Text), 2);
                        findeElement.TotalCartridges = int.Parse(textBox_TotalCartrige.Text);
                        LoadAutoCompleateKontragent();
                        LoadAutoCompleateRemKarta();
                        if (textBox_KontrAgent.Text == "")
                        {
                            findeElement.KontragentId = int.Parse(dataGridView1.CurrentRow.Cells[8].Value.ToString());
                        }
                        if (textBox_KontrAgent.Text != "")
                        {
                            var kontrA = context.Kontragents.FirstOrDefault(x => x.Title == textBox_KontrAgent.Text);
                            if (kontrA != null)
                            {
                                findeElement.KontragentId = kontrA.Id;
                            }
                            else
                            {
                                DialogResult result = MessageBox.Show(
                                 "Такого контрагента нету, Добавить?",
                                   "Сообщение",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Information,
                                    MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.DefaultDesktopOnly);
                                if (result == DialogResult.Yes)
                                {
                                    Model.Kontragent kontragent = new Model.Kontragent();
                                    kontragent.Title = textBox_KontrAgent.Text;
                                    context.Kontragents.Add(kontragent);
                                    LoadAutoCompleateKontragent();
                                    LoadAutoCompleateRemKarta();
                                }
                                kontrA = context.Kontragents.FirstOrDefault(x => x.Title == textBox_KontrAgent.Text);
                                if (kontrA != null)
                                {
                                    findeElement.KontragentId = kontrA.Id;
                                }
                                else { MessageBox.Show("Null"); }
                            }
                        }
                        findeElement.Profit = CalculateProfit(MyConvert(findeElement.InvoiceToClient), MyConvert(findeElement.PriceOfmaterials));
                        if (double.Parse(findeElement.Profit) > 0)
                        {
                            context.Orders.Update(findeElement);
                            context.SaveChanges();
                        }
                        else { MessageBox.Show("Введите коректное значение счета клиенту"); return; }

                    }
                    LoadAllData();
                }
            }
            catch (Exception ex) { MessageBox.Show("Заполните все поля для ввода"); }

        }    

      
       
        //SubMenu---------->
        //настройки
        private void customizeDesign()
        {
            panel2.Visible = false;
        }
        //скарыть
        private void hideSubmenu()
        {
            if (panel2.Visible == true) panel2.Visible = false;

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
        //выход
        private void button_Close_Click(object sender, EventArgs e)
        {
            showSubmenu(panel2);
        }
        //SubMenu<---------


        //Поиск----->
        //по названию 
        private void FindeKontragent()
        {
            using (var context = new AppDbContext())
            {
                var findeElement = context.Kontragents.FirstOrDefault(x => x.Title == textBoxFindeKontrAgent.Text).Id;
                var findeOrder = context.Orders.Where(x => x.KontragentId == findeElement && x.UserId == refIdUser).ToList();
                dataGridView1.DataSource = findeOrder;
            }
        }
        //по номеру рем.карты
        private void FindeRemKarta()
        {
            using (var context = new AppDbContext())
            {
                var findeOrder = context.Orders.Where(x => x.NumberRemKart == int.Parse(textBox_FindeRemKarta.Text) && x.UserId == refIdUser).ToList();
                if (findeOrder == null)
                {
                    MessageBox.Show("Записей с такой ремонтной\nкартой нету!");
                }
                else
                {
                    buttonFinde.Visible = true;
                    dataGridView1.DataSource = findeOrder;
                }
            }
        }
        //событие - поиск (кнопка)
        private void buttonFinde_Click(object sender, EventArgs e)
        {
            try
            {            
                if (textBoxFindeKontrAgent.Enabled != false)
                {
                    if (textBoxFindeKontrAgent.Text != "") { FindeKontragent(); }else return;
                   
                }
                if (textBox_FindeRemKarta.Enabled != false)
                {
                    if (textBox_FindeRemKarta.Text != "") { FindeRemKarta(); } else return;
                   
                }
            }
            catch (Exception ex) { MessageBox.Show(" buttonFinde_Click\n" + ex.Message);}





        }
        //по месяцу и году
        private void button_Finde2_Click(object sender, EventArgs e)
        {
            if (comboBox_Year.SelectedItem != null && comboBox_Month.SelectedItem != null)
            {
                string? month = comboBox_Month.SelectedItem.ToString();
                string? year = comboBox_Year.SelectedItem.ToString();
                List<Model.Order> FindeorderList = new List<Model.Order>();
                foreach (var item in GetOrderList(refIdUser))
                {
                    if (DateTime.Parse(item.Created).ToString("MMMM") == month && DateTime.Parse(item.Created).ToString("yyyy") == year)
                    {
                        FindeorderList.Add(item);
                    }

                }
                dataGridView1.DataSource = FindeorderList;

            }


        }              
        //Поиск<-----

        //Форма добавления нового счета
        private void button_Add_Click(object sender, EventArgs e)
        {
            Form form = new AddOrderForm(refIdUser);
            form.ShowDialog();
        }        
        //Загрузка комбобок списком лет, за которые есть записи
        private void LoadComboBoxYear(int idUser)
        {
            List<string> yearContener = new List<string>();
            bool conteinsYear = false;
            foreach (var order in GetOrderList(refIdUser))
            {
                string years = DateTime.Parse(order.Created).ToString("yyyy");
                conteinsYear = yearContener.Contains(years);
                if (conteinsYear == false) yearContener.Add(years);
            }
            yearContener.ForEach(x => comboBox_Year.Items.Add(x));

        }
        //Загрузка комбобок списком месяца, за которые есть записи
        private void comboBox_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Month.Items.Clear();
            foreach (var item in GetListMonthsInYear(comboBox_Year.SelectedItem.ToString(), refIdUser))
            {
                comboBox_Month.Items.Add(item.Month_);
            }

        }

       

       
    }
}
