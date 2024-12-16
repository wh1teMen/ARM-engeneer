namespace ProgectE.Forms.User
{
    partial class MiniForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniForm));
            button_add = new Button();
            label_toMonth = new Label();
            pictureBox_Money = new PictureBox();
            pictureBox1 = new PictureBox();
            label_ToDay = new Label();
            notifyIcon1 = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Money).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_add
            // 
            button_add.BackColor = Color.Transparent;
            button_add.BackgroundImage = (Image)resources.GetObject("button_add.BackgroundImage");
            button_add.BackgroundImageLayout = ImageLayout.Stretch;
            button_add.Cursor = Cursors.Hand;
            button_add.FlatAppearance.BorderSize = 0;
            button_add.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_add.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_add.FlatStyle = FlatStyle.Flat;
            button_add.Location = new Point(0, 0);
            button_add.Name = "button_add";
            button_add.Size = new Size(81, 66);
            button_add.TabIndex = 0;
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // label_toMonth
            // 
            label_toMonth.AutoSize = true;
            label_toMonth.BackColor = Color.Transparent;
            label_toMonth.FlatStyle = FlatStyle.Flat;
            label_toMonth.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            label_toMonth.ForeColor = Color.FromArgb(64, 64, 64);
            label_toMonth.Location = new Point(149, 9);
            label_toMonth.Name = "label_toMonth";
            label_toMonth.Size = new Size(20, 23);
            label_toMonth.TabIndex = 1;
            label_toMonth.Text = "0";
            // 
            // pictureBox_Money
            // 
            pictureBox_Money.BackColor = Color.Transparent;
            pictureBox_Money.BackgroundImage = (Image)resources.GetObject("pictureBox_Money.BackgroundImage");
            pictureBox_Money.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_Money.Location = new Point(117, 0);
            pictureBox_Money.Margin = new Padding(0);
            pictureBox_Money.Name = "pictureBox_Money";
            pictureBox_Money.Size = new Size(30, 32);
            pictureBox_Money.TabIndex = 7;
            pictureBox_Money.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(117, 42);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 24);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label_ToDay
            // 
            label_ToDay.AutoSize = true;
            label_ToDay.BackColor = Color.Transparent;
            label_ToDay.FlatStyle = FlatStyle.Flat;
            label_ToDay.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_ToDay.ForeColor = Color.FromArgb(64, 64, 64);
            label_ToDay.Location = new Point(149, 43);
            label_ToDay.Name = "label_ToDay";
            label_ToDay.Size = new Size(20, 23);
            label_ToDay.TabIndex = 9;
            label_ToDay.Text = "0";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Engineer_v_3.0";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick_1;
            // 
            // MiniForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(282, 70);
            Controls.Add(label_ToDay);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox_Money);
            Controls.Add(label_toMonth);
            Controls.Add(button_add);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "MiniForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Engineer_v_3.0 - Мини";
            FormClosing += MiniForm_FormClosing;
            Load += MiniForm_Load;
            Resize += MiniForm_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox_Money).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_add;
        private Label label_toMonth;
        private PictureBox pictureBox_Money;
        private PictureBox pictureBox1;
        private Label label_ToDay;
        private NotifyIcon notifyIcon1;
    }
}