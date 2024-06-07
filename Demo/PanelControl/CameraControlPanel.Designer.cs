namespace Demo.PanelControl
{
    partial class CameraControlPanel
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnReleaseCamera = new System.Windows.Forms.Button();
            this.lbSerialNumber = new System.Windows.Forms.Label();
            this.tbSerialNumber = new System.Windows.Forms.TextBox();
            this.btnSaveSnapshot = new System.Windows.Forms.Button();
            this.btnSnapShot = new System.Windows.Forms.Button();
            this.pbSnapShot = new System.Windows.Forms.PictureBox();
            this.btnStopGrabbing = new System.Windows.Forms.Button();
            this.btnStartGrabbing = new System.Windows.Forms.Button();
            this.btnOpenCamera = new System.Windows.Forms.Button();
            this.cbUseTestImage = new System.Windows.Forms.CheckBox();
            this.lbMessages = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lbFailedImages = new System.Windows.Forms.Label();
            this.lbSuccessfulImages = new System.Windows.Forms.Label();
            this.lbCameraInfo = new System.Windows.Forms.Label();
            this.tbFailedGrabs = new System.Windows.Forms.TextBox();
            this.tbSuccessfulGrabs = new System.Windows.Forms.TextBox();
            this.tbMessages = new System.Windows.Forms.TextBox();
            this.tbCameraInfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSnapShot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(575, 275);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(273, 104);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogo.TabIndex = 56;
            this.pbLogo.TabStop = false;
            // 
            // btnReleaseCamera
            // 
            this.btnReleaseCamera.Enabled = false;
            this.btnReleaseCamera.Location = new System.Drawing.Point(11, 246);
            this.btnReleaseCamera.Margin = new System.Windows.Forms.Padding(2);
            this.btnReleaseCamera.Name = "btnReleaseCamera";
            this.btnReleaseCamera.Size = new System.Drawing.Size(103, 42);
            this.btnReleaseCamera.TabIndex = 55;
            this.btnReleaseCamera.Text = "Освобождение камеры";
            this.btnReleaseCamera.UseVisualStyleBackColor = true;
            this.btnReleaseCamera.Click += new System.EventHandler(this.btnReleaseCamera_Click);
            // 
            // lbSerialNumber
            // 
            this.lbSerialNumber.AutoSize = true;
            this.lbSerialNumber.Location = new System.Drawing.Point(-3, 122);
            this.lbSerialNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSerialNumber.Name = "lbSerialNumber";
            this.lbSerialNumber.Size = new System.Drawing.Size(140, 13);
            this.lbSerialNumber.TabIndex = 54;
            this.lbSerialNumber.Text = "Введите серийный номер:";
            // 
            // tbSerialNumber
            // 
            this.tbSerialNumber.Location = new System.Drawing.Point(11, 150);
            this.tbSerialNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbSerialNumber.MaxLength = 8;
            this.tbSerialNumber.Name = "tbSerialNumber";
            this.tbSerialNumber.Size = new System.Drawing.Size(103, 20);
            this.tbSerialNumber.TabIndex = 53;
            this.tbSerialNumber.Text = "COM2";
            this.tbSerialNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSaveSnapshot
            // 
            this.btnSaveSnapshot.Enabled = false;
            this.btnSaveSnapshot.Location = new System.Drawing.Point(736, 252);
            this.btnSaveSnapshot.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveSnapshot.Name = "btnSaveSnapshot";
            this.btnSaveSnapshot.Size = new System.Drawing.Size(101, 19);
            this.btnSaveSnapshot.TabIndex = 52;
            this.btnSaveSnapshot.Text = "Сохранить снимок";
            this.btnSaveSnapshot.UseVisualStyleBackColor = true;
            this.btnSaveSnapshot.Click += new System.EventHandler(this.btnSaveSnapshot_Click_1);
            // 
            // btnSnapShot
            // 
            this.btnSnapShot.Enabled = false;
            this.btnSnapShot.Location = new System.Drawing.Point(586, 252);
            this.btnSnapShot.Margin = new System.Windows.Forms.Padding(2);
            this.btnSnapShot.Name = "btnSnapShot";
            this.btnSnapShot.Size = new System.Drawing.Size(146, 19);
            this.btnSnapShot.TabIndex = 51;
            this.btnSnapShot.Text = "Сделать снимок";
            this.btnSnapShot.UseVisualStyleBackColor = true;
            this.btnSnapShot.Click += new System.EventHandler(this.btnSnapShot_Click_1);
            // 
            // pbSnapShot
            // 
            this.pbSnapShot.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbSnapShot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSnapShot.Location = new System.Drawing.Point(575, 89);
            this.pbSnapShot.Margin = new System.Windows.Forms.Padding(2);
            this.pbSnapShot.Name = "pbSnapShot";
            this.pbSnapShot.Size = new System.Drawing.Size(273, 159);
            this.pbSnapShot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSnapShot.TabIndex = 50;
            this.pbSnapShot.TabStop = false;
            // 
            // btnStopGrabbing
            // 
            this.btnStopGrabbing.Enabled = false;
            this.btnStopGrabbing.Location = new System.Drawing.Point(11, 223);
            this.btnStopGrabbing.Margin = new System.Windows.Forms.Padding(2);
            this.btnStopGrabbing.Name = "btnStopGrabbing";
            this.btnStopGrabbing.Size = new System.Drawing.Size(102, 19);
            this.btnStopGrabbing.TabIndex = 49;
            this.btnStopGrabbing.Text = "Stop";
            this.btnStopGrabbing.UseVisualStyleBackColor = true;
            this.btnStopGrabbing.Click += new System.EventHandler(this.btnStopGrabbing_Click);
            // 
            // btnStartGrabbing
            // 
            this.btnStartGrabbing.Enabled = false;
            this.btnStartGrabbing.Location = new System.Drawing.Point(11, 200);
            this.btnStartGrabbing.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartGrabbing.Name = "btnStartGrabbing";
            this.btnStartGrabbing.Size = new System.Drawing.Size(102, 19);
            this.btnStartGrabbing.TabIndex = 48;
            this.btnStartGrabbing.Text = "Start";
            this.btnStartGrabbing.UseVisualStyleBackColor = true;
            this.btnStartGrabbing.Click += new System.EventHandler(this.btnStartGrabbing_Click);
            // 
            // btnOpenCamera
            // 
            this.btnOpenCamera.Location = new System.Drawing.Point(11, 176);
            this.btnOpenCamera.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenCamera.Name = "btnOpenCamera";
            this.btnOpenCamera.Size = new System.Drawing.Size(102, 19);
            this.btnOpenCamera.TabIndex = 47;
            this.btnOpenCamera.Text = "Подключиться";
            this.btnOpenCamera.UseVisualStyleBackColor = true;
            this.btnOpenCamera.Click += new System.EventHandler(this.btnOpenCamera_Click);
            // 
            // cbUseTestImage
            // 
            this.cbUseTestImage.AutoSize = true;
            this.cbUseTestImage.Checked = true;
            this.cbUseTestImage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUseTestImage.Location = new System.Drawing.Point(11, 370);
            this.cbUseTestImage.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbUseTestImage.Name = "cbUseTestImage";
            this.cbUseTestImage.Size = new System.Drawing.Size(231, 17);
            this.cbUseTestImage.TabIndex = 46;
            this.cbUseTestImage.Text = "Использование тестового изображения";
            this.cbUseTestImage.UseVisualStyleBackColor = true;
            // 
            // lbMessages
            // 
            this.lbMessages.AutoSize = true;
            this.lbMessages.Location = new System.Drawing.Point(305, 5);
            this.lbMessages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(123, 13);
            this.lbMessages.TabIndex = 45;
            this.lbMessages.Text = "Последнее сообщение";
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(141, 89);
            this.pbImage.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(420, 279);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 43;
            this.pbImage.TabStop = false;
            // 
            // lbFailedImages
            // 
            this.lbFailedImages.AutoSize = true;
            this.lbFailedImages.Location = new System.Drawing.Point(3, 323);
            this.lbFailedImages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFailedImages.Name = "lbFailedImages";
            this.lbFailedImages.Size = new System.Drawing.Size(134, 13);
            this.lbFailedImages.TabIndex = 42;
            this.lbFailedImages.Text = "Неудачные изображения";
            // 
            // lbSuccessfulImages
            // 
            this.lbSuccessfulImages.AutoSize = true;
            this.lbSuccessfulImages.Location = new System.Drawing.Point(11, 290);
            this.lbSuccessfulImages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSuccessfulImages.Name = "lbSuccessfulImages";
            this.lbSuccessfulImages.Size = new System.Drawing.Size(93, 13);
            this.lbSuccessfulImages.TabIndex = 41;
            this.lbSuccessfulImages.Text = "Удачные образы";
            // 
            // lbCameraInfo
            // 
            this.lbCameraInfo.AutoSize = true;
            this.lbCameraInfo.Location = new System.Drawing.Point(11, 5);
            this.lbCameraInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCameraInfo.Name = "lbCameraInfo";
            this.lbCameraInfo.Size = new System.Drawing.Size(123, 13);
            this.lbCameraInfo.TabIndex = 40;
            this.lbCameraInfo.Text = "Информация о камере";
            // 
            // tbFailedGrabs
            // 
            this.tbFailedGrabs.Location = new System.Drawing.Point(11, 337);
            this.tbFailedGrabs.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbFailedGrabs.Name = "tbFailedGrabs";
            this.tbFailedGrabs.ReadOnly = true;
            this.tbFailedGrabs.Size = new System.Drawing.Size(103, 20);
            this.tbFailedGrabs.TabIndex = 39;
            this.tbFailedGrabs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSuccessfulGrabs
            // 
            this.tbSuccessfulGrabs.Location = new System.Drawing.Point(11, 304);
            this.tbSuccessfulGrabs.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbSuccessfulGrabs.Name = "tbSuccessfulGrabs";
            this.tbSuccessfulGrabs.ReadOnly = true;
            this.tbSuccessfulGrabs.Size = new System.Drawing.Size(103, 20);
            this.tbSuccessfulGrabs.TabIndex = 38;
            this.tbSuccessfulGrabs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbMessages
            // 
            this.tbMessages.Location = new System.Drawing.Point(305, 20);
            this.tbMessages.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbMessages.Multiline = true;
            this.tbMessages.Name = "tbMessages";
            this.tbMessages.ReadOnly = true;
            this.tbMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMessages.Size = new System.Drawing.Size(543, 60);
            this.tbMessages.TabIndex = 37;
            this.tbMessages.Text = "Connect";
            // 
            // tbCameraInfo
            // 
            this.tbCameraInfo.Location = new System.Drawing.Point(11, 20);
            this.tbCameraInfo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbCameraInfo.Multiline = true;
            this.tbCameraInfo.Name = "tbCameraInfo";
            this.tbCameraInfo.ReadOnly = true;
            this.tbCameraInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCameraInfo.Size = new System.Drawing.Size(290, 60);
            this.tbCameraInfo.TabIndex = 44;
            this.tbCameraInfo.Text = "Не известно";
            // 
            // CameraControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnReleaseCamera);
            this.Controls.Add(this.lbSerialNumber);
            this.Controls.Add(this.tbSerialNumber);
            this.Controls.Add(this.btnSaveSnapshot);
            this.Controls.Add(this.btnSnapShot);
            this.Controls.Add(this.pbSnapShot);
            this.Controls.Add(this.btnStopGrabbing);
            this.Controls.Add(this.btnStartGrabbing);
            this.Controls.Add(this.btnOpenCamera);
            this.Controls.Add(this.cbUseTestImage);
            this.Controls.Add(this.lbMessages);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.lbFailedImages);
            this.Controls.Add(this.lbSuccessfulImages);
            this.Controls.Add(this.lbCameraInfo);
            this.Controls.Add(this.tbFailedGrabs);
            this.Controls.Add(this.tbSuccessfulGrabs);
            this.Controls.Add(this.tbMessages);
            this.Controls.Add(this.tbCameraInfo);
            this.Name = "CameraControlPanel";
            this.Size = new System.Drawing.Size(850, 390);
            this.Load += new System.EventHandler(this.CameraControlPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSnapShot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnReleaseCamera;
        private System.Windows.Forms.Label lbSerialNumber;
        private System.Windows.Forms.TextBox tbSerialNumber;
        private System.Windows.Forms.Button btnSaveSnapshot;
        private System.Windows.Forms.Button btnSnapShot;
        private System.Windows.Forms.PictureBox pbSnapShot;
        private System.Windows.Forms.Button btnStopGrabbing;
        private System.Windows.Forms.Button btnStartGrabbing;
        private System.Windows.Forms.Button btnOpenCamera;
        private System.Windows.Forms.CheckBox cbUseTestImage;
        private System.Windows.Forms.Label lbMessages;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lbFailedImages;
        private System.Windows.Forms.Label lbSuccessfulImages;
        private System.Windows.Forms.Label lbCameraInfo;
        private System.Windows.Forms.TextBox tbFailedGrabs;
        private System.Windows.Forms.TextBox tbSuccessfulGrabs;
        private System.Windows.Forms.TextBox tbMessages;
        private System.Windows.Forms.TextBox tbCameraInfo;
    }
}
