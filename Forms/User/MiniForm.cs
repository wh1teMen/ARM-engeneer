using ProgectE.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgectE.Forms.User
{
    public partial class MiniForm : Form
    {
        bool sidebarExpand;
        private Form active;
        int refIdUser = 0;
        //Form MainF= new MainForm();
        MainForm refMainForm = null;
        public MiniForm(MainForm otherAuthorization, int idUser)
        {
            InitializeComponent();
            refIdUser = idUser;
            this.refMainForm = otherAuthorization;
        }

        private void button_full_Click(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            AddOrderForm addOrderForm = new AddOrderForm(refIdUser);
            addOrderForm.Show();
        }

        private void MiniForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            refMainForm.Show();
            this.Hide();
        }

        private string GetMonthfromDate(string date)
        {
            string[] words = date.Split(new char[] { '.' });
            return words[1];
        }
        private string GetYearfromDate(string date)
        {
            string[] words = date.Split(new char[] { '.' });
            return words[2];
        }

        private async void LoadingProfit()
        {
            while (true)
            {
                using (var context = new AppDbContext())
                {

                    var orderUser = context.Orders.Where(x => x.UserId == refIdUser).ToList();

                    Decimal Sum = 0;
                    Decimal Sum2 = 0;
                    if (orderUser != null)
                    {

                        var orderUserDay = orderUser.Where(x => DateTime.Now.ToString(x.Created) == DateTime.Now.ToString("dd.MM.yyyy")).ToList();
                        orderUserDay.ForEach(x => Sum2 += Convert.ToDecimal(x.Profit));
                        label_ToDay.Text = Math.Round(Sum2, 2).ToString();

                        var orderUserMonth = orderUser.Where(x => GetMonthfromDate(x.Created) == DateTime.Now.ToString("MM")
                        && GetYearfromDate(x.Created) == DateTime.Now.ToString("yyyy")).ToList();
                        orderUserMonth.ForEach(x => Sum += Convert.ToDecimal(x.Profit));
                        label_toMonth.Text = Math.Round(Sum, 2).ToString();

                    }
                    else label_toMonth.Text = "0";
                }
                await Task.Delay(100);
            }


        }

        private void MiniForm_Load(object sender, EventArgs e)
        {

            LoadingProfit();
        }

        //notifi**********************************************************************************************
        private void notifiSetting()
        {
            // делаем невидимой нашу иконку в трее
            notifyIcon1.Visible = false;
            // добавляем Эвент или событие по 2му клику мышки, 
            //вызывая функцию  notifyIcon1_MouseDoubleClick
            this.notifyIcon1.MouseClick += new MouseEventHandler(notifyIcon1_MouseDoubleClick_1);

            // добавляем событие на изменение окна
            this.Resize += new System.EventHandler(this.MiniForm_Resize);
        }
        
        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            // делаем нашу иконку скрытой
            notifyIcon1.Visible = false;
            // возвращаем отображение окна в панели
            this.ShowInTaskbar = true;
            //разворачиваем окно
            WindowState = FormWindowState.Normal;
        }

        private void MiniForm_Resize(object sender, EventArgs e)
        {
            // проверяем наше окно, и если оно было свернуто, делаем событие
            if (WindowState == FormWindowState.Minimized)
            {
                // прячем наше окно из панели
                this.ShowInTaskbar = false;
                // делаем нашу иконку в трее активной
                notifyIcon1.Visible = true;
            }

        }
    }
}
