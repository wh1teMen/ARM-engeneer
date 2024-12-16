using ProgectE.DataContext;
using ProgectE.Forms.Kontragent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgectE.Forms.Admin
{
    public partial class AdminMainForm : Form
    {
        private Form active;
        private Authorization refAuthorization = null;
        int refIdUser = 0;

        public AdminMainForm(Authorization otherAuthorization, int idUser)
        {
           
            refIdUser = idUser;
            InitializeComponent();
            this.refAuthorization = otherAuthorization;
        }
        //Получение  Авторизованного пользователя
        private Model.User? GetUser()
        {
            Model.User?user = new Model.User();
            using (var context = new AppDbContext())
            {
                user = context.Users.FirstOrDefault(x => x.UserId == refIdUser);
            }
            return user;
        }

        /*Статус пользователя------>*/
        //Изменение статуса пользователя онлайн/офлайн
        private void ChangeStatus(int idUser)
        {
            using (var context = new AppDbContext())
            {
                var User = GetUser();
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
                    context.Users.Update(User);
                    context.SaveChanges();
                }                
            }
        }
        //Проверка текущего статуса пользователя
        private bool validstatus(bool status)
        {
           
            if (status == true) return false;
            return true;
        }
        //<-------------------------


        //Настройки главной панели------>
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
            this.panel_all.Controls.Add(form);
            this.panel_all.Tag = form;
            form.BringToFront();
            form.Show();
        }
        private void пользователиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PanelForm(new UsersShowForm(refIdUser));
        }
        private void контрагентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelForm(new ShowKontrAgentForm());
        }
        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            PanelForm(new UsersShowForm(refIdUser));
            Text = $"Добро пожаловать!!\tАдминистратор: {GetUser().Name}";
        }
        //<------------------------------

        //Обработчики выхода ----->
        private void AdminMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChangeStatus(refIdUser);
            refAuthorization.Close();             
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            ChangeStatus(refIdUser);
            refAuthorization.Show();
            this.Hide();
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeStatus(refIdUser);
            refAuthorization.Show();
            this.Hide();
        }
        //<------------------------       
    }
}
