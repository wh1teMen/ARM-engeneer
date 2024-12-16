namespace ProgectE.Forms.Kontragent
{
    partial class ShowKontrAgentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowKontrAgentForm));
            panel_1 = new Panel();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telephoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactUserNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            discriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Delete = new ToolStripMenuItem();
            Update = new ToolStripMenuItem();
            kontragentBindingSource = new BindingSource(components);
            panel2 = new Panel();
            panel5 = new Panel();
            textBox_id = new TextBox();
            panel4 = new Panel();
            buttonFinde = new Button();
            textBoxFindeKontrAgent = new TextBox();
            button_Add = new Button();
            button_refresh = new Button();
            panel1 = new Panel();
            textBox_Description = new TextBox();
            label_Description = new Label();
            button_Close = new Button();
            button_update = new Button();
            textBox_ContactUser = new TextBox();
            label_ContactUser = new Label();
            textBox_Email = new TextBox();
            label_Email = new Label();
            maskedTextBox_Telephone = new MaskedTextBox();
            textBox_Adress = new TextBox();
            label1 = new Label();
            label_Telephone = new Label();
            label_Title = new Label();
            textBox_Title = new TextBox();
            panel_1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kontragentBindingSource).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_1
            // 
            panel_1.Controls.Add(panel3);
            panel_1.Controls.Add(panel2);
            panel_1.Controls.Add(panel1);
            panel_1.Dock = DockStyle.Fill;
            panel_1.Location = new Point(0, 0);
            panel_1.Name = "panel_1";
            panel_1.Size = new Size(1199, 819);
            panel_1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 214);
            panel3.Name = "panel3";
            panel3.Size = new Size(1199, 605);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, telephoneDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, adressDataGridViewTextBoxColumn, contactUserNameDataGridViewTextBoxColumn, discriptionDataGridViewTextBoxColumn });
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.DataSource = kontragentBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1199, 605);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Название";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            telephoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            adressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // contactUserNameDataGridViewTextBoxColumn
            // 
            contactUserNameDataGridViewTextBoxColumn.DataPropertyName = "ContactUserName";
            contactUserNameDataGridViewTextBoxColumn.HeaderText = "Контактное лицо";
            contactUserNameDataGridViewTextBoxColumn.Name = "contactUserNameDataGridViewTextBoxColumn";
            // 
            // discriptionDataGridViewTextBoxColumn
            // 
            discriptionDataGridViewTextBoxColumn.DataPropertyName = "Discription";
            discriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            discriptionDataGridViewTextBoxColumn.Name = "discriptionDataGridViewTextBoxColumn";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { Delete, Update });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(129, 48);
            // 
            // Delete
            // 
            Delete.Name = "Delete";
            Delete.Size = new Size(128, 22);
            Delete.Text = "Удалить";
            Delete.Click += Delete_Click;
            // 
            // Update
            // 
            Update.Name = "Update";
            Update.Size = new Size(128, 22);
            Update.Text = "Изменить";
            Update.Click += Update_Click;
            // 
            // kontragentBindingSource
            // 
            kontragentBindingSource.DataSource = typeof(Model.Kontragent);
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(button_Add);
            panel2.Controls.Add(button_refresh);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 167);
            panel2.Name = "panel2";
            panel2.Size = new Size(1199, 47);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox_id);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(754, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(161, 47);
            panel5.TabIndex = 44;
            // 
            // textBox_id
            // 
            textBox_id.AutoCompleteCustomSource.AddRange(new string[] { "петров иванов " });
            textBox_id.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox_id.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_id.Location = new Point(46, 9);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(97, 27);
            textBox_id.TabIndex = 43;
            textBox_id.TextChanged += textBox_id_TextChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(buttonFinde);
            panel4.Controls.Add(textBoxFindeKontrAgent);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(915, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(284, 47);
            panel4.TabIndex = 43;
            // 
            // buttonFinde
            // 
            buttonFinde.BackgroundImage = (Image)resources.GetObject("buttonFinde.BackgroundImage");
            buttonFinde.BackgroundImageLayout = ImageLayout.Stretch;
            buttonFinde.FlatAppearance.BorderSize = 0;
            buttonFinde.FlatStyle = FlatStyle.Flat;
            buttonFinde.Location = new Point(246, 6);
            buttonFinde.Name = "buttonFinde";
            buttonFinde.Size = new Size(35, 35);
            buttonFinde.TabIndex = 42;
            buttonFinde.UseVisualStyleBackColor = true;
            buttonFinde.Click += buttonFinde_Click;
            // 
            // textBoxFindeKontrAgent
            // 
            textBoxFindeKontrAgent.AutoCompleteCustomSource.AddRange(new string[] { "петров иванов " });
            textBoxFindeKontrAgent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxFindeKontrAgent.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxFindeKontrAgent.Location = new Point(44, 9);
            textBoxFindeKontrAgent.Name = "textBoxFindeKontrAgent";
            textBoxFindeKontrAgent.Size = new Size(196, 27);
            textBoxFindeKontrAgent.TabIndex = 41;
            textBoxFindeKontrAgent.TextChanged += textBoxFindeKontrAgent_TextChanged;
            // 
            // button_Add
            // 
            button_Add.BackgroundImage = (Image)resources.GetObject("button_Add.BackgroundImage");
            button_Add.BackgroundImageLayout = ImageLayout.Stretch;
            button_Add.FlatAppearance.BorderSize = 0;
            button_Add.FlatStyle = FlatStyle.Flat;
            button_Add.Location = new Point(6, 6);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(35, 35);
            button_Add.TabIndex = 40;
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // button_refresh
            // 
            button_refresh.BackColor = Color.Transparent;
            button_refresh.BackgroundImage = (Image)resources.GetObject("button_refresh.BackgroundImage");
            button_refresh.BackgroundImageLayout = ImageLayout.Stretch;
            button_refresh.Cursor = Cursors.Hand;
            button_refresh.FlatAppearance.BorderSize = 0;
            button_refresh.FlatStyle = FlatStyle.Flat;
            button_refresh.Location = new Point(47, 6);
            button_refresh.Name = "button_refresh";
            button_refresh.Size = new Size(35, 35);
            button_refresh.TabIndex = 5;
            button_refresh.UseVisualStyleBackColor = false;
            button_refresh.Click += button_refresh_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox_Description);
            panel1.Controls.Add(label_Description);
            panel1.Controls.Add(button_Close);
            panel1.Controls.Add(button_update);
            panel1.Controls.Add(textBox_ContactUser);
            panel1.Controls.Add(label_ContactUser);
            panel1.Controls.Add(textBox_Email);
            panel1.Controls.Add(label_Email);
            panel1.Controls.Add(maskedTextBox_Telephone);
            panel1.Controls.Add(textBox_Adress);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label_Telephone);
            panel1.Controls.Add(label_Title);
            panel1.Controls.Add(textBox_Title);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1199, 167);
            panel1.TabIndex = 0;
            // 
            // textBox_Description
            // 
            textBox_Description.Location = new Point(722, 33);
            textBox_Description.Multiline = true;
            textBox_Description.Name = "textBox_Description";
            textBox_Description.Size = new Size(224, 131);
            textBox_Description.TabIndex = 17;
            // 
            // label_Description
            // 
            label_Description.AutoSize = true;
            label_Description.Location = new Point(722, 8);
            label_Description.Name = "label_Description";
            label_Description.Size = new Size(65, 15);
            label_Description.TabIndex = 18;
            label_Description.Text = "Описание:";
            // 
            // button_Close
            // 
            button_Close.BackColor = Color.Transparent;
            button_Close.BackgroundImage = (Image)resources.GetObject("button_Close.BackgroundImage");
            button_Close.BackgroundImageLayout = ImageLayout.Stretch;
            button_Close.Cursor = Cursors.Hand;
            button_Close.FlatAppearance.BorderSize = 0;
            button_Close.FlatStyle = FlatStyle.Flat;
            button_Close.Location = new Point(0, 0);
            button_Close.Margin = new Padding(0);
            button_Close.Name = "button_Close";
            button_Close.Size = new Size(20, 20);
            button_Close.TabIndex = 37;
            button_Close.UseVisualStyleBackColor = false;
            button_Close.Click += button_Close_Click;
            // 
            // button_update
            // 
            button_update.Location = new Point(474, 100);
            button_update.Name = "button_update";
            button_update.Size = new Size(228, 28);
            button_update.TabIndex = 19;
            button_update.Text = "Сохранить";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // textBox_ContactUser
            // 
            textBox_ContactUser.Location = new Point(474, 57);
            textBox_ContactUser.Name = "textBox_ContactUser";
            textBox_ContactUser.Size = new Size(228, 23);
            textBox_ContactUser.TabIndex = 14;
            // 
            // label_ContactUser
            // 
            label_ContactUser.AutoSize = true;
            label_ContactUser.Location = new Point(352, 57);
            label_ContactUser.Name = "label_ContactUser";
            label_ContactUser.Size = new Size(104, 15);
            label_ContactUser.TabIndex = 16;
            label_ContactUser.Text = "Контактное лицо:";
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(474, 18);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(228, 23);
            textBox_Email.TabIndex = 13;
            textBox_Email.Validating += textBox_Email_Validating;
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.Location = new Point(352, 18);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(116, 15);
            label_Email.TabIndex = 15;
            label_Email.Text = "Электронная почта:";
            // 
            // maskedTextBox_Telephone
            // 
            maskedTextBox_Telephone.Location = new Point(105, 65);
            maskedTextBox_Telephone.Mask = "+7(999) 000-0000";
            maskedTextBox_Telephone.Name = "maskedTextBox_Telephone";
            maskedTextBox_Telephone.Size = new Size(228, 23);
            maskedTextBox_Telephone.TabIndex = 8;
            // 
            // textBox_Adress
            // 
            textBox_Adress.Location = new Point(105, 105);
            textBox_Adress.Name = "textBox_Adress";
            textBox_Adress.Size = new Size(228, 23);
            textBox_Adress.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 108);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 12;
            label1.Text = "Адрес:";
            // 
            // label_Telephone
            // 
            label_Telephone.AutoSize = true;
            label_Telephone.Location = new Point(22, 73);
            label_Telephone.Name = "label_Telephone";
            label_Telephone.Size = new Size(58, 15);
            label_Telephone.TabIndex = 11;
            label_Telephone.Text = "Телефон:";
            // 
            // label_Title
            // 
            label_Title.AutoSize = true;
            label_Title.Location = new Point(22, 18);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(62, 15);
            label_Title.TabIndex = 9;
            label_Title.Text = "Название:";
            // 
            // textBox_Title
            // 
            textBox_Title.Location = new Point(105, 18);
            textBox_Title.Name = "textBox_Title";
            textBox_Title.Size = new Size(228, 23);
            textBox_Title.TabIndex = 7;
            // 
            // ShowKontrAgentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 819);
            Controls.Add(panel_1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ShowKontrAgentForm";
            Text = "Engineer_v_3.0 - Контрагенты";
            Load += ShowKontrAgentForm_Load;
            panel_1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kontragentBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private DataGridView dataGridView1;
        private BindingSource kontragentBindingSource;
        private Button button_refresh;
        private MaskedTextBox maskedTextBox_Telephone;
        private TextBox textBox_Adress;
        private Label label1;
        private Label label_Telephone;
        private Label label_Title;
        private TextBox textBox_Title;
        private TextBox textBox_ContactUser;
        private Label label_ContactUser;
        private TextBox textBox_Email;
        private Label label_Email;
        private Label label_Description;
        private TextBox textBox_Description;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem Delete;
        private ToolStripMenuItem Update;
        private Button button_Add;
        private Button button_update;
        private Button button_Close;
        private Button buttonFinde;
        private TextBox textBoxFindeKontrAgent;
        private Panel panel4;
        private Panel panel5;
        private TextBox textBox_id;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactUserNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discriptionDataGridViewTextBoxColumn;
    }
}