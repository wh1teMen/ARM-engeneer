namespace PogectE
{
    partial class Registration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            textBox_Login = new TextBox();
            textBox_Name = new TextBox();
            button_Registration = new Button();
            textBox_Password = new TextBox();
            textBox_Confirm = new TextBox();
            linkLabel1 = new LinkLabel();
            textBox_Surname = new TextBox();
            label1 = new Label();
            checkBoxReg = new CheckBox();
            SuspendLayout();
            // 
            // textBox_Login
            // 
            textBox_Login.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic);
            textBox_Login.Location = new Point(77, 103);
            textBox_Login.Multiline = true;
            textBox_Login.Name = "textBox_Login";
            textBox_Login.Size = new Size(200, 30);
            textBox_Login.TabIndex = 0;
            textBox_Login.Validating += textBox_Login_Validating;
            // 
            // textBox_Name
            // 
            textBox_Name.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic);
            textBox_Name.Location = new Point(77, 139);
            textBox_Name.Multiline = true;
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(200, 30);
            textBox_Name.TabIndex = 1;
            textBox_Name.Validating += textBox_Name_Validating;
            // 
            // button_Registration
            // 
            button_Registration.BackColor = Color.Transparent;
            button_Registration.Cursor = Cursors.Hand;
            button_Registration.FlatAppearance.BorderSize = 0;
            button_Registration.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_Registration.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_Registration.FlatStyle = FlatStyle.Flat;
            button_Registration.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button_Registration.ForeColor = Color.White;
            button_Registration.Location = new Point(76, 283);
            button_Registration.Name = "button_Registration";
            button_Registration.Size = new Size(217, 38);
            button_Registration.TabIndex = 5;
            button_Registration.Text = "Зарегистрироваться";
            button_Registration.UseVisualStyleBackColor = false;
            button_Registration.MouseClick += button_Registration_MouseClick;
            // 
            // textBox_Password
            // 
            textBox_Password.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic);
            textBox_Password.Location = new Point(76, 211);
            textBox_Password.Multiline = true;
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(200, 30);
            textBox_Password.TabIndex = 3;
            textBox_Password.Enter += textBox_Password_Enter;
            textBox_Password.Leave += textBox_Password_Leave;
            textBox_Password.Validating += textBox_Password_Validating;
            // 
            // textBox_Confirm
            // 
            textBox_Confirm.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic);
            textBox_Confirm.Location = new Point(76, 247);
            textBox_Confirm.Multiline = true;
            textBox_Confirm.Name = "textBox_Confirm";
            textBox_Confirm.Size = new Size(200, 30);
            textBox_Confirm.TabIndex = 4;
            textBox_Confirm.Enter += textBox_Confirm_Enter;
            textBox_Confirm.Leave += textBox_Confirm_Leave;
            textBox_Confirm.Validating += textBox_Confirm_Validating;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Transparent;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(179, 324);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(79, 21);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "<-Назад";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // textBox_Surname
            // 
            textBox_Surname.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic);
            textBox_Surname.Location = new Point(77, 175);
            textBox_Surname.Multiline = true;
            textBox_Surname.Name = "textBox_Surname";
            textBox_Surname.Size = new Size(200, 30);
            textBox_Surname.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(90, 55);
            label1.Name = "label1";
            label1.Size = new Size(168, 32);
            label1.TabIndex = 7;
            label1.Text = "Регистрация";
            // 
            // checkBoxReg
            // 
            checkBoxReg.Appearance = Appearance.Button;
            checkBoxReg.AutoSize = true;
            checkBoxReg.BackColor = Color.Transparent;
            checkBoxReg.BackgroundImageLayout = ImageLayout.None;
            checkBoxReg.Cursor = Cursors.Hand;
            checkBoxReg.FlatAppearance.BorderColor = Color.DarkGray;
            checkBoxReg.FlatAppearance.BorderSize = 0;
            checkBoxReg.FlatStyle = FlatStyle.Flat;
            checkBoxReg.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBoxReg.Location = new Point(252, 72);
            checkBoxReg.Name = "checkBoxReg";
            checkBoxReg.Size = new Size(6, 6);
            checkBoxReg.TabIndex = 8;
            checkBoxReg.UseVisualStyleBackColor = false;
            checkBoxReg.Click += checkBoxReg_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(345, 413);
            Controls.Add(checkBoxReg);
            Controls.Add(label1);
            Controls.Add(textBox_Surname);
            Controls.Add(linkLabel1);
            Controls.Add(textBox_Confirm);
            Controls.Add(textBox_Password);
            Controls.Add(button_Registration);
            Controls.Add(textBox_Name);
            Controls.Add(textBox_Login);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            FormClosing += Registration_FormClosing;
            Load += Registration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Login;
        private TextBox textBox_Name;
        private Button button_Registration;
        private TextBox textBox_Password;
        private TextBox textBox_Confirm;
        private LinkLabel linkLabel1;
        private TextBox textBox_Surname;
        private Label label1;
        private CheckBox checkBoxReg;
    }
}
