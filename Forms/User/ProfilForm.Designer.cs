namespace ProgectE
{
    partial class ProfilForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilForm));
            button_LoadImage = new Button();
            panel2 = new Panel();
            pictureBox_key = new PictureBox();
            button_reset = new Button();
            textBox_password = new TextBox();
            label_pass = new Label();
            panel_role = new Panel();
            checkBox1 = new CheckBox();
            label4 = new Label();
            label2 = new Label();
            textBox_role = new TextBox();
            label1 = new Label();
            maskedTextBox_Telephone = new MaskedTextBox();
            button_Save = new Button();
            textBox_Tax = new TextBox();
            textBox_Percent = new TextBox();
            textBox_Salary = new TextBox();
            textBox_Email = new TextBox();
            textBox_Patronymic = new TextBox();
            textBox_Surname = new TextBox();
            textBox_Name = new TextBox();
            label_Salary = new Label();
            label_Tax = new Label();
            label_Percent = new Label();
            label_Telephone = new Label();
            label_Email = new Label();
            label_Surname = new Label();
            label_Patronnymic = new Label();
            label_Name = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_key).BeginInit();
            panel_role.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_LoadImage
            // 
            button_LoadImage.BackColor = Color.Transparent;
            button_LoadImage.BackgroundImageLayout = ImageLayout.Stretch;
            button_LoadImage.FlatAppearance.BorderSize = 0;
            button_LoadImage.Location = new Point(28, 0);
            button_LoadImage.Name = "button_LoadImage";
            button_LoadImage.Size = new Size(391, 54);
            button_LoadImage.TabIndex = 2;
            button_LoadImage.Text = "Загрузить";
            button_LoadImage.UseVisualStyleBackColor = false;
            button_LoadImage.Click += button_LoadImage_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pictureBox_key);
            panel2.Controls.Add(button_reset);
            panel2.Controls.Add(textBox_password);
            panel2.Controls.Add(label_pass);
            panel2.Controls.Add(panel_role);
            panel2.Controls.Add(maskedTextBox_Telephone);
            panel2.Controls.Add(button_Save);
            panel2.Controls.Add(textBox_Tax);
            panel2.Controls.Add(textBox_Percent);
            panel2.Controls.Add(textBox_Salary);
            panel2.Controls.Add(textBox_Email);
            panel2.Controls.Add(textBox_Patronymic);
            panel2.Controls.Add(textBox_Surname);
            panel2.Controls.Add(textBox_Name);
            panel2.Controls.Add(label_Salary);
            panel2.Controls.Add(label_Tax);
            panel2.Controls.Add(label_Percent);
            panel2.Controls.Add(label_Telephone);
            panel2.Controls.Add(label_Email);
            panel2.Controls.Add(label_Surname);
            panel2.Controls.Add(label_Patronnymic);
            panel2.Controls.Add(label_Name);
            panel2.Location = new Point(508, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(525, 619);
            panel2.TabIndex = 10;
            // 
            // pictureBox_key
            // 
            pictureBox_key.BackgroundImage = (Image)resources.GetObject("pictureBox_key.BackgroundImage");
            pictureBox_key.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_key.Location = new Point(3, 331);
            pictureBox_key.Name = "pictureBox_key";
            pictureBox_key.Size = new Size(61, 35);
            pictureBox_key.TabIndex = 38;
            pictureBox_key.TabStop = false;
            // 
            // button_reset
            // 
            button_reset.BackColor = Color.Transparent;
            button_reset.Cursor = Cursors.Hand;
            button_reset.FlatAppearance.BorderSize = 0;
            button_reset.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold);
            button_reset.Location = new Point(61, 336);
            button_reset.Name = "button_reset";
            button_reset.Size = new Size(369, 36);
            button_reset.TabIndex = 37;
            button_reset.Text = "Сбросить пароль";
            button_reset.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_reset.UseVisualStyleBackColor = false;
            button_reset.Click += button_reset_Click;
            // 
            // textBox_password
            // 
            textBox_password.Font = new Font("Segoe Print", 12F);
            textBox_password.Location = new Point(203, 337);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(226, 36);
            textBox_password.TabIndex = 36;
            // 
            // label_pass
            // 
            label_pass.AutoSize = true;
            label_pass.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold);
            label_pass.Location = new Point(20, 336);
            label_pass.Name = "label_pass";
            label_pass.Size = new Size(85, 33);
            label_pass.TabIndex = 35;
            label_pass.Text = "Пароль";
            // 
            // panel_role
            // 
            panel_role.Controls.Add(checkBox1);
            panel_role.Controls.Add(label4);
            panel_role.Controls.Add(label2);
            panel_role.Controls.Add(textBox_role);
            panel_role.Controls.Add(label1);
            panel_role.Location = new Point(20, 381);
            panel_role.Name = "panel_role";
            panel_role.Size = new Size(410, 104);
            panel_role.TabIndex = 27;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(182, 68);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(69, 19);
            checkBox1.TabIndex = 32;
            checkBox1.Text = "Онлайн";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold);
            label4.Location = new Point(4, 59);
            label4.Name = "label4";
            label4.Size = new Size(98, 33);
            label4.TabIndex = 31;
            label4.Text = "Статус";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 42);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 29;
            label2.Text = "1 - user;  2 - admin";
            // 
            // textBox_role
            // 
            textBox_role.Font = new Font("Segoe Print", 12F);
            textBox_role.Location = new Point(181, 3);
            textBox_role.Name = "textBox_role";
            textBox_role.Size = new Size(226, 36);
            textBox_role.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold);
            label1.Location = new Point(5, 2);
            label1.Name = "label1";
            label1.Size = new Size(60, 33);
            label1.TabIndex = 28;
            label1.Text = "Роль";
            // 
            // maskedTextBox_Telephone
            // 
            maskedTextBox_Telephone.Font = new Font("Segoe Print", 12F);
            maskedTextBox_Telephone.ForeColor = SystemColors.WindowText;
            maskedTextBox_Telephone.Location = new Point(204, 168);
            maskedTextBox_Telephone.Mask = "+7(999) 000-0000";
            maskedTextBox_Telephone.Name = "maskedTextBox_Telephone";
            maskedTextBox_Telephone.Size = new Size(226, 36);
            maskedTextBox_Telephone.TabIndex = 26;
            // 
            // button_Save
            // 
            button_Save.Location = new Point(17, 491);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(410, 58);
            button_Save.TabIndex = 25;
            button_Save.Text = "Сохранить";
            button_Save.UseVisualStyleBackColor = true;
            button_Save.Click += button_Save_Click;
            // 
            // textBox_Tax
            // 
            textBox_Tax.Font = new Font("Segoe Print", 12F);
            textBox_Tax.Location = new Point(204, 294);
            textBox_Tax.Name = "textBox_Tax";
            textBox_Tax.Size = new Size(226, 36);
            textBox_Tax.TabIndex = 24;
            // 
            // textBox_Percent
            // 
            textBox_Percent.Font = new Font("Segoe Print", 12F);
            textBox_Percent.Location = new Point(204, 252);
            textBox_Percent.Name = "textBox_Percent";
            textBox_Percent.Size = new Size(226, 36);
            textBox_Percent.TabIndex = 23;
            // 
            // textBox_Salary
            // 
            textBox_Salary.Font = new Font("Segoe Print", 12F);
            textBox_Salary.Location = new Point(204, 210);
            textBox_Salary.Name = "textBox_Salary";
            textBox_Salary.Size = new Size(226, 36);
            textBox_Salary.TabIndex = 22;
            // 
            // textBox_Email
            // 
            textBox_Email.Font = new Font("Segoe Print", 12F);
            textBox_Email.Location = new Point(204, 126);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(226, 36);
            textBox_Email.TabIndex = 20;
            textBox_Email.Validating += textBox_Email_Validating;
            // 
            // textBox_Patronymic
            // 
            textBox_Patronymic.Font = new Font("Segoe Print", 12F);
            textBox_Patronymic.Location = new Point(204, 84);
            textBox_Patronymic.Name = "textBox_Patronymic";
            textBox_Patronymic.Size = new Size(226, 36);
            textBox_Patronymic.TabIndex = 19;
            // 
            // textBox_Surname
            // 
            textBox_Surname.Font = new Font("Segoe Print", 12F);
            textBox_Surname.Location = new Point(204, 42);
            textBox_Surname.Name = "textBox_Surname";
            textBox_Surname.Size = new Size(226, 36);
            textBox_Surname.TabIndex = 18;
            // 
            // textBox_Name
            // 
            textBox_Name.Font = new Font("Segoe Print", 12F);
            textBox_Name.Location = new Point(204, 0);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(226, 36);
            textBox_Name.TabIndex = 17;
            // 
            // label_Salary
            // 
            label_Salary.AutoSize = true;
            label_Salary.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold);
            label_Salary.Location = new Point(20, 211);
            label_Salary.Name = "label_Salary";
            label_Salary.Size = new Size(75, 33);
            label_Salary.TabIndex = 16;
            label_Salary.Text = "Оклад";
            // 
            // label_Tax
            // 
            label_Tax.AutoSize = true;
            label_Tax.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold);
            label_Tax.Location = new Point(17, 295);
            label_Tax.Name = "label_Tax";
            label_Tax.Size = new Size(213, 33);
            label_Tax.TabIndex = 15;
            label_Tax.Text = "Подоходный налог %";
            // 
            // label_Percent
            // 
            label_Percent.AutoSize = true;
            label_Percent.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold);
            label_Percent.Location = new Point(17, 252);
            label_Percent.Name = "label_Percent";
            label_Percent.Size = new Size(103, 33);
            label_Percent.TabIndex = 14;
            label_Percent.Text = "Сделка %";
            // 
            // label_Telephone
            // 
            label_Telephone.AutoSize = true;
            label_Telephone.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold);
            label_Telephone.Location = new Point(17, 169);
            label_Telephone.Name = "label_Telephone";
            label_Telephone.Size = new Size(98, 33);
            label_Telephone.TabIndex = 13;
            label_Telephone.Text = "Телефон";
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold);
            label_Email.Location = new Point(17, 127);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(68, 33);
            label_Email.TabIndex = 12;
            label_Email.Text = "Email";
            // 
            // label_Surname
            // 
            label_Surname.AutoSize = true;
            label_Surname.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold);
            label_Surname.Location = new Point(17, 43);
            label_Surname.Name = "label_Surname";
            label_Surname.Size = new Size(105, 33);
            label_Surname.TabIndex = 11;
            label_Surname.Text = "Фамилия";
            // 
            // label_Patronnymic
            // 
            label_Patronnymic.AutoSize = true;
            label_Patronnymic.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold);
            label_Patronnymic.Location = new Point(17, 85);
            label_Patronnymic.Name = "label_Patronnymic";
            label_Patronnymic.Size = new Size(121, 33);
            label_Patronnymic.TabIndex = 10;
            label_Patronnymic.Text = "Отчество";
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold);
            label_Name.Location = new Point(17, 1);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(60, 33);
            label_Name.TabIndex = 9;
            label_Name.Text = "Имя";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(437, 699);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(button_LoadImage);
            panel4.Location = new Point(15, 540);
            panel4.Name = "panel4";
            panel4.Size = new Size(422, 112);
            panel4.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(43, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 489);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(391, 489);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ProfilForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1072, 699);
            Controls.Add(panel3);
            Controls.Add(panel2);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProfilForm";
            Text = "Engineer_v_3.0 - Профиль ";
            Load += ProfilForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_key).EndInit();
            panel_role.ResumeLayout(false);
            panel_role.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label_Salary;
        private Label label_Tax;
        private Label label_Percent;
        private Label label_Telephone;
        private Label label_Email;
        private Label label_Surname;
        private Label label_Patronnymic;
        private Label label_Name;
        private TextBox textBox_Email;
        private TextBox textBox_Patronymic;
        private TextBox textBox_Surname;
        private TextBox textBox_Name;
        private TextBox textBox_Tax;
        private TextBox textBox_Percent;
        private TextBox textBox_Salary;
        private Button button_Save;
        private MaskedTextBox maskedTextBox_Telephone;
        private Button button_LoadImage;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Panel panel1;
        private Panel panel_role;
        private TextBox textBox_role;
        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private Label label4;
        private TextBox textBox_password;
        private Label label_pass;
        private Button button_reset;
        private PictureBox pictureBox_key;
    }
}