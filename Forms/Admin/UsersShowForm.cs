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

namespace ProgectE.Forms.Admin
{
    public partial class UsersShowForm : Form
    {
        private int refIdUser = 0;
        public UsersShowForm(int idUser)
        {
            this.refIdUser = idUser;
            InitializeComponent();
        }
        private void UsersShowForm_Load(object sender, EventArgs e)
        {
            SettingDatagrid();
            LoadAllData();
            textBox_findeLogin.PlaceholderText = "введите логин";
        }                                                               
        /*Настройки DataGridView*///------>
        //Загрузка данных в DataGridView
        private async void LoadAllData()
        {
            using (var context = new AppDbContext())
            {
                dataGridView1.DataSource = context.Users.ToList();
            }         
        }
        //Стартовые настройки DataGridView
        private void SettingDatagrid()
        {           
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.RowHeadersVisible = false;
        }
        //<--------------------------------

        /*Операции с пользователем*///--------------->
        //Удаление выбранного пользователя
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var findeElementforDeleted = context.Users.FirstOrDefault(x => x.UserId == int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));

                if (findeElementforDeleted != null)
                {
                    context.Users.Remove(findeElementforDeleted);
                    context.SaveChanges();
                }
                else { return; }
            }
            LoadAllData();
        }
        //Изменить данные пользователя
        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            ProfilForm profilForm = new ProfilForm(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()), refIdUser);
            profilForm.ShowDialog();
        }
        //Обновить список пользователей
        private void button_refresh_Click(object sender, EventArgs e)
        {
            LoadAllData();
        }
        //Найти пользователя по имени
        private void buttonFinde_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var findeElement = context.Users.FirstOrDefault(x => x.Login == textBox_findeLogin.Text);
                List<Model.User> usersa = new List<Model.User>();
                if (usersa != null)
                {
                    usersa.Add(findeElement);
                }
                dataGridView1.DataSource = usersa;
            }

           
        }
        //Показать пользователей которые Онлайн
        private void button_online_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var findeElement = context.Users.Where(x => x.Status == true).ToList();
             
                if (findeElement != null)
                {
                    dataGridView1.DataSource = findeElement;
                }               
            }         
        }
        //<------------------------------------------
    }
}
