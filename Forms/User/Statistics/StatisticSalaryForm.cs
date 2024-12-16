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
using System.Windows.Forms.DataVisualization.Charting;
using ProgectE.Model;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProgectE.Forms.Statistics
{
    public partial class StatisticSalaryForm : Form
    {
        private int refIdUser = 0;
        public StatisticSalaryForm(int idUser)
        {
            this.refIdUser = idUser;
            InitializeComponent();
           

           

        }
        private void Clear()
        {
            chart4.Series.Clear();
            chart2.Series.Clear();
            chart1.Series.Clear();
        }

        private void StatisticSalaryForm_Load(object sender, EventArgs e)
        {
            Clear();
            chart4.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
            chart2.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
            chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
            LoadTitle();
            try
            {
                if (GetListMonthsInYear(DateTime.Now.ToString("yyyy"),refIdUser).Count()==0) { MessageBox.Show("нет записей за текущий год"); return; }
                if (GetListMonthsInYear(DateTime.Now.ToString("yyyy"), refIdUser).Count() != 0)
                {
                    LoadChartSalary(DateTime.Now.ToString("yyyy"));
                    LoadChartTotalCartridges(DateTime.Now.ToString("yyyy"));
                    LoadChartTotalBarabans(DateTime.Now.ToString("yyyy"));
                    loadYearinComboBox(refIdUser);
                }
                

            }
            catch { }

        }


        //Получение списка счетов конкретного клиента
        private List<Model.Order> GetOrderList(int idUser)
        {
            List<Model.Order> findeOrder = new List<Model.Order>();
            using (var context = new AppDbContext())
            {
                findeOrder = context.Orders.Where(x => x.UserId == idUser).ToList();
            }
            return findeOrder;

        }
        //Получение числового значения месяца по его названию
        private int GetNumberMonth(string titleMonth)
        {
            int dd = DateTime.ParseExact(titleMonth, "MMMM", System.Globalization.CultureInfo.CurrentCulture).Month;
            return dd;
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
        //Получение конкретного пользователя
        private Model.User GetUser(int id)
        {
            Model.User findeUser;
            using (var context = new AppDbContext())
            {
                findeUser = context.Users.FirstOrDefault(x => x.UserId == refIdUser);
            }
            return findeUser;

        }

        //Получение суммы зп по месяцу
        private double GetSumProfit(string month, int IdUser)
        {
            var sum = GetOrderList(IdUser).Where(x => DateTime.Parse(x.Created).ToString("MMMM") == month).Select(x => Double.Parse(x.Profit)).Sum();
            var salarytmp = GetUser(refIdUser).Salary * (GetUser(refIdUser).Tax)/100;           
            var result = sum-salarytmp;
            return (double)result;
        }
        private int GetSumTotalCartridges(string month, int IdUser)
        {
            var sum = GetOrderList(IdUser).Where(x => DateTime.Parse(x.Created).ToString("MMMM") == month).Select(x => x.TotalCartridges).Sum();
            return sum;
        }
        private int GetSumTotalBarabanss(string month, int IdUser)
        {
            var sum = GetOrderList(IdUser).Where(x => DateTime.Parse(x.Created).ToString("MMMM") == month).Select(x => x.CountBaraban).Sum();
            return sum;
        }


        //загрузка всех годов в combobox
        private void loadYearinComboBox(int idUser)
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
        //Загрузка таблицы
        private void LoadChartSalary(string year_)
        {
            
           foreach (var month in GetListMonthsInYear(year_, refIdUser))
            {               
                Series series = chart4.Series.Add(month.Month_ + $"({Math.Round(GetSumProfit(month.Month_, refIdUser),2)} р.)");
                series.Points.Add(GetSumProfit(month.Month_, refIdUser));
            }
            SettingChart(chart4);           
        }
        
        private void LoadChartTotalCartridges(string year_)
        {
            foreach (var month in GetListMonthsInYear(year_, refIdUser))
            {
                Series series = chart2.Series.Add(month.Month_ + $"({GetSumTotalCartridges(month.Month_, refIdUser)} шт.)");
                series.Points.Add(GetSumTotalCartridges(month.Month_, refIdUser));
            }
            SettingChart(chart2);
        }
        private void LoadChartTotalBarabans(string year_)
        {
            foreach (var month in GetListMonthsInYear(year_, refIdUser))
            {
                Series series = chart1.Series.Add(month.Month_ + $"({GetSumTotalBarabanss(month.Month_, refIdUser)} шт.)");
                series.Points.Add(GetSumTotalBarabanss(month.Month_, refIdUser));
            }
            SettingChart(chart1);
        }


        private void LoadTitle()
        {
            Title title2 = new Title("Количесвто картриджей (Шт.)", Docking.Top, new System.Drawing.Font("Arial", 16, FontStyle.Bold), Color.Black);
            chart2.Titles.Add(title2);
            Title title4 = new Title("Заработная плата (Руб.)", Docking.Top, new System.Drawing.Font("Arial", 16, FontStyle.Bold), Color.Black);
            chart4.Titles.Add(title4);
            Title title1 = new Title("Количесвто фотобарабанов (Шт.)", Docking.Top, new System.Drawing.Font("Arial", 16, FontStyle.Bold), Color.Black);
            chart1.Titles.Add(title1);
            ChartArea chartArea4 = new ChartArea();
            chart4.ChartAreas.Add(chartArea4);
            ChartArea chartArea2 = new ChartArea();
            chart2.ChartAreas.Add(chartArea2);
            ChartArea chartArea1 = new ChartArea();
            chart1.ChartAreas.Add(chartArea1);

        }
        private void SettingChart(Chart chart)
        {
           
            chart.Dock = DockStyle.Fill;
            chart.Width = 682;
            chart.Height = 300;
            chart.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Arial", 12, FontStyle.Bold); // Изменение шрифта заголовка
            chart.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Near; // Выравнивание заголовка
        }


        private void button_show_Click(object sender, EventArgs e)
        {
            try
            {
               Clear();
                string year = comboBox_Year.SelectedItem.ToString();              
                LoadChartSalary(year);
                LoadChartTotalCartridges(year);
                LoadChartTotalBarabans(year);
            }
            catch { }
            
        }

       
    }
}
