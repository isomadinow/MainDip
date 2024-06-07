namespace Demo.PanelControl
{
    partial class AnalyticControlPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.guna2ButtonLoad = new Guna.UI2.WinForms.Guna2Button();
            this.radarRadioButton = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.labelRadarRadioButton = new System.Windows.Forms.Label();
            this.lidarRadioButton = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.mapRadioButton = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameFileTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBrowse = new Guna.UI2.WinForms.Guna2Button();
            this.dgvData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.buttonProcessing = new Guna.UI2.WinForms.Guna2Button();
            this.buttonSaveToDBase = new Guna.UI2.WinForms.Guna2Button();
            this.mapPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.reportTextBox = new System.Windows.Forms.TextBox();
            this.dgVMap = new Guna.UI2.WinForms.Guna2DataGridView();
            this.buttonMapView = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVMap)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // guna2ButtonLoad
            // 
            this.guna2ButtonLoad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonLoad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonLoad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonLoad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonLoad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonLoad.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonLoad.Location = new System.Drawing.Point(122, 101);
            this.guna2ButtonLoad.Name = "guna2ButtonLoad";
            this.guna2ButtonLoad.Size = new System.Drawing.Size(118, 31);
            this.guna2ButtonLoad.TabIndex = 0;
            this.guna2ButtonLoad.Text = "Загрузить";
            this.guna2ButtonLoad.Click += new System.EventHandler(this.guna2ButtonLoad_Click);
            // 
            // radarRadioButton
            // 
            this.radarRadioButton.Checked = true;
            this.radarRadioButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radarRadioButton.CheckedState.BorderThickness = 0;
            this.radarRadioButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radarRadioButton.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radarRadioButton.Location = new System.Drawing.Point(26, 78);
            this.radarRadioButton.Name = "radarRadioButton";
            this.radarRadioButton.Size = new System.Drawing.Size(20, 20);
            this.radarRadioButton.TabIndex = 3;
            this.radarRadioButton.Text = "guna2CustomRadioButton1";
            this.radarRadioButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radarRadioButton.UncheckedState.BorderThickness = 2;
            this.radarRadioButton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radarRadioButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radarRadioButton.CheckedChanged += new System.EventHandler(this.radarRadioButton_CheckedChanged);
            // 
            // labelRadarRadioButton
            // 
            this.labelRadarRadioButton.AutoSize = true;
            this.labelRadarRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRadarRadioButton.Location = new System.Drawing.Point(52, 78);
            this.labelRadarRadioButton.Name = "labelRadarRadioButton";
            this.labelRadarRadioButton.Size = new System.Drawing.Size(57, 20);
            this.labelRadarRadioButton.TabIndex = 4;
            this.labelRadarRadioButton.Text = "Радар";
            // 
            // lidarRadioButton
            // 
            this.lidarRadioButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lidarRadioButton.CheckedState.BorderThickness = 0;
            this.lidarRadioButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lidarRadioButton.CheckedState.InnerColor = System.Drawing.Color.White;
            this.lidarRadioButton.Location = new System.Drawing.Point(26, 118);
            this.lidarRadioButton.Name = "lidarRadioButton";
            this.lidarRadioButton.Size = new System.Drawing.Size(20, 20);
            this.lidarRadioButton.TabIndex = 6;
            this.lidarRadioButton.Text = "guna2CustomRadioButton2";
            this.lidarRadioButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lidarRadioButton.UncheckedState.BorderThickness = 2;
            this.lidarRadioButton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.lidarRadioButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.lidarRadioButton.CheckedChanged += new System.EventHandler(this.lidarRadioButton_CheckedChanged);
            // 
            // mapRadioButton
            // 
            this.mapRadioButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mapRadioButton.CheckedState.BorderThickness = 0;
            this.mapRadioButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mapRadioButton.CheckedState.InnerColor = System.Drawing.Color.White;
            this.mapRadioButton.Location = new System.Drawing.Point(26, 162);
            this.mapRadioButton.Name = "mapRadioButton";
            this.mapRadioButton.Size = new System.Drawing.Size(20, 20);
            this.mapRadioButton.TabIndex = 7;
            this.mapRadioButton.Text = "guna2CustomRadioButton3";
            this.mapRadioButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.mapRadioButton.UncheckedState.BorderThickness = 2;
            this.mapRadioButton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.mapRadioButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.mapRadioButton.CheckedChanged += new System.EventHandler(this.mapRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(52, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Лидар";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(52, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Карта";
            // 
            // nameFileTextBox
            // 
            this.nameFileTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameFileTextBox.DefaultText = "";
            this.nameFileTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameFileTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameFileTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameFileTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameFileTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameFileTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameFileTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameFileTextBox.Location = new System.Drawing.Point(16, 26);
            this.nameFileTextBox.Name = "nameFileTextBox";
            this.nameFileTextBox.PasswordChar = '\0';
            this.nameFileTextBox.PlaceholderText = "";
            this.nameFileTextBox.SelectedText = "";
            this.nameFileTextBox.Size = new System.Drawing.Size(440, 32);
            this.nameFileTextBox.TabIndex = 10;
            // 
            // btnBrowse
            // 
            this.btnBrowse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBrowse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(122, 64);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(118, 31);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "Выбрать файл";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.ColumnHeadersHeight = 15;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvData.Location = new System.Drawing.Point(246, 78);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.Size = new System.Drawing.Size(219, 226);
            this.dgvData.TabIndex = 12;
            this.dgvData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvData.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvData.ThemeStyle.HeaderStyle.Height = 15;
            this.dgvData.ThemeStyle.ReadOnly = true;
            this.dgvData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvData.ThemeStyle.RowsStyle.Height = 22;
            this.dgvData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // buttonProcessing
            // 
            this.buttonProcessing.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonProcessing.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonProcessing.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonProcessing.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonProcessing.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonProcessing.ForeColor = System.Drawing.Color.White;
            this.buttonProcessing.Location = new System.Drawing.Point(122, 138);
            this.buttonProcessing.Name = "buttonProcessing";
            this.buttonProcessing.Size = new System.Drawing.Size(118, 31);
            this.buttonProcessing.TabIndex = 13;
            this.buttonProcessing.Text = "Обработка";
            this.buttonProcessing.Click += new System.EventHandler(this.buttonProcessing_Click);
            // 
            // buttonSaveToDBase
            // 
            this.buttonSaveToDBase.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSaveToDBase.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSaveToDBase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSaveToDBase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSaveToDBase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSaveToDBase.ForeColor = System.Drawing.Color.White;
            this.buttonSaveToDBase.Location = new System.Drawing.Point(16, 356);
            this.buttonSaveToDBase.Name = "buttonSaveToDBase";
            this.buttonSaveToDBase.Size = new System.Drawing.Size(121, 31);
            this.buttonSaveToDBase.TabIndex = 15;
            this.buttonSaveToDBase.Text = "Сохранить отчёт";
            this.buttonSaveToDBase.Click += new System.EventHandler(this.buttonSaveToDBase_Click);
            // 
            // mapPictureBox
            // 
            this.mapPictureBox.ImageRotate = 0F;
            this.mapPictureBox.Location = new System.Drawing.Point(246, 78);
            this.mapPictureBox.Name = "mapPictureBox";
            this.mapPictureBox.Size = new System.Drawing.Size(269, 226);
            this.mapPictureBox.TabIndex = 16;
            this.mapPictureBox.TabStop = false;
            this.mapPictureBox.Visible = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(521, 78);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(326, 226);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // reportTextBox
            // 
            this.reportTextBox.Location = new System.Drawing.Point(16, 212);
            this.reportTextBox.Multiline = true;
            this.reportTextBox.Name = "reportTextBox";
            this.reportTextBox.Size = new System.Drawing.Size(214, 138);
            this.reportTextBox.TabIndex = 18;
            // 
            // dgVMap
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgVMap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVMap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgVMap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgVMap.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgVMap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgVMap.Location = new System.Drawing.Point(246, 320);
            this.dgVMap.Name = "dgVMap";
            this.dgVMap.RowHeadersVisible = false;
            this.dgVMap.Size = new System.Drawing.Size(273, 50);
            this.dgVMap.TabIndex = 19;
            this.dgVMap.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgVMap.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgVMap.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgVMap.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgVMap.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgVMap.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgVMap.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgVMap.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgVMap.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgVMap.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgVMap.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgVMap.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVMap.ThemeStyle.HeaderStyle.Height = 4;
            this.dgVMap.ThemeStyle.ReadOnly = false;
            this.dgVMap.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgVMap.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgVMap.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgVMap.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgVMap.ThemeStyle.RowsStyle.Height = 22;
            this.dgVMap.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgVMap.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgVMap.SelectionChanged += new System.EventHandler(this.dgVMap_SelectionChanged);
            // 
            // buttonMapView
            // 
            this.buttonMapView.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonMapView.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonMapView.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonMapView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonMapView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonMapView.ForeColor = System.Drawing.Color.White;
            this.buttonMapView.Location = new System.Drawing.Point(541, 339);
            this.buttonMapView.Name = "buttonMapView";
            this.buttonMapView.Size = new System.Drawing.Size(118, 31);
            this.buttonMapView.TabIndex = 20;
            this.buttonMapView.Text = "Показать карту";
            this.buttonMapView.Click += new System.EventHandler(this.buttonMapView_Click);
            // 
            // AnalyticControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonMapView);
            this.Controls.Add(this.dgVMap);
            this.Controls.Add(this.reportTextBox);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.mapPictureBox);
            this.Controls.Add(this.buttonSaveToDBase);
            this.Controls.Add(this.buttonProcessing);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.nameFileTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mapRadioButton);
            this.Controls.Add(this.lidarRadioButton);
            this.Controls.Add(this.labelRadarRadioButton);
            this.Controls.Add(this.radarRadioButton);
            this.Controls.Add(this.guna2ButtonLoad);
            this.Name = "AnalyticControlPanel";
            this.Size = new System.Drawing.Size(850, 390);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonLoad;
        private Guna.UI2.WinForms.Guna2CustomRadioButton radarRadioButton;
        private System.Windows.Forms.Label labelRadarRadioButton;
        private Guna.UI2.WinForms.Guna2CustomRadioButton lidarRadioButton;
        private Guna.UI2.WinForms.Guna2CustomRadioButton mapRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox nameFileTextBox;
        private Guna.UI2.WinForms.Guna2Button btnBrowse;
        private Guna.UI2.WinForms.Guna2DataGridView dgvData;
        private Guna.UI2.WinForms.Guna2Button buttonProcessing;
        private Guna.UI2.WinForms.Guna2Button buttonSaveToDBase;
        private Guna.UI2.WinForms.Guna2PictureBox mapPictureBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox reportTextBox;
        private Guna.UI2.WinForms.Guna2DataGridView dgVMap;
        private Guna.UI2.WinForms.Guna2Button buttonMapView;
    }
}
