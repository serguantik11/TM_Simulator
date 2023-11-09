namespace TM_Simulator
{
    partial class StatisticData
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
            back = new Button();
            SuspendLayout();
            // 
            // back
            // 
            back.Location = new Point(12, 12);
            back.MaximumSize = new Size(120, 50);
            back.MinimumSize = new Size(120, 50);
            back.Name = "back";
            back.Size = new Size(120, 50);
            back.TabIndex = 0;
            back.Text = "Назад";
            back.UseVisualStyleBackColor = true;
            back.Click += backmenu_Click;
            // 
            // StatisticData
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.statisticdata;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(902, 543);
            Controls.Add(back);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(920, 590);
            MinimumSize = new Size(920, 590);
            Name = "StatisticData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StatisticData";
            FormClosing += StatisticData_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button back;
    }
}