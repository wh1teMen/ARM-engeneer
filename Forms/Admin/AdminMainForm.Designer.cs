namespace ProgectE.Forms.Admin
{
    partial class AdminMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            menuStrip1 = new MenuStrip();
            пользователиToolStripMenuItem = new ToolStripMenuItem();
            пользователиToolStripMenuItem1 = new ToolStripMenuItem();
            контрагентыToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            panel_all = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { пользователиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1130, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // пользователиToolStripMenuItem
            // 
            пользователиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { пользователиToolStripMenuItem1, контрагентыToolStripMenuItem, выходToolStripMenuItem });
            пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            пользователиToolStripMenuItem.Size = new Size(53, 20);
            пользователиToolStripMenuItem.Text = "Меню";
            // 
            // пользователиToolStripMenuItem1
            // 
            пользователиToolStripMenuItem1.Name = "пользователиToolStripMenuItem1";
            пользователиToolStripMenuItem1.Size = new Size(152, 22);
            пользователиToolStripMenuItem1.Text = "Пользователи";
            пользователиToolStripMenuItem1.Click += пользователиToolStripMenuItem1_Click;
            // 
            // контрагентыToolStripMenuItem
            // 
            контрагентыToolStripMenuItem.Name = "контрагентыToolStripMenuItem";
            контрагентыToolStripMenuItem.Size = new Size(152, 22);
            контрагентыToolStripMenuItem.Text = "Контрагенты";
            контрагентыToolStripMenuItem.Click += контрагентыToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(152, 22);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // panel_all
            // 
            panel_all.Dock = DockStyle.Fill;
            panel_all.Location = new Point(0, 24);
            panel_all.Name = "panel_all";
            panel_all.Size = new Size(1130, 759);
            panel_all.TabIndex = 1;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 783);
            Controls.Add(panel_all);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "AdminMainForm";
            Text = "AdminMainForm";
            FormClosing += AdminMainForm_FormClosing;
            Load += AdminMainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem пользователиToolStripMenuItem;
        private Panel panel_all;
        private ToolStripMenuItem пользователиToolStripMenuItem1;
        private ToolStripMenuItem контрагентыToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
    }
}