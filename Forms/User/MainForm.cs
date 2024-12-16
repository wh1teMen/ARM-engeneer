using Microsoft.VisualBasic.ApplicationServices;
using ProgectE.DataContext;
using ProgectE.Forms.Kontragent;
using ProgectE.Forms.Order;
using ProgectE.Forms.Statistics;
using ProgectE.Forms.User;
using ProgectE.Model;
using ProgectE.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using User = ProgectE.Model.User;

namespace ProgectE
{
    public partial class MainForm : Form
    {
        bool sidebarExpand;
        private Form active;       
        Authorization refAuthorization = null;
        int refIdUser = 0;
        public MainForm(Authorization otherAuthorization, int idUser)
        {
            refIdUser = idUser;
            InitializeComponent();
            this.refAuthorization = otherAuthorization;         


        }

      
        private void MainForm_Load(object sender, EventArgs e)
        {            
            LoadingProfit();
            LoadingUsers();
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(5, 5, 210, 220);
            Region rgn = new Region(path);
            pictureBox1.Region = rgn;
            pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
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

        private async void LoadingUsers()
        {
            while (true)
            {
                using (var context = new AppDbContext())
                {
                    var User = context.Users.FirstOrDefault(x => x.UserId == refIdUser);
                    if (User != null)
                    {
                        if (User.ImageData != null)
                        {
                            using (var ms = new MemoryStream(User?.ImageData))
                            {
                                pictureBox1.Image = System.Drawing.Image.FromStream(ms);
                                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                pictureBox1.Dock = DockStyle.None;
                            }
                        }

                        label_Name.Text = User?.Name;
                        label_Surname.Text = User?.Surname;
                    }
                }
                await Task.Delay(2000);
            }
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
                    if (orderUser != null)
                    {
                        var orderUserMonth = orderUser.Where(x => GetMonthfromDate(x.Created) == DateTime.Now.ToString("MM")
                        && GetYearfromDate(x.Created) == DateTime.Now.ToString("yyyy")).ToList();
                        orderUserMonth.ForEach(x => Sum += Convert.ToDecimal(x.Profit));

                        label_Money.Text = Math.Round(Sum, 2).ToString();
                    }
                    else label_Money.Text = "null";
                }
                await Task.Delay(100);
            }


        }
        private User getUser(int id)
        {
            User user = new User();
            using (var context = new AppDbContext())
            {
                user = context.Users.FirstOrDefault(x => x.UserId == id);

            }
            return user;
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChangeStatus(refIdUser);
            refAuthorization.Close();

        }
        private void PanelForm(Form form)
        {
            if (active != null)
            {
                active.Close();
            }
            active = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.panel_conent.Controls.Add(form);
            this.panel_conent.Tag = form;
            form.BringToFront();
            form.Show();
        }



        private void button_AddOrder_Click(object sender, EventArgs e)
        {
            PanelForm(new AddOrderForm(refIdUser));
        }
        //*********************
        private void button2_Click(object sender, EventArgs e)
        {
            refAuthorization.Show();
            this.Hide();

        }

       

        private void button_OrderSub_Click(object sender, EventArgs e)
        {
            PanelForm(new ShowOrdersForm(refIdUser));
            //showSubmenu(panel_order);
        }

        private void button_KontrAgent_Click(object sender, EventArgs e)
        {
            PanelForm(new ShowKontrAgentForm());
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PanelForm(new ProfilForm(refIdUser));
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выход");
        }



        private void RingButton(Button button)
        {
            GraphicsPath gp = new GraphicsPath();
            Graphics g = CreateGraphics();
            // Создадим новый прямоугольник с размерами кнопки 
            Rectangle smallRectangle = button.ClientRectangle;
            // уменьшим размеры прямоугольника 
            smallRectangle.Inflate(-1, -1);
            // создадим эллипс, используя полученные размеры 
            gp.AddEllipse(smallRectangle);
            button.Region = new Region(gp);
            // рисуем окантовоку для круглой кнопки 
            g.DrawEllipse(new Pen(Color.Gray, 2),
            button.Left + 1,
            button.Top + 1,
            button.Width - 1,
            button.Height - 1);
            // освобождаем ресурсы 
            g.Dispose();

        }

        private void button_Statistic_Click(object sender, EventArgs e)
        {
            PanelForm(new StatisticSalaryForm(refIdUser));
        }      


       


        

        private void button_mini_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MiniForm miniForm = new MiniForm(this, refIdUser);
            miniForm.Show();
        }

        private void panel_exit_Click(object sender, EventArgs e)
        {
            ChangeStatus(refIdUser);
            refAuthorization.Show();
            this.Hide();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ChangeStatus(refIdUser);
            refAuthorization.Show();
            this.Hide();
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
            this.Resize += new System.EventHandler(this.MainForm_Resize_1);
        }
        private void MainForm_Resize_1(object sender, EventArgs e)
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
        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            // делаем нашу иконку скрытой
            notifyIcon1.Visible = false;
            // возвращаем отображение окна в панели
            this.ShowInTaskbar = true;
            //разворачиваем окно
            WindowState = FormWindowState.Normal;
        }
    }
}
