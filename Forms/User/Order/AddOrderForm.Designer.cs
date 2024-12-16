namespace ProgectE
{
    partial class AddOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrderForm));
            textBox_KontrAgent = new TextBox();
            button_AddOrder = new Button();
            label_Kontragent = new Label();
            label_TotalCartrige = new Label();
            textBox_TotalCartrige = new TextBox();
            label_NumberOfCard = new Label();
            textBox_NumberOfCard = new TextBox();
            textBox_InvoiceToClient = new TextBox();
            label_InvoiceToClient = new Label();
            textBox_PriceOfMaterial = new TextBox();
            label_PriceOfMaterial = new Label();
            textBox_CountBaraban = new TextBox();
            label_CountBaraban = new Label();
            SuspendLayout();
            // 
            // textBox_KontrAgent
            // 
            textBox_KontrAgent.AutoCompleteCustomSource.AddRange(new string[] { "петров иванов " });
            textBox_KontrAgent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox_KontrAgent.Font = new Font("Arial Narrow", 14.25F);
            textBox_KontrAgent.Location = new Point(317, 63);
            textBox_KontrAgent.Name = "textBox_KontrAgent";
            textBox_KontrAgent.Size = new Size(225, 29);
            textBox_KontrAgent.TabIndex = 41;
            textBox_KontrAgent.Validating += textBox_KontrAgent_Validating;
            // 
            // button_AddOrder
            // 
            button_AddOrder.BackColor = Color.FromArgb(177, 245, 128);
            button_AddOrder.FlatAppearance.BorderSize = 0;
            button_AddOrder.FlatStyle = FlatStyle.Flat;
            button_AddOrder.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_AddOrder.Location = new Point(17, 308);
            button_AddOrder.Name = "button_AddOrder";
            button_AddOrder.Size = new Size(525, 42);
            button_AddOrder.TabIndex = 51;
            button_AddOrder.Text = "Добавить";
            button_AddOrder.UseVisualStyleBackColor = false;
            button_AddOrder.Click += button_AddOrder_Click_1;
            // 
            // label_Kontragent
            // 
            label_Kontragent.AutoSize = true;
            label_Kontragent.Font = new Font("Arial", 14.25F);
            label_Kontragent.Location = new Point(17, 63);
            label_Kontragent.Name = "label_Kontragent";
            label_Kontragent.Size = new Size(112, 22);
            label_Kontragent.TabIndex = 42;
            label_Kontragent.Text = "Контрагент:";
            // 
            // label_TotalCartrige
            // 
            label_TotalCartrige.AutoSize = true;
            label_TotalCartrige.Font = new Font("Arial", 14.25F);
            label_TotalCartrige.Location = new Point(17, 263);
            label_TotalCartrige.Name = "label_TotalCartrige";
            label_TotalCartrige.Size = new Size(226, 22);
            label_TotalCartrige.TabIndex = 50;
            label_TotalCartrige.Text = "Количество картриджей:";
            // 
            // textBox_TotalCartrige
            // 
            textBox_TotalCartrige.AutoCompleteCustomSource.AddRange(new string[] { "петров иванов " });
            textBox_TotalCartrige.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox_TotalCartrige.Font = new Font("Arial Narrow", 14.25F);
            textBox_TotalCartrige.Location = new Point(317, 256);
            textBox_TotalCartrige.Name = "textBox_TotalCartrige";
            textBox_TotalCartrige.Size = new Size(225, 29);
            textBox_TotalCartrige.TabIndex = 49;
            textBox_TotalCartrige.Validating += textBox_TotalCartrige_Validating;
            // 
            // label_NumberOfCard
            // 
            label_NumberOfCard.AutoSize = true;
            label_NumberOfCard.Font = new Font("Arial", 14.25F);
            label_NumberOfCard.Location = new Point(17, 17);
            label_NumberOfCard.Name = "label_NumberOfCard";
            label_NumberOfCard.Size = new Size(235, 22);
            label_NumberOfCard.TabIndex = 39;
            label_NumberOfCard.Text = "Номер ремонтной карты: ";
            // 
            // textBox_NumberOfCard
            // 
            textBox_NumberOfCard.Font = new Font("Arial Narrow", 14.25F);
            textBox_NumberOfCard.Location = new Point(317, 17);
            textBox_NumberOfCard.Name = "textBox_NumberOfCard";
            textBox_NumberOfCard.Size = new Size(225, 29);
            textBox_NumberOfCard.TabIndex = 40;
            textBox_NumberOfCard.Validating += textBox_NumberOfCard_Validating;
            // 
            // textBox_InvoiceToClient
            // 
            textBox_InvoiceToClient.AutoCompleteCustomSource.AddRange(new string[] { "петров иванов " });
            textBox_InvoiceToClient.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox_InvoiceToClient.Font = new Font("Arial Narrow", 14.25F);
            textBox_InvoiceToClient.Location = new Point(317, 107);
            textBox_InvoiceToClient.Name = "textBox_InvoiceToClient";
            textBox_InvoiceToClient.Size = new Size(225, 29);
            textBox_InvoiceToClient.TabIndex = 43;
            textBox_InvoiceToClient.Validating += textBox_InvoiceToClient_Validating;
            // 
            // label_InvoiceToClient
            // 
            label_InvoiceToClient.AutoSize = true;
            label_InvoiceToClient.Font = new Font("Arial", 14.25F);
            label_InvoiceToClient.Location = new Point(17, 114);
            label_InvoiceToClient.Name = "label_InvoiceToClient";
            label_InvoiceToClient.Size = new Size(128, 22);
            label_InvoiceToClient.TabIndex = 44;
            label_InvoiceToClient.Text = "Счет клиенту:";
            // 
            // textBox_PriceOfMaterial
            // 
            textBox_PriceOfMaterial.AutoCompleteCustomSource.AddRange(new string[] { "петров иванов " });
            textBox_PriceOfMaterial.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox_PriceOfMaterial.Font = new Font("Arial Narrow", 14.25F);
            textBox_PriceOfMaterial.Location = new Point(317, 153);
            textBox_PriceOfMaterial.Name = "textBox_PriceOfMaterial";
            textBox_PriceOfMaterial.Size = new Size(225, 29);
            textBox_PriceOfMaterial.TabIndex = 45;
            textBox_PriceOfMaterial.Validating += textBox_PriceOfMaterial_Validating;
            // 
            // label_PriceOfMaterial
            // 
            label_PriceOfMaterial.AutoSize = true;
            label_PriceOfMaterial.Font = new Font("Arial", 14.25F);
            label_PriceOfMaterial.Location = new Point(17, 160);
            label_PriceOfMaterial.Name = "label_PriceOfMaterial";
            label_PriceOfMaterial.Size = new Size(169, 22);
            label_PriceOfMaterial.TabIndex = 46;
            label_PriceOfMaterial.Text = "Цена материалов:";
            // 
            // textBox_CountBaraban
            // 
            textBox_CountBaraban.AutoCompleteCustomSource.AddRange(new string[] { "петров иванов " });
            textBox_CountBaraban.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox_CountBaraban.Font = new Font("Arial Narrow", 14.25F);
            textBox_CountBaraban.Location = new Point(317, 207);
            textBox_CountBaraban.Name = "textBox_CountBaraban";
            textBox_CountBaraban.Size = new Size(225, 29);
            textBox_CountBaraban.TabIndex = 47;
            textBox_CountBaraban.Validating += textBox_CountBaraban_Validating;
            // 
            // label_CountBaraban
            // 
            label_CountBaraban.AutoSize = true;
            label_CountBaraban.Font = new Font("Arial", 14.25F);
            label_CountBaraban.Location = new Point(17, 211);
            label_CountBaraban.Name = "label_CountBaraban";
            label_CountBaraban.Size = new Size(262, 22);
            label_CountBaraban.TabIndex = 48;
            label_CountBaraban.Text = "Количество фотобарабанов:";
            // 
            // AddOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 367);
            Controls.Add(textBox_InvoiceToClient);
            Controls.Add(textBox_PriceOfMaterial);
            Controls.Add(textBox_CountBaraban);
            Controls.Add(label_CountBaraban);
            Controls.Add(label_PriceOfMaterial);
            Controls.Add(textBox_TotalCartrige);
            Controls.Add(button_AddOrder);
            Controls.Add(label_InvoiceToClient);
            Controls.Add(textBox_NumberOfCard);
            Controls.Add(label_NumberOfCard);
            Controls.Add(label_Kontragent);
            Controls.Add(textBox_KontrAgent);
            Controls.Add(label_TotalCartrige);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddOrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Engineer_v_3.0 - Добавление новго счёта";
            Load += AddOrderForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_KontrAgent;
        private Button button_AddOrder;
        private Label label_Kontragent;
        private Label label_TotalCartrige;
        private TextBox textBox_TotalCartrige;
        private Label label_NumberOfCard;
        private TextBox textBox_NumberOfCard;
        private TextBox textBox_InvoiceToClient;
        private Label label_InvoiceToClient;
        private TextBox textBox_PriceOfMaterial;
        private Label label_PriceOfMaterial;
        private TextBox textBox_CountBaraban;
        private Label label_CountBaraban;
    }
}