namespace Demo.PanelControl
{
    partial class MapControlPanel
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.trackZoom = new System.Windows.Forms.TrackBar();
            this.btnRelieve = new System.Windows.Forms.Button();
            this.btnOriginal = new System.Windows.Forms.Button();
            this.btnSat = new System.Windows.Forms.Button();
            this.btnRuta = new System.Windows.Forms.Button();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlongitud = new System.Windows.Forms.TextBox();
            this.txtlatitud = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.buttonImagePolygon = new System.Windows.Forms.Button();
            this.dataGridViewPolygons = new Guna.UI2.WinForms.Guna2DataGridView();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxComPort = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPolygons)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Zoom:";
            // 
            // trackZoom
            // 
            this.trackZoom.Location = new System.Drawing.Point(300, 341);
            this.trackZoom.Maximum = 25;
            this.trackZoom.Name = "trackZoom";
            this.trackZoom.Size = new System.Drawing.Size(185, 45);
            this.trackZoom.TabIndex = 33;
            this.trackZoom.ValueChanged += new System.EventHandler(this.trackZoom_ValueChanged);
            // 
            // btnRelieve
            // 
            this.btnRelieve.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRelieve.ForeColor = System.Drawing.Color.White;
            this.btnRelieve.Location = new System.Drawing.Point(178, 352);
            this.btnRelieve.Name = "btnRelieve";
            this.btnRelieve.Size = new System.Drawing.Size(64, 25);
            this.btnRelieve.TabIndex = 32;
            this.btnRelieve.Text = "Рельеф";
            this.btnRelieve.UseVisualStyleBackColor = false;
            this.btnRelieve.Click += new System.EventHandler(this.btnRelieve_Click);
            // 
            // btnOriginal
            // 
            this.btnOriginal.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOriginal.ForeColor = System.Drawing.Color.White;
            this.btnOriginal.Location = new System.Drawing.Point(83, 352);
            this.btnOriginal.Name = "btnOriginal";
            this.btnOriginal.Size = new System.Drawing.Size(89, 25);
            this.btnOriginal.TabIndex = 31;
            this.btnOriginal.Text = "Нормальный";
            this.btnOriginal.UseVisualStyleBackColor = false;
            this.btnOriginal.Click += new System.EventHandler(this.btnOriginal_Click);
            // 
            // btnSat
            // 
            this.btnSat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSat.ForeColor = System.Drawing.Color.White;
            this.btnSat.Location = new System.Drawing.Point(13, 352);
            this.btnSat.Name = "btnSat";
            this.btnSat.Size = new System.Drawing.Size(64, 25);
            this.btnSat.TabIndex = 30;
            this.btnSat.Text = "Спутник";
            this.btnSat.UseVisualStyleBackColor = false;
            this.btnSat.Click += new System.EventHandler(this.btnSat_Click);
            // 
            // btnRuta
            // 
            this.btnRuta.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRuta.ForeColor = System.Drawing.Color.White;
            this.btnRuta.Location = new System.Drawing.Point(465, 194);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(68, 34);
            this.btnRuta.TabIndex = 29;
            this.btnRuta.Text = "Маршрут";
            this.btnRuta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRuta.UseVisualStyleBackColor = false;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // btnPolygon
            // 
            this.btnPolygon.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPolygon.ForeColor = System.Drawing.Color.White;
            this.btnPolygon.Location = new System.Drawing.Point(479, 233);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(63, 33);
            this.btnPolygon.TabIndex = 28;
            this.btnPolygon.Text = "Полигон ";
            this.btnPolygon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPolygon.UseVisualStyleBackColor = false;
            this.btnPolygon.Click += new System.EventHandler(this.btnPolygon_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(549, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(270, 178);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SelecionarRegistro);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Долгота";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Широта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Описание";
            // 
            // txtlongitud
            // 
            this.txtlongitud.Location = new System.Drawing.Point(393, 109);
            this.txtlongitud.Name = "txtlongitud";
            this.txtlongitud.Size = new System.Drawing.Size(200, 20);
            this.txtlongitud.TabIndex = 23;
            // 
            // txtlatitud
            // 
            this.txtlatitud.Location = new System.Drawing.Point(393, 64);
            this.txtlatitud.Name = "txtlatitud";
            this.txtlatitud.Size = new System.Drawing.Size(200, 20);
            this.txtlatitud.TabIndex = 22;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(393, 21);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(200, 20);
            this.txtDescripcion.TabIndex = 21;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(393, 272);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(74, 32);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Удалить\n";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(390, 234);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 32);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Добавить";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(13, 3);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(362, 332);
            this.gMapControl1.TabIndex = 18;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDoubleClick);
            // 
            // buttonImagePolygon
            // 
            this.buttonImagePolygon.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonImagePolygon.ForeColor = System.Drawing.Color.White;
            this.buttonImagePolygon.Location = new System.Drawing.Point(396, 194);
            this.buttonImagePolygon.Name = "buttonImagePolygon";
            this.buttonImagePolygon.Size = new System.Drawing.Size(63, 33);
            this.buttonImagePolygon.TabIndex = 35;
            this.buttonImagePolygon.Text = "Снимок";
            this.buttonImagePolygon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonImagePolygon.UseVisualStyleBackColor = false;
            this.buttonImagePolygon.Click += new System.EventHandler(this.buttonImagePolygon_Click);
            // 
            // dataGridViewPolygons
            // 
            this.dataGridViewPolygons.AllowUserToAddRows = false;
            this.dataGridViewPolygons.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewPolygons.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPolygons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPolygons.ColumnHeadersHeight = 4;
            this.dataGridViewPolygons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPolygons.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPolygons.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewPolygons.Location = new System.Drawing.Point(610, 21);
            this.dataGridViewPolygons.Name = "dataGridViewPolygons";
            this.dataGridViewPolygons.ReadOnly = true;
            this.dataGridViewPolygons.RowHeadersVisible = false;
            this.dataGridViewPolygons.Size = new System.Drawing.Size(209, 164);
            this.dataGridViewPolygons.TabIndex = 36;
            this.dataGridViewPolygons.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewPolygons.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewPolygons.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewPolygons.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewPolygons.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewPolygons.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewPolygons.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewPolygons.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewPolygons.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewPolygons.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewPolygons.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewPolygons.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewPolygons.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridViewPolygons.ThemeStyle.ReadOnly = true;
            this.dataGridViewPolygons.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewPolygons.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewPolygons.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewPolygons.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewPolygons.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridViewPolygons.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewPolygons.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Location = new System.Drawing.Point(393, 145);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(83, 31);
            this.buttonStart.TabIndex = 37;
            this.buttonStart.Text = " Начать";
            this.buttonStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxComPort
            // 
            this.textBoxComPort.Location = new System.Drawing.Point(482, 151);
            this.textBoxComPort.Name = "textBoxComPort";
            this.textBoxComPort.Size = new System.Drawing.Size(77, 20);
            this.textBoxComPort.TabIndex = 38;
            this.textBoxComPort.Text = "COM5";
            // 
            // MapControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxComPort);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.dataGridViewPolygons);
            this.Controls.Add(this.buttonImagePolygon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackZoom);
            this.Controls.Add(this.btnRelieve);
            this.Controls.Add(this.btnOriginal);
            this.Controls.Add(this.btnSat);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.btnPolygon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtlongitud);
            this.Controls.Add(this.txtlatitud);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gMapControl1);
            this.Name = "MapControlPanel";
            this.Size = new System.Drawing.Size(850, 390);
            this.Load += new System.EventHandler(this.MapControlPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPolygons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackZoom;
        private System.Windows.Forms.Button btnRelieve;
        private System.Windows.Forms.Button btnOriginal;
        private System.Windows.Forms.Button btnSat;
        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.Button btnPolygon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlongitud;
        private System.Windows.Forms.TextBox txtlatitud;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button buttonImagePolygon;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewPolygons;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxComPort;
    }
}
