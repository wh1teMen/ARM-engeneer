namespace ProgectE.Forms.Order
{
    partial class ShowOrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowOrdersForm));
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Created = new DataGridViewTextBoxColumn();
            numberRemKartDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            invoiceToClientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceOfmaterialsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countBarabanDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalCartridgesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            profitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kontragentIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Delete = new ToolStripMenuItem();
            изменить = new ToolStripMenuItem();
            orderBindingSource = new BindingSource(components);
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            panel2 = new Panel();
            panel6 = new Panel();
            button_Close = new Button();
            label_Kontragent = new Label();
            label_TotalCartrige = new Label();
            label_NumberOfCard = new Label();
            textBox_TotalCartrige = new TextBox();
            textBox_NumberOfCard = new TextBox();
            button_Update = new Button();
            label_CountBaraban = new Label();
            textBox_KontrAgent = new TextBox();
            textBox_CountBaraban = new TextBox();
            textBox_InvoiceToClient = new TextBox();
            label_PriceOfMaterial = new Label();
            label_InvoiceToClient = new Label();
            textBox_PriceOfMaterial = new TextBox();
            panel4 = new Panel();
            panel8 = new Panel();
            button_Finde2 = new Button();
            comboBox_Year = new ComboBox();
            comboBox_Month = new ComboBox();
            panel7 = new Panel();
            panel3 = new Panel();
            textBox_FindeRemKarta = new TextBox();
            buttonFinde = new Button();
            textBoxFindeKontrAgent = new TextBox();
            panel1 = new Panel();
            button_Add = new Button();
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Created, numberRemKartDataGridViewTextBoxColumn, invoiceToClientDataGridViewTextBoxColumn, priceOfmaterialsDataGridViewTextBoxColumn, countBarabanDataGridViewTextBoxColumn, totalCartridgesDataGridViewTextBoxColumn, profitDataGridViewTextBoxColumn, kontragentIdDataGridViewTextBoxColumn });
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.DataSource = orderBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.ButtonFace;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.ShowCellErrors = false;
            dataGridView1.Size = new Size(1115, 508);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // Created
            // 
            Created.DataPropertyName = "Created";
            Created.HeaderText = "Дата";
            Created.Name = "Created";
            // 
            // numberRemKartDataGridViewTextBoxColumn
            // 
            numberRemKartDataGridViewTextBoxColumn.DataPropertyName = "NumberRemKart";
            numberRemKartDataGridViewTextBoxColumn.HeaderText = "Номер РК";
            numberRemKartDataGridViewTextBoxColumn.Name = "numberRemKartDataGridViewTextBoxColumn";
            // 
            // invoiceToClientDataGridViewTextBoxColumn
            // 
            invoiceToClientDataGridViewTextBoxColumn.DataPropertyName = "InvoiceToClient";
            invoiceToClientDataGridViewTextBoxColumn.HeaderText = "Счёт";
            invoiceToClientDataGridViewTextBoxColumn.Name = "invoiceToClientDataGridViewTextBoxColumn";
            // 
            // priceOfmaterialsDataGridViewTextBoxColumn
            // 
            priceOfmaterialsDataGridViewTextBoxColumn.DataPropertyName = "PriceOfmaterials";
            priceOfmaterialsDataGridViewTextBoxColumn.HeaderText = "Материалы";
            priceOfmaterialsDataGridViewTextBoxColumn.Name = "priceOfmaterialsDataGridViewTextBoxColumn";
            // 
            // countBarabanDataGridViewTextBoxColumn
            // 
            countBarabanDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            countBarabanDataGridViewTextBoxColumn.DataPropertyName = "CountBaraban";
            countBarabanDataGridViewTextBoxColumn.HeaderText = "Барабаны";
            countBarabanDataGridViewTextBoxColumn.Name = "countBarabanDataGridViewTextBoxColumn";
            countBarabanDataGridViewTextBoxColumn.Width = 87;
            // 
            // totalCartridgesDataGridViewTextBoxColumn
            // 
            totalCartridgesDataGridViewTextBoxColumn.DataPropertyName = "TotalCartridges";
            totalCartridgesDataGridViewTextBoxColumn.HeaderText = "Кол-во картриджей";
            totalCartridgesDataGridViewTextBoxColumn.Name = "totalCartridgesDataGridViewTextBoxColumn";
            // 
            // profitDataGridViewTextBoxColumn
            // 
            profitDataGridViewTextBoxColumn.DataPropertyName = "Profit";
            profitDataGridViewTextBoxColumn.HeaderText = "Прибыль";
            profitDataGridViewTextBoxColumn.Name = "profitDataGridViewTextBoxColumn";
            // 
            // kontragentIdDataGridViewTextBoxColumn
            // 
            kontragentIdDataGridViewTextBoxColumn.DataPropertyName = "KontragentId";
            kontragentIdDataGridViewTextBoxColumn.HeaderText = "КонтрАгент";
            kontragentIdDataGridViewTextBoxColumn.Name = "kontragentIdDataGridViewTextBoxColumn";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { Delete, изменить });
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
            // изменить
            // 
            изменить.Name = "изменить";
            изменить.Size = new Size(128, 22);
            изменить.Text = "Изменить";
            изменить.Click += изменить_Click;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Model.Order);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePicker1.ImeMode = ImeMode.On;
            dateTimePicker1.Location = new Point(6, 6);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(177, 28);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.Value = new DateTime(2024, 10, 8, 0, 0, 0, 0);
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(53, 4);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel6);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1115, 142);
            panel2.TabIndex = 24;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(button_Close);
            panel6.Controls.Add(label_Kontragent);
            panel6.Controls.Add(label_TotalCartrige);
            panel6.Controls.Add(label_NumberOfCard);
            panel6.Controls.Add(textBox_TotalCartrige);
            panel6.Controls.Add(textBox_NumberOfCard);
            panel6.Controls.Add(button_Update);
            panel6.Controls.Add(label_CountBaraban);
            panel6.Controls.Add(textBox_KontrAgent);
            panel6.Controls.Add(textBox_CountBaraban);
            panel6.Controls.Add(textBox_InvoiceToClient);
            panel6.Controls.Add(label_PriceOfMaterial);
            panel6.Controls.Add(label_InvoiceToClient);
            panel6.Controls.Add(textBox_PriceOfMaterial);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1115, 142);
            panel6.TabIndex = 25;
            // 
            // button_Close
            // 
            button_Close.BackColor = Color.Transparent;
            button_Close.BackgroundImage = (Image)resources.GetObject("button_Close.BackgroundImage");
            button_Close.BackgroundImageLayout = ImageLayout.Stretch;
            button_Close.Cursor = Cursors.Hand;
            button_Close.FlatAppearance.BorderSize = 0;
            button_Close.FlatStyle = FlatStyle.Flat;
            button_Close.Location = new Point(5, 3);
            button_Close.Margin = new Padding(0);
            button_Close.Name = "button_Close";
            button_Close.Size = new Size(20, 20);
            button_Close.TabIndex = 36;
            button_Close.UseVisualStyleBackColor = false;
            button_Close.Click += button_Close_Click;
            // 
            // label_Kontragent
            // 
            label_Kontragent.AutoSize = true;
            label_Kontragent.Location = new Point(44, 48);
            label_Kontragent.Name = "label_Kontragent";
            label_Kontragent.Size = new Size(72, 15);
            label_Kontragent.TabIndex = 27;
            label_Kontragent.Text = "Контрагент:";
            // 
            // label_TotalCartrige
            // 
            label_TotalCartrige.AutoSize = true;
            label_TotalCartrige.Location = new Point(491, 77);
            label_TotalCartrige.Name = "label_TotalCartrige";
            label_TotalCartrige.Size = new Size(144, 15);
            label_TotalCartrige.TabIndex = 35;
            label_TotalCartrige.Text = "Количество картриджей:";
            // 
            // label_NumberOfCard
            // 
            label_NumberOfCard.AutoSize = true;
            label_NumberOfCard.Location = new Point(44, 14);
            label_NumberOfCard.Name = "label_NumberOfCard";
            label_NumberOfCard.Size = new Size(152, 15);
            label_NumberOfCard.TabIndex = 24;
            label_NumberOfCard.Text = "Номер ремонтной карты: ";
            // 
            // textBox_TotalCartrige
            // 
            textBox_TotalCartrige.AutoCompleteCustomSource.AddRange(new string[] { "петров иванов " });
            textBox_TotalCartrige.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox_TotalCartrige.Location = new Point(664, 73);
            textBox_TotalCartrige.Name = "textBox_TotalCartrige";
            textBox_TotalCartrige.Size = new Size(232, 23);
            textBox_TotalCartrige.TabIndex = 34;
            // 
            // textBox_NumberOfCard
            // 
            textBox_NumberOfCard.Location = new Point(217, 15);
            textBox_NumberOfCard.Name = "textBox_NumberOfCard";
            textBox_NumberOfCard.Size = new Size(232, 23);
            textBox_NumberOfCard.TabIndex = 25;
            // 
            // button_Update
            // 
            button_Update.Location = new Point(807, 102);
            button_Update.Name = "button_Update";
            button_Update.Size = new Size(88, 30);
            button_Update.TabIndex = 8;
            button_Update.Text = "Сохранить";
            button_Update.UseVisualStyleBackColor = true;
            button_Update.Click += button_Update_Click;
            // 
            // label_CountBaraban
            // 
            label_CountBaraban.AutoSize = true;
            label_CountBaraban.Location = new Point(491, 48);
            label_CountBaraban.Name = "label_CountBaraban";
            label_CountBaraban.Size = new Size(165, 15);
            label_CountBaraban.TabIndex = 33;
            label_CountBaraban.Text = "Количество фотобарабанов:";
            // 
            // textBox_KontrAgent
            // 
            textBox_KontrAgent.AutoCompleteCustomSource.AddRange(new string[] { "петров иванов " });
            textBox_KontrAgent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox_KontrAgent.Location = new Point(217, 48);
            textBox_KontrAgent.Name = "textBox_KontrAgent";
            textBox_KontrAgent.Size = new Size(232, 23);
            textBox_KontrAgent.TabIndex = 26;
            // 
            // textBox_CountBaraban
            // 
            textBox_CountBaraban.AutoCompleteCustomSource.AddRange(new string[] { "петров иванов " });
            textBox_CountBaraban.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox_CountBaraban.Location = new Point(664, 44);
            textBox_CountBaraban.Name = "textBox_CountBaraban";
            textBox_CountBaraban.Size = new Size(232, 23);
            textBox_CountBaraban.TabIndex = 32;
            // 
            // textBox_InvoiceToClient
            // 
            textBox_InvoiceToClient.AutoCompleteCustomSource.AddRange(new string[] { "петров иванов " });
            textBox_InvoiceToClient.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox_InvoiceToClient.Location = new Point(217, 77);
            textBox_InvoiceToClient.Name = "textBox_InvoiceToClient";
            textBox_InvoiceToClient.Size = new Size(232, 23);
            textBox_InvoiceToClient.TabIndex = 28;
            // 
            // label_PriceOfMaterial
            // 
            label_PriceOfMaterial.AutoSize = true;
            label_PriceOfMaterial.Location = new Point(491, 19);
            label_PriceOfMaterial.Name = "label_PriceOfMaterial";
            label_PriceOfMaterial.Size = new Size(107, 15);
            label_PriceOfMaterial.TabIndex = 31;
            label_PriceOfMaterial.Text = "Цена материалов:";
            // 
            // label_InvoiceToClient
            // 
            label_InvoiceToClient.AutoSize = true;
            label_InvoiceToClient.Location = new Point(44, 81);
            label_InvoiceToClient.Name = "label_InvoiceToClient";
            label_InvoiceToClient.Size = new Size(83, 15);
            label_InvoiceToClient.TabIndex = 29;
            label_InvoiceToClient.Text = "Счет клиенту:";
            // 
            // textBox_PriceOfMaterial
            // 
            textBox_PriceOfMaterial.AutoCompleteCustomSource.AddRange(new string[] { "петров иванов " });
            textBox_PriceOfMaterial.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox_PriceOfMaterial.Location = new Point(664, 15);
            textBox_PriceOfMaterial.Name = "textBox_PriceOfMaterial";
            textBox_PriceOfMaterial.Size = new Size(232, 23);
            textBox_PriceOfMaterial.TabIndex = 30;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(panel1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 142);
            panel4.Name = "panel4";
            panel4.Size = new Size(1115, 40);
            panel4.TabIndex = 25;
            // 
            // panel8
            // 
            panel8.Controls.Add(button_Finde2);
            panel8.Controls.Add(comboBox_Year);
            panel8.Controls.Add(comboBox_Month);
            panel8.Dock = DockStyle.Right;
            panel8.Location = new Point(238, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(261, 40);
            panel8.TabIndex = 42;
            // 
            // button_Finde2
            // 
            button_Finde2.BackgroundImage = (Image)resources.GetObject("button_Finde2.BackgroundImage");
            button_Finde2.BackgroundImageLayout = ImageLayout.Stretch;
            button_Finde2.FlatAppearance.BorderSize = 0;
            button_Finde2.FlatStyle = FlatStyle.Flat;
            button_Finde2.Location = new Point(219, 3);
            button_Finde2.Name = "button_Finde2";
            button_Finde2.Size = new Size(35, 35);
            button_Finde2.TabIndex = 38;
            button_Finde2.UseVisualStyleBackColor = true;
            button_Finde2.Click += button_Finde2_Click;
            // 
            // comboBox_Year
            // 
            comboBox_Year.Font = new Font("Comic Sans MS", 11.25F);
            comboBox_Year.FormattingEnabled = true;
            comboBox_Year.Location = new Point(113, 7);
            comboBox_Year.Name = "comboBox_Year";
            comboBox_Year.Size = new Size(100, 28);
            comboBox_Year.TabIndex = 43;
            comboBox_Year.SelectedIndexChanged += comboBox_Year_SelectedIndexChanged;
            // 
            // comboBox_Month
            // 
            comboBox_Month.Font = new Font("Comic Sans MS", 11.25F);
            comboBox_Month.FormattingEnabled = true;
            comboBox_Month.Location = new Point(3, 6);
            comboBox_Month.Name = "comboBox_Month";
            comboBox_Month.Size = new Size(100, 28);
            comboBox_Month.TabIndex = 42;
            // 
            // panel7
            // 
            panel7.Controls.Add(dateTimePicker1);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(499, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(193, 40);
            panel7.TabIndex = 41;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox_FindeRemKarta);
            panel3.Controls.Add(buttonFinde);
            panel3.Controls.Add(textBoxFindeKontrAgent);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(692, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(423, 40);
            panel3.TabIndex = 40;
            // 
            // textBox_FindeRemKarta
            // 
            textBox_FindeRemKarta.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox_FindeRemKarta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_FindeRemKarta.Location = new Point(212, 6);
            textBox_FindeRemKarta.Name = "textBox_FindeRemKarta";
            textBox_FindeRemKarta.Size = new Size(158, 27);
            textBox_FindeRemKarta.TabIndex = 36;
            textBox_FindeRemKarta.TextChanged += textBox_FindeRemKarta_TextChanged;
            // 
            // buttonFinde
            // 
            buttonFinde.BackgroundImage = (Image)resources.GetObject("buttonFinde.BackgroundImage");
            buttonFinde.BackgroundImageLayout = ImageLayout.Stretch;
            buttonFinde.FlatAppearance.BorderSize = 0;
            buttonFinde.FlatStyle = FlatStyle.Flat;
            buttonFinde.Location = new Point(376, 1);
            buttonFinde.Name = "buttonFinde";
            buttonFinde.Size = new Size(35, 35);
            buttonFinde.TabIndex = 37;
            buttonFinde.UseVisualStyleBackColor = true;
            buttonFinde.Click += buttonFinde_Click;
            // 
            // textBoxFindeKontrAgent
            // 
            textBoxFindeKontrAgent.AutoCompleteCustomSource.AddRange(new string[] { "петров иванов " });
            textBoxFindeKontrAgent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxFindeKontrAgent.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxFindeKontrAgent.Location = new Point(10, 7);
            textBoxFindeKontrAgent.Name = "textBoxFindeKontrAgent";
            textBoxFindeKontrAgent.Size = new Size(196, 27);
            textBoxFindeKontrAgent.TabIndex = 36;
            textBoxFindeKontrAgent.TextChanged += textBoxFindeKontrAgent_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(button_Add);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5, 0, 0, 0);
            panel1.Size = new Size(232, 40);
            panel1.TabIndex = 7;
            // 
            // button_Add
            // 
            button_Add.BackgroundImage = (Image)resources.GetObject("button_Add.BackgroundImage");
            button_Add.BackgroundImageLayout = ImageLayout.Stretch;
            button_Add.FlatAppearance.BorderSize = 0;
            button_Add.FlatStyle = FlatStyle.Flat;
            button_Add.Location = new Point(12, 4);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(35, 35);
            button_Add.TabIndex = 39;
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(dataGridView1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 182);
            panel5.Name = "panel5";
            panel5.Size = new Size(1115, 508);
            panel5.TabIndex = 26;
            // 
            // ShowOrdersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 690);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ShowOrdersForm";
            Text = "Engineer_v_3.0 - Счета";
            Load += ShowOrdersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource orderBindingSource;
        private DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private Panel panel1;
        private Panel panel6;
        private Label label_Kontragent;
        private Label label_TotalCartrige;
        private Label label_NumberOfCard;
        private TextBox textBox_TotalCartrige;
        private TextBox textBox_NumberOfCard;
        private Label label_CountBaraban;
        private TextBox textBox_KontrAgent;
        private TextBox textBox_CountBaraban;
        private TextBox textBox_InvoiceToClient;
        private Label label_PriceOfMaterial;
        private Label label_InvoiceToClient;
        private TextBox textBox_PriceOfMaterial;
        private Button button_Update;
        private Button buttonFinde;
        private TextBox textBox_FindeRemKarta;
        private TextBox textBoxFindeKontrAgent;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem Delete;
        private ToolStripMenuItem изменить;
        private Button button_Close;
        private Button button_Add;
        private Panel panel3;
        private Panel panel7;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Created;
        private DataGridViewTextBoxColumn numberRemKartDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn invoiceToClientDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceOfmaterialsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countBarabanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalCartridgesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn profitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kontragentIdDataGridViewTextBoxColumn;
        private ComboBox comboBox_Year;
        private ComboBox comboBox_Month;
        private Panel panel8;
        private Button button_Finde2;
    }
}