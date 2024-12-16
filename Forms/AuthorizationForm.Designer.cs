namespace ProgectE
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            textBox_Login = new TextBox();
            textBox_Password = new TextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            pictureBoxLoginGood = new PictureBox();
            pictureBoxPasswordGood = new PictureBox();
            pictureBoxLoginBad = new PictureBox();
            pictureBoxPasswordBad = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoginGood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPasswordGood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoginBad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPasswordBad).BeginInit();
            SuspendLayout();
            // 
            // textBox_Login
            // 
            textBox_Login.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            textBox_Login.Location = new Point(110, 84);
            textBox_Login.Name = "textBox_Login";
            textBox_Login.Size = new Size(180, 33);
            textBox_Login.TabIndex = 0;
            // 
            // textBox_Password
            // 
            textBox_Password.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            textBox_Password.Location = new Point(109, 123);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.PasswordChar = '*';
            textBox_Password.Size = new Size(181, 33);
            textBox_Password.TabIndex = 1;
            textBox_Password.KeyDown += textBox_Password_KeyDown;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(109, 156);
            button1.Name = "button1";
            button1.Size = new Size(83, 41);
            button1.TabIndex = 2;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = false;
            button1.MouseClick += button1_MouseClick;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold | FontStyle.Italic);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(182, 170);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(108, 19);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Регистрация";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBoxLoginGood
            // 
            pictureBoxLoginGood.BackColor = Color.Transparent;
            pictureBoxLoginGood.Image = (Image)resources.GetObject("pictureBoxLoginGood.Image");
            pictureBoxLoginGood.Location = new Point(77, 84);
            pictureBoxLoginGood.Name = "pictureBoxLoginGood";
            pictureBoxLoginGood.Size = new Size(27, 27);
            pictureBoxLoginGood.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLoginGood.TabIndex = 7;
            pictureBoxLoginGood.TabStop = false;
            // 
            // pictureBoxPasswordGood
            // 
            pictureBoxPasswordGood.BackColor = Color.Transparent;
            pictureBoxPasswordGood.BackgroundImageLayout = ImageLayout.None;
            pictureBoxPasswordGood.Image = (Image)resources.GetObject("pictureBoxPasswordGood.Image");
            pictureBoxPasswordGood.Location = new Point(77, 123);
            pictureBoxPasswordGood.Name = "pictureBoxPasswordGood";
            pictureBoxPasswordGood.Size = new Size(27, 27);
            pictureBoxPasswordGood.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPasswordGood.TabIndex = 8;
            pictureBoxPasswordGood.TabStop = false;
            // 
            // pictureBoxLoginBad
            // 
            pictureBoxLoginBad.BackColor = Color.Transparent;
            pictureBoxLoginBad.BackgroundImageLayout = ImageLayout.None;
            pictureBoxLoginBad.Image = (Image)resources.GetObject("pictureBoxLoginBad.Image");
            pictureBoxLoginBad.Location = new Point(77, 84);
            pictureBoxLoginBad.Name = "pictureBoxLoginBad";
            pictureBoxLoginBad.Size = new Size(27, 27);
            pictureBoxLoginBad.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLoginBad.TabIndex = 9;
            pictureBoxLoginBad.TabStop = false;
            // 
            // pictureBoxPasswordBad
            // 
            pictureBoxPasswordBad.BackColor = Color.Transparent;
            pictureBoxPasswordBad.BackgroundImageLayout = ImageLayout.None;
            pictureBoxPasswordBad.Image = (Image)resources.GetObject("pictureBoxPasswordBad.Image");
            pictureBoxPasswordBad.Location = new Point(77, 123);
            pictureBoxPasswordBad.Name = "pictureBoxPasswordBad";
            pictureBoxPasswordBad.Size = new Size(27, 27);
            pictureBoxPasswordBad.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPasswordBad.TabIndex = 10;
            pictureBoxPasswordBad.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(91, 27);
            label1.Name = "label1";
            label1.Size = new Size(211, 37);
            label1.TabIndex = 11;
            label1.Text = "Авторизация";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Light", 8F, FontStyle.Italic);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(1, 228);
            label2.Name = "label2";
            label2.Size = new Size(0, 13);
            label2.TabIndex = 12;
            // 
            // Authorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.Gray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(376, 250);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBoxPasswordBad);
            Controls.Add(pictureBoxLoginBad);
            Controls.Add(pictureBoxPasswordGood);
            Controls.Add(pictureBoxLoginGood);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Login);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Authorization";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            Load += Authorization_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoginGood).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPasswordGood).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoginBad).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPasswordBad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Login;
        private TextBox textBox_Password;
        private Button button1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBoxLoginGood;
        private PictureBox pictureBoxPasswordGood;
        private PictureBox pictureBoxLoginBad;
        private PictureBox pictureBoxPasswordBad;
        private Label label1;
        private Label label2;
    }
}