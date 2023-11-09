namespace TM_Simulator
{
    partial class TittlePage
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
            menu = new Button();
            tittletimer = new System.Windows.Forms.Timer(components);
            time = new Label();
            date = new Label();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Location = new Point(390, 12);
            menu.Name = "menu";
            menu.Size = new Size(120, 50);
            menu.TabIndex = 1;
            menu.Text = "меню";
            menu.UseVisualStyleBackColor = true;
            menu.Click += menu_Click;
            // 
            // tittletimer
            // 
            tittletimer.Enabled = true;
            tittletimer.Tick += timer1_Tick;
            // 
            // time
            // 
            time.AutoSize = true;
            time.BackColor = Color.Transparent;
            time.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            time.Location = new Point(755, -5);
            time.Name = "time";
            time.Size = new Size(136, 50);
            time.TabIndex = 2;
            time.Text = "время";
            // 
            // date
            // 
            date.AutoSize = true;
            date.BackColor = Color.Transparent;
            date.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            date.Location = new Point(750, 40);
            date.Name = "date";
            date.Size = new Size(62, 31);
            date.TabIndex = 3;
            date.Text = "дата";
            // 
            // TittlePage
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.MainScreen;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(902, 543);
            Controls.Add(time);
            Controls.Add(date);
            Controls.Add(menu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(920, 590);
            MinimumSize = new Size(920, 590);
            Name = "TittlePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            FormClosing += Form2_FormClosing;
            Click += TittlePage_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button menu;
        private Label time;
        private Label date;
        public System.Windows.Forms.Timer tittletimer;
    }
}