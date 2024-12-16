using Microsoft.EntityFrameworkCore.Storage.Json;
using ProgectE.DataContext;
using ProgectE.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgectE
{
    public partial class AddOrderForm : Form
    {
        private int refIdUser = 0;
        public AddOrderForm(int idUser)
        {
            this.refIdUser = idUser;
            InitializeComponent();
          
        }
        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            SettinInputTextBox();
            SettingPlaceholderTextBox();
            LoadAutoCompleateKontragent();
        }

        //Получение данных ---------->
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
        //Id Контрагента по его названию
        private int GetIDdKntragents(string Title)
        {
            using (var context = new AppDbContext())
            {
                var ListKontragent = context.Kontragents.ToList();
                int ID = ListKontragent.FirstOrDefault(x => x.Title == Title).Id;
                return ID;
            }
        }
        //Записи по номеру ремонтной карты
        private Order ?GetOrder(string NumbRemKarta)
        {
            var findeOrder = new Order();
            using (var context = new AppDbContext())
            {
                findeOrder = context.Orders.FirstOrDefault(x => x.NumberRemKart == int.Parse(NumbRemKarta) && x.UserId == refIdUser);
            }
            return findeOrder;
        }
        //Получение данных <---------

        /*Настрока TEXTBOX*///----------->        
        //валидация номер рем.карты
        private void textBox_NumberOfCard_Validating(object sender, CancelEventArgs e)
        {
            if (textBox_NumberOfCard.Text == "") { MessageBox.Show("Введите номер ремонтной карты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        //валидация сумма счета
        private void textBox_InvoiceToClient_Validating(object sender, CancelEventArgs e)
        {
            if (textBox_InvoiceToClient.Text == "") { MessageBox.Show("Введите счёт клиенту", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        //валидация кол-во фотобарабанов
        private void textBox_CountBaraban_Validating(object sender, CancelEventArgs e)
        {
            if (textBox_CountBaraban.Text == "") { MessageBox.Show("Введите количесвто фотобарабанов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        //валидация стоимости материалов
        private void textBox_PriceOfMaterial_Validating(object sender, CancelEventArgs e)
        {

            try
            {
                if (textBox_PriceOfMaterial.Text == "")
                {
                    MessageBox.Show("Введите стоимость материалов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if ((Decimal.Parse(textBox_InvoiceToClient.Text)) < (Decimal.Parse(textBox_PriceOfMaterial.Text)))
                {
                    MessageBox.Show("Счет клиенту, не может\n" +
                        "быть меньше стоимости материалов.\n" +
                        "Обратитесь к менеджеру для корректировки стоимости услуги!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex) { }
        }
        //валидация количества картриджей
        private void textBox_TotalCartrige_Validating(object sender, CancelEventArgs e)
        {
            if (textBox_TotalCartrige.Text == "0")
            {
                MessageBox.Show("Проверте корректность введеного\nколичества картриджей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (textBox_TotalCartrige.Text == "Введите количество картриджей" || textBox_TotalCartrige.Text == "")
            {
                MessageBox.Show("Введите количество картриджей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //валидация контрагента
        private void textBox_KontrAgent_Validating(object sender, CancelEventArgs e)
        {
            LoadAutoCompleateKontragent();
            using (var context = new AppDbContext())
            {
                if (textBox_KontrAgent.Text == "") { MessageBox.Show("Введите название контрагента"); }
                else
                {
                    var findeElement = context.Kontragents.FirstOrDefault(x => x.Title == textBox_KontrAgent.Text);
                    if (findeElement == null)
                    {
                        DialogResult result = MessageBox.Show(
                         "Такого контрагента еще нету,будет добавлен в базу",
                          "Сообщение",
                          MessageBoxButtons.OK,
                         MessageBoxIcon.Information,
                         MessageBoxDefaultButton.Button1,
                         MessageBoxOptions.DefaultDesktopOnly);   
                        
                         Kontragent kontragent = new Kontragent();
                         kontragent.Title = textBox_KontrAgent.Text;
                         context.Kontragents.Add(kontragent);
                         context.SaveChanges();
                         LoadAutoCompleateKontragent();
                         this.Focus();
                        
                    }
                }


            }
        }
        //автозаполнение поля для ввода контрагента
        private void LoadAutoCompleateKontragent()
        {
            List<string?> kontragentTitle = new List<string?>();
            using (var context = new AppDbContext())
            {
                kontragentTitle = context.Kontragents.Select(x => x.Title).ToList();
            }
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            kontragentTitle.ForEach(x => source.Add(x));
            textBox_KontrAgent.AutoCompleteCustomSource = source;
            textBox_KontrAgent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox_KontrAgent.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        //настройка формата водимых данных
        private void SettinInputTextBox()
        {
            textBox_NumberOfCard.KeyPress += (object sender, KeyPressEventArgs e) => { KeyNumberPress(e); };
            textBox_InvoiceToClient.KeyPress += (object sender, KeyPressEventArgs e) => { KeyNumberPressAndTochka(e); };
            textBox_PriceOfMaterial.KeyPress += (object sender, KeyPressEventArgs e) => { KeyNumberPressAndTochka(e); };
            textBox_CountBaraban.KeyPress += (object sender, KeyPressEventArgs e) => { KeyNumberPress(e); };
            textBox_TotalCartrige.KeyPress += (object sender, KeyPressEventArgs e) => { KeyNumberPress(e); };
        }
        //настройка placeholder для textbox
        private void SettingPlaceholderTextBox()
        {
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
        /*Настрока TEXTBOX*///<-----------

        //Счёт---------->        
        //Метод - Добавление нового счета 
        private void AddNewOrder()
        {
            Order order = new Order();
            bool isValidRem = IsValidRemKarta(textBox_NumberOfCard.Text);
            try
            {
                order.UserId = refIdUser;
                if (isValidRem == false)
                {
                    order.NumberRemKart = int.Parse(textBox_NumberOfCard.Text);          
                    order.KontragentId = GetIDdKntragents(textBox_KontrAgent.Text);
                    order.InvoiceToClient = Math.Round(Convert.ToDecimal(textBox_InvoiceToClient.Text), 2);
                    order.PriceOfmaterials = Math.Round(Convert.ToDecimal(textBox_PriceOfMaterial.Text), 2);
                    order.CountBaraban = int.Parse(textBox_CountBaraban.Text);
                    order.TotalCartridges = int.Parse(textBox_TotalCartrige.Text);
                    order.Profit = CalculateProfit(MyConvert(order.InvoiceToClient), MyConvert(order.PriceOfmaterials));
                    if (double.Parse(order.Profit) > 0d)
                    {
                        using (var context = new AppDbContext())
                        {
                            context.Orders.Add(order);
                            context.SaveChanges();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Введите коректное значение счета клиенту Error-AddNewOrder", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
               
                if (isValidRem == true)
                {

                    MessageBox.Show($"Такая ремонтная карта уже существует\nВоспльзуйтесь поиском по номеру ремонтной карты\n" +
                        $"После чего->правой кнопкой по рем.карте и выбрать свойство \"изменить\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex) { MessageBox.Show($"Заполните все поля для ввода  Error-AddNewOrder", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

        }
        
        //Событие - Добавление счета 
        private void button_AddOrder_Click_1(object sender, EventArgs e)
        {
            AddNewOrder();
            this.Close();
        }
        //Удаление выбранного счета
        private void DeleteOrder(string NumberRemkart)
        {
            using (var context = new AppDbContext())
            {
                var findeElementforDeleted = context.Orders.FirstOrDefault(x => x.NumberRemKart == int.Parse(NumberRemkart));
                if (findeElementforDeleted != null)
                {
                    context.Orders.Remove(findeElementforDeleted);
                    context.SaveChanges();
                }
                else { return; }
            }
        }
        //Проверка, существует ли счет с таким номером ремонтной карты
        private bool IsValidRemKarta(string Numbremkarta)
        {
            bool validRemKarta = false;
            int NumbReKarta = int.Parse(Numbremkarta);
            using (var context = new AppDbContext())
            {
                if (GetOrder(Numbremkarta) != null)
                {
                    return validRemKarta = true;
                }
                else return validRemKarta = false;
            }         
        }
        //Счёт<---------  

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
        //Вычисления<---- 
        
    }
}
