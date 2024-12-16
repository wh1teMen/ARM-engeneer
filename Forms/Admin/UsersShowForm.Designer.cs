namespace ProgectE.Forms.Admin
{
    partial class UsersShowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersShowForm));
            contextMenuStrip1 = new ContextMenuStrip(components);
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            изменитьToolStripMenuItem = new ToolStripMenuItem();
            userBindingSource = new BindingSource(components);
            panel1 = new Panel();
            panel3 = new Panel();
            button_online = new Button();
            button_refresh = new Button();
            panel2 = new Panel();
            buttonFinde = new Button();
            textBox_findeLogin = new TextBox();
            dataGridView1 = new DataGridView();
            userIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            loginDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            imageDataDataGridViewImageColumn = new DataGridViewImageColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            surnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patronymicDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telephoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            percentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            taxDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { удалитьToolStripMenuItem, изменитьToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(127, 48);
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(126, 22);
            удалитьToolStripMenuItem.Text = "удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // изменитьToolStripMenuItem
            // 
            изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            изменитьToolStripMenuItem.Size = new Size(126, 22);
            изменитьToolStripMenuItem.Text = "изменить";
            изменитьToolStripMenuItem.Click += изменитьToolStripMenuItem_Click;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Model.User);
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1043, 46);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(button_online);
            panel3.Controls.Add(button_refresh);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(125, 46);
            panel3.TabIndex = 41;
            // 
            // button_online
            // 
            button_online.BackColor = Color.Transparent;
            button_online.BackgroundImage = (Image)resources.GetObject("button_online.BackgroundImage");
            button_online.BackgroundImageLayout = ImageLayout.Stretch;
            button_online.Cursor = Cursors.Hand;
            button_online.FlatAppearance.BorderSize = 0;
            button_online.FlatStyle = FlatStyle.Flat;
            button_online.Location = new Point(44, 7);
            button_online.Name = "button_online";
            button_online.Size = new Size(69, 30);
            button_online.TabIndex = 40;
            button_online.UseVisualStyleBackColor = false;
            button_online.Click += button_online_Click;
            // 
            // button_refresh
            // 
            button_refresh.BackColor = Color.Transparent;
            button_refresh.BackgroundImage = (Image)resources.GetObject("button_refresh.BackgroundImage");
            button_refresh.BackgroundImageLayout = ImageLayout.Stretch;
            button_refresh.Cursor = Cursors.Hand;
            button_refresh.FlatAppearance.BorderSize = 0;
            button_refresh.FlatStyle = FlatStyle.Flat;
            button_refresh.Location = new Point(3, 5);
            button_refresh.Name = "button_refresh";
            button_refresh.Size = new Size(35, 35);
            button_refresh.TabIndex = 5;
            button_refresh.UseVisualStyleBackColor = false;
            button_refresh.Click += button_refresh_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonFinde);
            panel2.Controls.Add(textBox_findeLogin);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(737, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(306, 46);
            panel2.TabIndex = 40;
            // 
            // buttonFinde
            // 
            buttonFinde.BackgroundImage = (Image)resources.GetObject("buttonFinde.BackgroundImage");
            buttonFinde.BackgroundImageLayout = ImageLayout.Stretch;
            buttonFinde.FlatAppearance.BorderSize = 0;
            buttonFinde.FlatStyle = FlatStyle.Flat;
            buttonFinde.Location = new Point(268, 5);
            buttonFinde.Name = "buttonFinde";
            buttonFinde.Size = new Size(35, 35);
            buttonFinde.TabIndex = 39;
            buttonFinde.UseVisualStyleBackColor = true;
            buttonFinde.Click += buttonFinde_Click;
            // 
            // textBox_findeLogin
            // 
            textBox_findeLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_findeLogin.Location = new Point(104, 10);
            textBox_findeLogin.Name = "textBox_findeLogin";
            textBox_findeLogin.Size = new Size(158, 27);
            textBox_findeLogin.TabIndex = 38;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { userIdDataGridViewTextBoxColumn, loginDataGridViewTextBoxColumn, imageDataDataGridViewImageColumn, nameDataGridViewTextBoxColumn, surnameDataGridViewTextBoxColumn, patronymicDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, telephoneDataGridViewTextBoxColumn, Status, percentDataGridViewTextBoxColumn, taxDataGridViewTextBoxColumn, salaryDataGridViewTextBoxColumn, roleIdDataGridViewTextBoxColumn, roleDataGridViewTextBoxColumn });
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.DataSource = userBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1043, 371);
            dataGridView1.TabIndex = 2;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            userIdDataGridViewTextBoxColumn.HeaderText = "Id";
            userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            userIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            loginDataGridViewTextBoxColumn.HeaderText = "Логин";
            loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // imageDataDataGridViewImageColumn
            // 
            imageDataDataGridViewImageColumn.DataPropertyName = "ImageData";
            imageDataDataGridViewImageColumn.HeaderText = "ImageData";
            imageDataDataGridViewImageColumn.Name = "imageDataDataGridViewImageColumn";
            imageDataDataGridViewImageColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            patronymicDataGridViewTextBoxColumn.HeaderText = "Отчество";
            patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Пароль";
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            telephoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Онлайн";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // percentDataGridViewTextBoxColumn
            // 
            percentDataGridViewTextBoxColumn.DataPropertyName = "Percent";
            percentDataGridViewTextBoxColumn.HeaderText = "Percent";
            percentDataGridViewTextBoxColumn.Name = "percentDataGridViewTextBoxColumn";
            percentDataGridViewTextBoxColumn.Visible = false;
            // 
            // taxDataGridViewTextBoxColumn
            // 
            taxDataGridViewTextBoxColumn.DataPropertyName = "Tax";
            taxDataGridViewTextBoxColumn.HeaderText = "Tax";
            taxDataGridViewTextBoxColumn.Name = "taxDataGridViewTextBoxColumn";
            taxDataGridViewTextBoxColumn.Visible = false;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            salaryDataGridViewTextBoxColumn.Visible = false;
            // 
            // roleIdDataGridViewTextBoxColumn
            // 
            roleIdDataGridViewTextBoxColumn.DataPropertyName = "RoleId";
            roleIdDataGridViewTextBoxColumn.HeaderText = "Роль";
            roleIdDataGridViewTextBoxColumn.Name = "roleIdDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            roleDataGridViewTextBoxColumn.HeaderText = "Role";
            roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            roleDataGridViewTextBoxColumn.Visible = false;
            // 
            // UsersShowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 417);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UsersShowForm";
            Text = "UsersShowForm";
            Load += UsersShowForm_Load;
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource userBindingSource;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem изменитьToolStripMenuItem;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button button_refresh;
        private Panel panel3;
        private Panel panel2;
        private Button buttonFinde;
        private TextBox textBox_findeLogin;
        private Button button_online;
        private DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private DataGridViewImageColumn imageDataDataGridViewImageColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewTextBoxColumn percentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn taxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
    }
}