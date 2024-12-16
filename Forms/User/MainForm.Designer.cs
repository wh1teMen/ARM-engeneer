namespace ProgectE
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            panel_all = new Panel();
            panel_conent = new Panel();
            panelHederRight = new Panel();
            panel3 = new Panel();
            button_mini = new Button();
            panel2 = new Panel();
            pictureBox_Money = new PictureBox();
            label_Money = new Label();
            panel_content = new Panel();
            panel_menu = new Panel();
            panel_exit = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            button_Statistic = new Button();
            button_KontrAgent = new Button();
            button_OrderSub = new Button();
            panel_logo = new Panel();
            panel4 = new Panel();
            label_Surname = new Label();
            label_Name = new Label();
            pictureBox1 = new PictureBox();
            notifyIcon1 = new NotifyIcon(components);
            panel_all.SuspendLayout();
            panelHederRight.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Money).BeginInit();
            panel_menu.SuspendLayout();
            panel_exit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel_logo.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(656, 433);
            panel1.Name = "panel1";
            panel1.Size = new Size(534, 307);
            panel1.TabIndex = 0;
            // 
            // panel_all
            // 
            panel_all.Controls.Add(panel_conent);
            panel_all.Controls.Add(panelHederRight);
            panel_all.Controls.Add(panel1);
            panel_all.Controls.Add(panel_menu);
            panel_all.Dock = DockStyle.Fill;
            panel_all.Location = new Point(0, 0);
            panel_all.Name = "panel_all";
            panel_all.Size = new Size(1190, 891);
            panel_all.TabIndex = 8;
            // 
            // panel_conent
            // 
            panel_conent.BackColor = Color.Silver;
            panel_conent.BackgroundImage = (Image)resources.GetObject("panel_conent.BackgroundImage");
            panel_conent.BackgroundImageLayout = ImageLayout.Stretch;
            panel_conent.Dock = DockStyle.Fill;
            panel_conent.Location = new Point(226, 50);
            panel_conent.Name = "panel_conent";
            panel_conent.Size = new Size(964, 841);
            panel_conent.TabIndex = 2;
            // 
            // panelHederRight
            // 
            panelHederRight.BackColor = Color.FromArgb(64, 64, 64);
            panelHederRight.BackgroundImageLayout = ImageLayout.Stretch;
            panelHederRight.Controls.Add(panel3);
            panelHederRight.Controls.Add(panel2);
            panelHederRight.Controls.Add(panel_content);
            panelHederRight.Dock = DockStyle.Top;
            panelHederRight.Location = new Point(226, 0);
            panelHederRight.Name = "panelHederRight";
            panelHederRight.Size = new Size(964, 50);
            panelHederRight.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(button_mini);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(852, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(112, 50);
            panel3.TabIndex = 8;
            // 
            // button_mini
            // 
            button_mini.BackColor = Color.Transparent;
            button_mini.BackgroundImage = (Image)resources.GetObject("button_mini.BackgroundImage");
            button_mini.BackgroundImageLayout = ImageLayout.Stretch;
            button_mini.Cursor = Cursors.Hand;
            button_mini.FlatAppearance.BorderSize = 0;
            button_mini.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_mini.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_mini.FlatStyle = FlatStyle.Flat;
            button_mini.Location = new Point(61, 7);
            button_mini.Name = "button_mini";
            button_mini.Size = new Size(48, 37);
            button_mini.TabIndex = 10;
            button_mini.UseVisualStyleBackColor = false;
            button_mini.Click += button_mini_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox_Money);
            panel2.Controls.Add(label_Money);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(180, 50);
            panel2.TabIndex = 7;
            // 
            // pictureBox_Money
            // 
            pictureBox_Money.BackgroundImage = (Image)resources.GetObject("pictureBox_Money.BackgroundImage");
            pictureBox_Money.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_Money.Location = new Point(12, 9);
            pictureBox_Money.Margin = new Padding(0);
            pictureBox_Money.Name = "pictureBox_Money";
            pictureBox_Money.Size = new Size(35, 35);
            pictureBox_Money.TabIndex = 6;
            pictureBox_Money.TabStop = false;
            // 
            // label_Money
            // 
            label_Money.AutoSize = true;
            label_Money.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_Money.ForeColor = Color.White;
            label_Money.Location = new Point(50, 14);
            label_Money.Name = "label_Money";
            label_Money.Size = new Size(26, 30);
            label_Money.TabIndex = 5;
            label_Money.Text = "0";
            // 
            // panel_content
            // 
            panel_content.BackColor = Color.FromArgb(255, 255, 192);
            panel_content.Location = new Point(0, 54);
            panel_content.Name = "panel_content";
            panel_content.Size = new Size(620, 469);
            panel_content.TabIndex = 2;
            // 
            // panel_menu
            // 
            panel_menu.BackColor = Color.FromArgb(64, 64, 64);
            panel_menu.BackgroundImageLayout = ImageLayout.Stretch;
            panel_menu.Controls.Add(panel_exit);
            panel_menu.Controls.Add(pictureBox4);
            panel_menu.Controls.Add(pictureBox3);
            panel_menu.Controls.Add(pictureBox2);
            panel_menu.Controls.Add(button_Statistic);
            panel_menu.Controls.Add(button_KontrAgent);
            panel_menu.Controls.Add(button_OrderSub);
            panel_menu.Controls.Add(panel_logo);
            panel_menu.Dock = DockStyle.Left;
            panel_menu.ForeColor = SystemColors.ButtonHighlight;
            panel_menu.Location = new Point(0, 0);
            panel_menu.Name = "panel_menu";
            panel_menu.Size = new Size(226, 891);
            panel_menu.TabIndex = 0;
            // 
            // panel_exit
            // 
            panel_exit.Controls.Add(pictureBox5);
            panel_exit.Dock = DockStyle.Bottom;
            panel_exit.Location = new Point(0, 825);
            panel_exit.Name = "panel_exit";
            panel_exit.Size = new Size(226, 66);
            panel_exit.TabIndex = 14;
            panel_exit.Click += panel_exit_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Dock = DockStyle.Fill;
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(226, 66);
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(3, 339);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(37, 47);
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(3, 386);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 38);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(3, 424);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 37);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // button_Statistic
            // 
            button_Statistic.BackgroundImageLayout = ImageLayout.Stretch;
            button_Statistic.Cursor = Cursors.Hand;
            button_Statistic.Dock = DockStyle.Top;
            button_Statistic.FlatAppearance.BorderSize = 0;
            button_Statistic.FlatStyle = FlatStyle.Flat;
            button_Statistic.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            button_Statistic.Location = new Point(0, 424);
            button_Statistic.Name = "button_Statistic";
            button_Statistic.Size = new Size(226, 38);
            button_Statistic.TabIndex = 9;
            button_Statistic.Text = "Cтатистика";
            button_Statistic.UseVisualStyleBackColor = true;
            button_Statistic.Click += button_Statistic_Click;
            // 
            // button_KontrAgent
            // 
            button_KontrAgent.BackgroundImageLayout = ImageLayout.Stretch;
            button_KontrAgent.Cursor = Cursors.Hand;
            button_KontrAgent.Dock = DockStyle.Top;
            button_KontrAgent.FlatAppearance.BorderSize = 0;
            button_KontrAgent.FlatStyle = FlatStyle.Flat;
            button_KontrAgent.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button_KontrAgent.Location = new Point(0, 386);
            button_KontrAgent.Name = "button_KontrAgent";
            button_KontrAgent.Size = new Size(226, 38);
            button_KontrAgent.TabIndex = 7;
            button_KontrAgent.Text = "Контрагенты";
            button_KontrAgent.UseVisualStyleBackColor = true;
            button_KontrAgent.Click += button_KontrAgent_Click;
            // 
            // button_OrderSub
            // 
            button_OrderSub.BackgroundImageLayout = ImageLayout.Stretch;
            button_OrderSub.Cursor = Cursors.Hand;
            button_OrderSub.Dock = DockStyle.Top;
            button_OrderSub.FlatAppearance.BorderSize = 0;
            button_OrderSub.FlatStyle = FlatStyle.Flat;
            button_OrderSub.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_OrderSub.Location = new Point(0, 339);
            button_OrderSub.Name = "button_OrderSub";
            button_OrderSub.Size = new Size(226, 47);
            button_OrderSub.TabIndex = 6;
            button_OrderSub.Text = "Счета клиенту";
            button_OrderSub.UseVisualStyleBackColor = true;
            button_OrderSub.Click += button_OrderSub_Click;
            // 
            // panel_logo
            // 
            panel_logo.BackColor = Color.FromArgb(64, 64, 64);
            panel_logo.BackgroundImageLayout = ImageLayout.Stretch;
            panel_logo.Controls.Add(panel4);
            panel_logo.Controls.Add(pictureBox1);
            panel_logo.Dock = DockStyle.Top;
            panel_logo.Location = new Point(0, 0);
            panel_logo.Name = "panel_logo";
            panel_logo.Size = new Size(226, 339);
            panel_logo.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(label_Surname);
            panel4.Controls.Add(label_Name);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 223);
            panel4.Name = "panel4";
            panel4.Size = new Size(226, 116);
            panel4.TabIndex = 1;
            // 
            // label_Surname
            // 
            label_Surname.AutoSize = true;
            label_Surname.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            label_Surname.Location = new Point(12, 69);
            label_Surname.Name = "label_Surname";
            label_Surname.Size = new Size(81, 26);
            label_Surname.TabIndex = 1;
            label_Surname.Text = "Surname";
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            label_Name.Location = new Point(12, 28);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(56, 26);
            label_Name.TabIndex = 0;
            label_Name.Text = "Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 218);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Engineer_v_3.0";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(1190, 891);
            Controls.Add(panel_all);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1200, 930);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Engineer_v_3.0 - Рабочее место";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            Resize += MainForm_Resize_1;
            panel_all.ResumeLayout(false);
            panelHederRight.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Money).EndInit();
            panel_menu.ResumeLayout(false);
            panel_exit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel_logo.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel_all;
        private Panel panel_content;
        private Panel panelHederRight;
        private Panel panel_menu;
        private Panel panel_logo;
        private Panel panel_conent;
        private Button button_OrderSub;
        private Button button_KontrAgent;
        private Label label_Money;
        private PictureBox pictureBox_Money;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Label label_Surname;
        private Label label_Name;
        private Button button_Statistic;
        private Button button_mini;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private Panel panel_exit;
        private NotifyIcon notifyIcon1;
    }
}