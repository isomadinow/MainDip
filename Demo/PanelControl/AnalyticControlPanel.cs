using Demo.bd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Demo.PanelControl
{
    public partial class AnalyticControlPanel : UserControl
    {
        private MyDbContext dbContext;
        public AnalyticControlPanel()
        {
            InitializeComponent();
            radarRadioButton.Checked = true;
            dbContext = new MyDbContext(DemoForm.connectionString);
            dgVMap.SelectionChanged += dgVMap_SelectionChanged;
            buttonMapView.Click += buttonMapView_Click;
        }

        private void guna2ButtonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (radarRadioButton.Checked == true)
                {

                    dgvData.DataSource = radarLoadCSV(nameFileTextBox.Text);
                    // Очистка графика перед добавлением новых данных
                    chart1.Series.Clear();
                    // Создание новой серии для данных радара
                    Series series = new Series("Radar Data");
                    series.ChartType = SeriesChartType.Spline; // или любой другой тип графика, который вы хотите использовать
                                                              // Добавление точек из dgvData
                    foreach (DataGridViewRow row in dgvData.Rows)
                    {
                        double x = Convert.ToDouble(row.Cells["X"].Value);
                        double y = Convert.ToDouble(row.Cells["Y"].Value);
                        series.Points.AddXY(x, y);
                    }
                    // Добавление серии в график
                    chart1.Series.Add(series);
                }
                else if (lidarRadioButton.Checked == true)
                {

 
                    dgvData.DataSource = lidarLoadCSV(nameFileTextBox.Text);
                    chart1.Series.Clear();
                    Series series = new Series("Lidar Data");
                    series.ChartType = SeriesChartType.Spline; 
                    foreach (DataGridViewRow row in dgvData.Rows)

                    {
                
                        double x = Convert.ToDouble(row.Cells["X"].Value);
                        
                        double y = Convert.ToDouble(row.Cells["Y"].Value);
                        series.Points.AddXY(x, y);
                    }
                    // Добавление серии в график
                    chart1.Series.Add(series);
                }
                else if (mapRadioButton.Checked == true)
                {

                    dgvData.DataSource = gnssLoadCsv(nameFileTextBox.Text);
                    chart1.Series.Clear();
                    Series series = new Series("Map Data");
                    series.ChartType = SeriesChartType.Spline; // или любой другой тип графика, который вы хотите использовать
                                                               // Добавление точек из dgvData
                    foreach (DataGridViewRow row in dgvData.Rows)
                    {
                      
                        double x = Convert.ToDouble(row.Cells["Altitude"].Value);
                        double y = Convert.ToDouble(row.Cells["Longitude"].Value);
                        series.Points.AddXY(x, y);
                    }
                    // Добавление серии в график
                    chart1.Series.Add(series);
                }
            } catch {
                MessageBox.Show("Ошибка формата данных!!");
            }
        }
        public List<ViewAnalyticRadar> radarLoadCSV(string filename)
        {

          
                var query = from l in File.ReadAllLines(filename)
                            let data = l.Split(',')
                            select new ViewAnalyticRadar
                            {
                                X = int.Parse(data[0]),
                                Y = int.Parse(data[1])
                            };
            return query.ToList();
            
         
        }
        public List<ViewAnalyticGNSS> gnssLoadCsv(string filename)
        {
           
                var query = from l in File.ReadAllLines(filename)
                            let data = l.Split(',')
                            select new ViewAnalyticGNSS
                            {
                                Altitude = double.Parse(data[0]),
                                Longitude = double.Parse(data[1])
                            };
                return query.ToList();
           
        }

        public List<ViewAnalyticLidar> lidarLoadCSV(string filename)
        {


            var query = from l in File.ReadAllLines(filename)
                        let data = l.Split(',')
                        select new ViewAnalyticLidar
                        {
                            X = int.Parse(data[0]),
                            Y = int.Parse(data[1])
                        };
            return query.ToList();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            nameFileTextBox.Text = dlg.FileName;
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lidarRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Visible = true;
            chart1.Series.Clear();
            nameFileTextBox.Clear();
            reportTextBox.Clear();
            dgvData.DataSource = null;
            mapPictureBox.Visible = false;
            dgVMap.Visible = false;
            buttonMapView.Visible = false;

        }

        private void radarRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Visible = true;
            chart1.Series.Clear();
            nameFileTextBox.Clear();
            dgvData.DataSource = null;
            reportTextBox.Clear();
            mapPictureBox.Visible = false;

            dgVMap.Visible = false;
            buttonMapView.Visible = false;
        }

        private void mapRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Visible = true;
            chart1.Series.Clear();
            dgVMap.Visible=true;
            buttonMapView.Visible=true;
            mapPictureBox.Visible = true;
            nameFileTextBox.Clear();
            reportTextBox.Clear();
            dgvData.DataSource = null; 
           

        }

        private void buttonSaveToDBase_Click(object sender, EventArgs e)
        {
            string fileName = nameFileTextBox.Text;
            string reportText = reportTextBox.Text;

            if (string.IsNullOrWhiteSpace(fileName) || string.IsNullOrWhiteSpace(reportText))
            {
                MessageBox.Show("Пожалуйста, введите имя файла и текст отчета.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Создаем экземпляр класса Report и заполняем его свойства
                Report report = new Report
                {
                    ReportDate = DateTime.Now,
                    FileName = Path.GetFileNameWithoutExtension(fileName),
                    ReportResult = reportText
                };

                // Добавляем объект report в контекст базы данных
                dbContext.Reports.Add(report);

                // Сохраняем изменения в базе данных
                dbContext.SaveChanges();

                MessageBox.Show("Отчет успешно сохранен в базе данных.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при сохранении отчета: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonProcessing_Click(object sender, EventArgs e)
        {
            DetermineNoise();
        }

        private void DetermineNoise()
        {
            // Определение шума
            double noiseThreshold = 0.5; // Пороговое значение для определения шума
            List<double> noisePoints = new List<double>();

            if (mapRadioButton.Checked == true)
            {
                // Перебор всех строк в dgvData
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        // Получение значений x и y из ячеек
                        double xValue, yValue;
                        if (double.TryParse(row.Cells["Altitude"].Value.ToString(), out xValue) &&
                            double.TryParse(row.Cells["Longitude"].Value.ToString(), out yValue))
                        {
                            // Проверка на шум
                            if (yValue < noiseThreshold)
                            {
                                // Добавление точки в список шумовых точек
                                noisePoints.Add(xValue);
                            }
                        }
                    }

                }
            }
            else { 

                // Перебор всех строк в dgvData
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        // Получение значений x и y из ячеек
                        double xValue, yValue;
                        if (double.TryParse(row.Cells["X"].Value.ToString(), out xValue) &&
                            double.TryParse(row.Cells["Y"].Value.ToString(), out yValue))
                        {
                            // Проверка на шум
                            if (yValue < noiseThreshold)
                            {
                                // Добавление точки в список шумовых точек
                                noisePoints.Add(xValue);
                            }
                        }
                    }
                }
            }

            // Формирование отчета
            StringBuilder report = new StringBuilder();
            report.AppendLine("Отчет о шуме:\n");
            if (noisePoints.Count > 0)
            {
                report.AppendLine("\nОбнаружены зашумленные точки при следующих значениях x:");
                foreach (var point in noisePoints)
                {
                    report.AppendLine(point.ToString());
                }
            }
            else
            {
                report.AppendLine("\nЗашумленных точек не обнаружено.");
            }

            // Вывод отчета в reportTextBox
            reportTextBox.Text = report.ToString();
        }

        private void buttonMapView_Click(object sender, EventArgs e)
        {
            LoadPolygons();

        }
        private void LoadPolygons()
        {
            var polygons = dbContext.Polygons.ToList();
            dgVMap.DataSource = polygons;
            dgVMap.Columns["PolygonPhoto"].Visible = false; // Скрыть колонку с фотографиями
        }
        private void dgVMap_SelectionChanged(object sender, EventArgs e)
        {
            if (dgVMap.SelectedRows.Count > 0)
            {
                var selectedRow = dgVMap.CurrentRow; 
                var polygonDate = (DateTime)selectedRow.Cells["PolygonDate"].Value;

                var polygon = dbContext.Polygons.FirstOrDefault(p => p.PolygonDate == polygonDate);

                if (polygon != null && polygon.PolygonPhoto != null)
                {
                    using (var ms = new MemoryStream(polygon.PolygonPhoto))
                    {
                        mapPictureBox.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    mapPictureBox.Image = null;
                }
            }
        }
    }

    public class ViewAnalyticRadar
    {
        public int X {get;set;}
        public int Y { get;set;}
        
    }
    public class ViewAnalyticLidar
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
        public class ViewAnalyticGNSS
        { 
       public double Altitude { get;set;}
            public double Longitude { get;set;}
        }
        public class ViewPicture
    {
        public int Pic { get; set; }
    }
    
}
