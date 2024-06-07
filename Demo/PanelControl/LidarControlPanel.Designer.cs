namespace Demo.PanelControl
{
    partial class LidarControlPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackDisplayRange = new System.Windows.Forms.TrackBar();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.labelPPS = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.comboPort = new System.Windows.Forms.ToolStripComboBox();
            this.comboMode = new System.Windows.Forms.ToolStripComboBox();
            this.buttonIsFlipped = new System.Windows.Forms.ToolStripLabel();
            this.comboIsFlipped = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.textAngleOffset = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonStart = new System.Windows.Forms.ToolStripButton();
            this.buttonStop = new System.Windows.Forms.ToolStripButton();
            this.labelSPC = new System.Windows.Forms.ToolStripStatusLabel();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackDisplayRange)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Зум:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trackDisplayRange);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(806, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(44, 240);
            this.panel1.TabIndex = 18;
            // 
            // trackDisplayRange
            // 
            this.trackDisplayRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackDisplayRange.Location = new System.Drawing.Point(0, 13);
            this.trackDisplayRange.Maximum = 50;
            this.trackDisplayRange.Minimum = 1;
            this.trackDisplayRange.Name = "trackDisplayRange";
            this.trackDisplayRange.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackDisplayRange.Size = new System.Drawing.Size(44, 227);
            this.trackDisplayRange.TabIndex = 6;
            this.trackDisplayRange.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackDisplayRange.Value = 1;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(38, 20);
            this.toolStripLabel1.Text = "Порт:";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(48, 20);
            this.toolStripLabel2.Text = "Режим:";
            // 
            // labelPPS
            // 
            this.labelPPS.AutoSize = false;
            this.labelPPS.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.labelPPS.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.labelPPS.Name = "labelPPS";
            this.labelPPS.Size = new System.Drawing.Size(50, 17);
            this.labelPPS.Text = "-";
            this.labelPPS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.comboPort,
            this.toolStripLabel2,
            this.comboMode,
            this.buttonIsFlipped,
            this.comboIsFlipped,
            this.toolStripLabel3,
            this.textAngleOffset,
            this.toolStripSeparator1,
            this.buttonStart,
            this.buttonStop});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(2);
            this.toolStrip1.Size = new System.Drawing.Size(850, 27);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // comboPort
            // 
            this.comboPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPort.Name = "comboPort";
            this.comboPort.Size = new System.Drawing.Size(80, 23);
            // 
            // comboMode
            // 
            this.comboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMode.Name = "comboMode";
            this.comboMode.Size = new System.Drawing.Size(131, 23);
            // 
            // buttonIsFlipped
            // 
            this.buttonIsFlipped.Name = "buttonIsFlipped";
            this.buttonIsFlipped.Size = new System.Drawing.Size(79, 20);
            this.buttonIsFlipped.Text = "Отзеркалить:";
            // 
            // comboIsFlipped
            // 
            this.comboIsFlipped.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIsFlipped.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.comboIsFlipped.Name = "comboIsFlipped";
            this.comboIsFlipped.Size = new System.Drawing.Size(75, 23);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(97, 20);
            this.toolStripLabel3.Text = "Смещение угла:";
            // 
            // textAngleOffset
            // 
            this.textAngleOffset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textAngleOffset.Name = "textAngleOffset";
            this.textAngleOffset.Size = new System.Drawing.Size(50, 23);
            this.textAngleOffset.Text = "0";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // buttonStart
            // 
            this.buttonStart.Enabled = false;
            this.buttonStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(35, 20);
            this.buttonStart.Text = "&Start";
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(35, 20);
            this.buttonStop.Text = "Sto&p";
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelSPC
            // 
            this.labelSPC.AutoSize = false;
            this.labelSPC.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.labelSPC.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.labelSPC.Name = "labelSPC";
            this.labelSPC.Size = new System.Drawing.Size(50, 17);
            this.labelSPC.Text = "-";
            this.labelSPC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logBox
            // 
            this.logBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logBox.Location = new System.Drawing.Point(0, 267);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(850, 96);
            this.logBox.TabIndex = 19;
            this.logBox.Text = "";
            this.logBox.TextChanged += new System.EventHandler(this.logBox_TextChanged);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(166, 17);
            this.toolStripStatusLabel2.Text = "Сканирований в секунду:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.labelSPC,
            this.toolStripStatusLabel3,
            this.labelPPS});
            this.statusStrip1.Location = new System.Drawing.Point(0, 363);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(850, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(160, 17);
            this.toolStripStatusLabel3.Text = "Облака точек в секунду:";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 385);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(850, 5);
            this.splitter1.TabIndex = 16;
            this.splitter1.TabStop = false;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(850, 390);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 15;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click_1);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(714, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(69, 24);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // LidarControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pictureBox);
            this.Name = "LidarControlPanel";
            this.Size = new System.Drawing.Size(850, 390);
            this.Load += new System.EventHandler(this.LidarControlPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackDisplayRange)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackDisplayRange;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripStatusLabel labelPPS;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox comboPort;
        private System.Windows.Forms.ToolStripComboBox comboMode;
        private System.Windows.Forms.ToolStripLabel buttonIsFlipped;
        private System.Windows.Forms.ToolStripComboBox comboIsFlipped;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox textAngleOffset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton buttonStart;
        private System.Windows.Forms.ToolStripButton buttonStop;
        private System.Windows.Forms.ToolStripStatusLabel labelSPC;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonSave;
    }
}
