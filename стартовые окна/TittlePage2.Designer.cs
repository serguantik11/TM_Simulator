namespace TM_Simulator
{
    partial class TittlePage2
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
            menu = new Button();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Location = new Point(390, 12);
            menu.MaximumSize = new Size(120, 50);
            menu.MinimumSize = new Size(120, 50);
            menu.Name = "menu";
            menu.Size = new Size(120, 50);
            menu.TabIndex = 0;
            menu.Text = "Меню";
            menu.UseVisualStyleBackColor = true;
            menu.Click += menu_Click;
            // 
            // TittlePage2
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.MainScreen2;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(902, 543);
            Controls.Add(menu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(920, 590);
            MinimumSize = new Size(920, 590);
            Name = "TittlePage2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TittlePage2";
            FormClosing += TittlePage2_FormClosing;
            Click += TittlePage2_Click;
            KeyUp += TittlePage2_KeyUp;
            ResumeLayout(false);
        }

        #endregion

        private Button menu;
    }
}