namespace TM_Simulator
{
    partial class Settings
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
            back = new Button();
            combinesettings = new Button();
            systemsettings2 = new Button();
            terminalsettings = new Button();
            operatingmode = new Button();
            systemsettings = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
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
            back.Text = "назад";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // combinesettings
            // 
            combinesettings.Location = new Point(25, 372);
            combinesettings.MaximumSize = new Size(850, 50);
            combinesettings.MinimumSize = new Size(850, 50);
            combinesettings.Name = "combinesettings";
            combinesettings.Size = new Size(850, 50);
            combinesettings.TabIndex = 1;
            combinesettings.Text = "Настройки комбайна";
            combinesettings.UseVisualStyleBackColor = true;
            combinesettings.Click += combinesettings_Click;
            // 
            // systemsettings2
            // 
            systemsettings2.Location = new Point(25, 319);
            systemsettings2.MaximumSize = new Size(850, 50);
            systemsettings2.MinimumSize = new Size(850, 50);
            systemsettings2.Name = "systemsettings2";
            systemsettings2.Size = new Size(850, 50);
            systemsettings2.TabIndex = 1;
            systemsettings2.Text = "Настройки системы 2";
            systemsettings2.UseVisualStyleBackColor = true;
            // 
            // terminalsettings
            // 
            terminalsettings.Location = new Point(25, 266);
            terminalsettings.MaximumSize = new Size(850, 50);
            terminalsettings.Name = "terminalsettings";
            terminalsettings.Size = new Size(850, 50);
            terminalsettings.TabIndex = 1;
            terminalsettings.Text = "Настройки терминала";
            terminalsettings.UseVisualStyleBackColor = true;
            // 
            // operatingmode
            // 
            operatingmode.Location = new Point(25, 213);
            operatingmode.MaximumSize = new Size(850, 50);
            operatingmode.MinimumSize = new Size(850, 50);
            operatingmode.Name = "operatingmode";
            operatingmode.Size = new Size(850, 50);
            operatingmode.TabIndex = 1;
            operatingmode.Text = "Режим работы";
            operatingmode.UseVisualStyleBackColor = true;
            // 
            // systemsettings
            // 
            systemsettings.Location = new Point(25, 160);
            systemsettings.MaximumSize = new Size(850, 50);
            systemsettings.MinimumSize = new Size(850, 50);
            systemsettings.Name = "systemsettings";
            systemsettings.Size = new Size(850, 50);
            systemsettings.TabIndex = 1;
            systemsettings.Text = "Настройки системы";
            systemsettings.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(717, 3);
            label1.Name = "label1";
            label1.Size = new Size(104, 37);
            label1.TabIndex = 2;
            label1.Text = "время";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(725, 42);
            label2.Name = "label2";
            label2.Size = new Size(51, 28);
            label2.TabIndex = 3;
            label2.Text = "дата";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.menu;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(902, 543);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(systemsettings);
            Controls.Add(operatingmode);
            Controls.Add(terminalsettings);
            Controls.Add(systemsettings2);
            Controls.Add(combinesettings);
            Controls.Add(back);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(920, 590);
            MinimumSize = new Size(920, 590);
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            FormClosing += Settings_FormClosing;
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private Button combinesettings;
        private Button systemsettings2;
        private Button terminalsettings;
        private Button operatingmode;
        private Button systemsettings;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
    }
}