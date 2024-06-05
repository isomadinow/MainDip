namespace Demo
{
    partial class DemoForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.exitButton = new Guna.UI2.WinForms.Guna2Button();
            this.labelMain = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.CameraRadioButtton = new Guna.UI2.WinForms.Guna2Button();
            this.RadarRadioButton = new Guna.UI2.WinForms.Guna2Button();
            this.GNSSRadioButton = new Guna.UI2.WinForms.Guna2Button();
            this.LidarRadioButton = new Guna.UI2.WinForms.Guna2Button();
            this.MainRadiobutton = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelTop.Controls.Add(this.guna2Button1);
            this.panelTop.Controls.Add(this.exitButton);
            this.panelTop.Controls.Add(this.labelMain);
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(850, 54);
            this.panelTop.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Black;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(766, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(50, 21);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "–";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitButton.FillColor = System.Drawing.Color.Black;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(812, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(38, 21);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "X";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMain.ForeColor = System.Drawing.Color.White;
            this.labelMain.Location = new System.Drawing.Point(88, 9);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(134, 25);
            this.labelMain.TabIndex = 1;
            this.labelMain.Text = "Precep App";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.CameraRadioButtton);
            this.panelMain.Controls.Add(this.RadarRadioButton);
            this.panelMain.Controls.Add(this.GNSSRadioButton);
            this.panelMain.Controls.Add(this.LidarRadioButton);
            this.panelMain.Controls.Add(this.MainRadiobutton);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMain.Location = new System.Drawing.Point(0, 54);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(850, 56);
            this.panelMain.TabIndex = 1;
            // 
            // CameraRadioButtton
            // 
            this.CameraRadioButtton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.CameraRadioButtton.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.CameraRadioButtton.CheckedState.FillColor = System.Drawing.Color.White;
            this.CameraRadioButtton.CustomBorderColor = System.Drawing.Color.White;
            this.CameraRadioButtton.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.CameraRadioButtton.DisabledState.FillColor = System.Drawing.Color.White;
            this.CameraRadioButtton.FillColor = System.Drawing.Color.White;
            this.CameraRadioButtton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CameraRadioButtton.ForeColor = System.Drawing.Color.Black;
            this.CameraRadioButtton.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.CameraRadioButtton.Location = new System.Drawing.Point(234, 11);
            this.CameraRadioButtton.Name = "CameraRadioButtton";
            this.CameraRadioButtton.Size = new System.Drawing.Size(89, 45);
            this.CameraRadioButtton.TabIndex = 5;
            this.CameraRadioButtton.Text = "Камеры";
            this.CameraRadioButtton.Click += new System.EventHandler(this.CameraRadioButtton_Click);
            // 
            // RadarRadioButton
            // 
            this.RadarRadioButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.RadarRadioButton.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.RadarRadioButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.RadarRadioButton.CustomBorderColor = System.Drawing.Color.White;
            this.RadarRadioButton.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.RadarRadioButton.DisabledState.FillColor = System.Drawing.Color.White;
            this.RadarRadioButton.FillColor = System.Drawing.Color.White;
            this.RadarRadioButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadarRadioButton.ForeColor = System.Drawing.Color.Black;
            this.RadarRadioButton.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.RadarRadioButton.Location = new System.Drawing.Point(452, 11);
            this.RadarRadioButton.Name = "RadarRadioButton";
            this.RadarRadioButton.Size = new System.Drawing.Size(89, 45);
            this.RadarRadioButton.TabIndex = 4;
            this.RadarRadioButton.Text = "Радар";
            this.RadarRadioButton.Click += new System.EventHandler(this.RadarRadioButton_Click);
            // 
            // GNSSRadioButton
            // 
            this.GNSSRadioButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.GNSSRadioButton.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.GNSSRadioButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.GNSSRadioButton.CustomBorderColor = System.Drawing.Color.White;
            this.GNSSRadioButton.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.GNSSRadioButton.DisabledState.FillColor = System.Drawing.Color.White;
            this.GNSSRadioButton.FillColor = System.Drawing.Color.White;
            this.GNSSRadioButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GNSSRadioButton.ForeColor = System.Drawing.Color.Black;
            this.GNSSRadioButton.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.GNSSRadioButton.Location = new System.Drawing.Point(346, 11);
            this.GNSSRadioButton.Name = "GNSSRadioButton";
            this.GNSSRadioButton.Size = new System.Drawing.Size(89, 45);
            this.GNSSRadioButton.TabIndex = 3;
            this.GNSSRadioButton.Text = "Карта";
            this.GNSSRadioButton.Click += new System.EventHandler(this.GNSSRadioButton_Click);
            // 
            // LidarRadioButton
            // 
            this.LidarRadioButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.LidarRadioButton.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.LidarRadioButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.LidarRadioButton.CustomBorderColor = System.Drawing.Color.White;
            this.LidarRadioButton.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.LidarRadioButton.DisabledState.FillColor = System.Drawing.Color.White;
            this.LidarRadioButton.FillColor = System.Drawing.Color.White;
            this.LidarRadioButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LidarRadioButton.ForeColor = System.Drawing.Color.Black;
            this.LidarRadioButton.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.LidarRadioButton.Location = new System.Drawing.Point(115, 11);
            this.LidarRadioButton.Name = "LidarRadioButton";
            this.LidarRadioButton.Size = new System.Drawing.Size(97, 45);
            this.LidarRadioButton.TabIndex = 1;
            this.LidarRadioButton.Text = "Лидар RP";
            this.LidarRadioButton.Click += new System.EventHandler(this.LidarRadioButton_Click);
            // 
            // MainRadiobutton
            // 
            this.MainRadiobutton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.MainRadiobutton.Checked = true;
            this.MainRadiobutton.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.MainRadiobutton.CheckedState.FillColor = System.Drawing.Color.White;
            this.MainRadiobutton.CustomBorderColor = System.Drawing.Color.White;
            this.MainRadiobutton.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.MainRadiobutton.DisabledState.FillColor = System.Drawing.Color.White;
            this.MainRadiobutton.FillColor = System.Drawing.Color.White;
            this.MainRadiobutton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainRadiobutton.ForeColor = System.Drawing.Color.Black;
            this.MainRadiobutton.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.MainRadiobutton.Location = new System.Drawing.Point(3, 11);
            this.MainRadiobutton.Name = "MainRadiobutton";
            this.MainRadiobutton.Size = new System.Drawing.Size(89, 45);
            this.MainRadiobutton.TabIndex = 0;
            this.MainRadiobutton.Text = "Главное";
            this.MainRadiobutton.Click += new System.EventHandler(this.MainRadiobutton_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 110);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(850, 390);
            this.panelContainer.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DemoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelMain;
        private Guna.UI2.WinForms.Guna2Button MainRadiobutton;
        private Guna.UI2.WinForms.Guna2Button CameraRadioButtton;
        private Guna.UI2.WinForms.Guna2Button RadarRadioButton;
        private Guna.UI2.WinForms.Guna2Button GNSSRadioButton;
        private Guna.UI2.WinForms.Guna2Button LidarRadioButton;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button exitButton;
    }
}

