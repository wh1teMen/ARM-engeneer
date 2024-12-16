namespace ProgectE.Forms.Statistics
{
    partial class StatisticSalaryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticSalaryForm));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            comboBox_Year = new ComboBox();
            button_show = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel4 = new Panel();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // comboBox_Year
            // 
            comboBox_Year.FormattingEnabled = true;
            comboBox_Year.Location = new Point(12, 12);
            comboBox_Year.Name = "comboBox_Year";
            comboBox_Year.Size = new Size(140, 23);
            comboBox_Year.TabIndex = 6;
            // 
            // button_show
            // 
            button_show.Location = new Point(158, 11);
            button_show.Name = "button_show";
            button_show.Size = new Size(75, 23);
            button_show.TabIndex = 7;
            button_show.Text = "Показать";
            button_show.UseVisualStyleBackColor = true;
            button_show.Click += button_show_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button_show);
            panel1.Controls.Add(comboBox_Year);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(831, 46);
            panel1.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Controls.Add(chart4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 46);
            panel3.Name = "panel3";
            panel3.Size = new Size(831, 246);
            panel3.TabIndex = 12;
            // 
            // chart4
            // 
            chart4.BackgroundImageLayout = ImageLayout.Center;
            chartArea1.Name = "ChartArea1";
            chart4.ChartAreas.Add(chartArea1);
            chart4.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chart4.Legends.Add(legend1);
            chart4.Location = new Point(0, 0);
            chart4.Name = "chart4";
            chart4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart4.Series.Add(series1);
            chart4.Size = new Size(831, 246);
            chart4.TabIndex = 0;
            chart4.Text = "chart2";
            // 
            // panel4
            // 
            panel4.Controls.Add(chart2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 292);
            panel4.Name = "panel4";
            panel4.Size = new Size(831, 292);
            panel4.TabIndex = 13;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea2);
            chart2.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chart2.Legends.Add(legend2);
            chart2.Location = new Point(0, 0);
            chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart2.Series.Add(series2);
            chart2.Size = new Size(831, 292);
            chart2.TabIndex = 0;
            chart2.Text = "chart3";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea3);
            chart1.Dock = DockStyle.Fill;
            legend3.Name = "Legend1";
            chart1.Legends.Add(legend3);
            chart1.Location = new Point(0, 584);
            chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chart1.Series.Add(series3);
            chart1.Size = new Size(831, 259);
            chart1.TabIndex = 14;
            chart1.Text = "chart3";
            // 
            // StatisticSalaryForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.White;
            ClientSize = new Size(831, 843);
            Controls.Add(chart1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StatisticSalaryForm";
            Text = "Engineer_v_3.0 - Статистика";
            Load += StatisticSalaryForm_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart4).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox comboBox_Year;
        private Button button_show;
        private Panel panel1;
        private Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}