namespace ProgectE
{
    partial class AddKontrAgentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddKontrAgentForm));
            textBox_Title = new TextBox();
            label_Title = new Label();
            label_Telephone = new Label();
            textBox_Email = new TextBox();
            label_Email = new Label();
            textBox_Adress = new TextBox();
            label1 = new Label();
            label_ContactUser = new Label();
            textBox_ContactUser = new TextBox();
            textBox_Description = new TextBox();
            label_Description = new Label();
            button_Add = new Button();
            maskedTextBox_Telephone = new MaskedTextBox();
            SuspendLayout();
            // 
            // textBox_Title
            // 
            textBox_Title.Location = new Point(205, 20);
            textBox_Title.Margin = new Padding(5, 4, 5, 4);
            textBox_Title.Name = "textBox_Title";
            textBox_Title.Size = new Size(356, 29);
            textBox_Title.TabIndex = 0;
            // 
            // label_Title
            // 
            label_Title.AutoSize = true;
            label_Title.Font = new Font("Arial", 14.25F);
            label_Title.Location = new Point(24, 20);
            label_Title.Margin = new Padding(5, 0, 5, 0);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(98, 22);
            label_Title.TabIndex = 1;
            label_Title.Text = "Название:";
            // 
            // label_Telephone
            // 
            label_Telephone.AutoSize = true;
            label_Telephone.Font = new Font("Arial", 14.25F);
            label_Telephone.Location = new Point(24, 75);
            label_Telephone.Margin = new Padding(5, 0, 5, 0);
            label_Telephone.Name = "label_Telephone";
            label_Telephone.Size = new Size(94, 22);
            label_Telephone.TabIndex = 2;
            label_Telephone.Text = "Телефон:";
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(205, 174);
            textBox_Email.Margin = new Padding(5, 4, 5, 4);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(356, 29);
            textBox_Email.TabIndex = 3;
            textBox_Email.Validating += textBox_Email_Validating;
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.Font = new Font("Arial", 14.25F);
            label_Email.Location = new Point(24, 181);
            label_Email.Margin = new Padding(5, 0, 5, 0);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(180, 22);
            label_Email.TabIndex = 4;
            label_Email.Text = "Электронная почта:";
            // 
            // textBox_Adress
            // 
            textBox_Adress.Location = new Point(205, 125);
            textBox_Adress.Margin = new Padding(5, 4, 5, 4);
            textBox_Adress.Name = "textBox_Adress";
            textBox_Adress.Size = new Size(356, 29);
            textBox_Adress.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F);
            label1.Location = new Point(24, 128);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 22);
            label1.TabIndex = 6;
            label1.Text = "Адрес:";
            // 
            // label_ContactUser
            // 
            label_ContactUser.AutoSize = true;
            label_ContactUser.Font = new Font("Arial", 14.25F);
            label_ContactUser.Location = new Point(24, 229);
            label_ContactUser.Margin = new Padding(5, 0, 5, 0);
            label_ContactUser.Name = "label_ContactUser";
            label_ContactUser.Size = new Size(160, 22);
            label_ContactUser.TabIndex = 8;
            label_ContactUser.Text = "Контактное лицо:";
            // 
            // textBox_ContactUser
            // 
            textBox_ContactUser.Location = new Point(205, 226);
            textBox_ContactUser.Margin = new Padding(5, 4, 5, 4);
            textBox_ContactUser.Name = "textBox_ContactUser";
            textBox_ContactUser.Size = new Size(356, 29);
            textBox_ContactUser.TabIndex = 4;
            // 
            // textBox_Description
            // 
            textBox_Description.Location = new Point(205, 278);
            textBox_Description.Margin = new Padding(5, 4, 5, 4);
            textBox_Description.Multiline = true;
            textBox_Description.Name = "textBox_Description";
            textBox_Description.Size = new Size(356, 127);
            textBox_Description.TabIndex = 5;
            // 
            // label_Description
            // 
            label_Description.AutoSize = true;
            label_Description.Font = new Font("Arial", 14.25F);
            label_Description.Location = new Point(24, 281);
            label_Description.Margin = new Padding(5, 0, 5, 0);
            label_Description.Name = "label_Description";
            label_Description.Size = new Size(100, 22);
            label_Description.TabIndex = 11;
            label_Description.Text = "Описание:";
            // 
            // button_Add
            // 
            button_Add.BackColor = Color.FromArgb(177, 245, 128);
            button_Add.Location = new Point(24, 423);
            button_Add.Margin = new Padding(5, 4, 5, 4);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(537, 50);
            button_Add.TabIndex = 6;
            button_Add.Text = "Добавить";
            button_Add.UseVisualStyleBackColor = false;
            button_Add.Click += button_Add_Click;
            // 
            // maskedTextBox_Telephone
            // 
            maskedTextBox_Telephone.Location = new Point(205, 68);
            maskedTextBox_Telephone.Margin = new Padding(5, 4, 5, 4);
            maskedTextBox_Telephone.Mask = "+7(999) 000-0000";
            maskedTextBox_Telephone.Name = "maskedTextBox_Telephone";
            maskedTextBox_Telephone.Size = new Size(356, 29);
            maskedTextBox_Telephone.TabIndex = 1;
            // 
            // AddKontrAgentForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 489);
            Controls.Add(maskedTextBox_Telephone);
            Controls.Add(button_Add);
            Controls.Add(label_Description);
            Controls.Add(textBox_Description);
            Controls.Add(textBox_ContactUser);
            Controls.Add(label_ContactUser);
            Controls.Add(textBox_Adress);
            Controls.Add(label1);
            Controls.Add(textBox_Email);
            Controls.Add(label_Email);
            Controls.Add(label_Telephone);
            Controls.Add(label_Title);
            Controls.Add(textBox_Title);
            Font = new Font("Arial", 14.25F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddKontrAgentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Engineer_v_3.0 - Добавление контрагента";
            Load += KontrAgentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Title;
        private Label label_Title;
        private Label label_Telephone;
        private TextBox textBox_Email;
        private Label label_Email;
        private TextBox textBox_Adress;
        private Label label1;
        private Label label_ContactUser;
        private TextBox textBox_ContactUser;
        private TextBox textBox_Description;
        private Label label_Description;
        private Button button_Add;
        private MaskedTextBox maskedTextBox_Telephone;
    }
}