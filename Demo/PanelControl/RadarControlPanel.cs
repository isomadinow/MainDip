using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartesianChart = LiveCharts.Wpf.CartesianChart;
using LiveCharts.Definitions.Charts;
using System.IO.Ports;
using LiveCharts.Wpf;
using LiveCharts;
using System.IO;
using System.Threading;

namespace Demo.PanelControl
{
    public partial class RadarControlPanel : UserControl
    {
        private const int V = 0;
        SerialPort port;
        LiveCharts.WinForms.CartesianChart cartesianChart2;
        public RadarControlPanel()
        {
            InitializeComponent();

            if (port == null)
            {
                //port = new SerialPort("COM8", 9600);//Set your board COM
                //port.Open();
            }
            else
            {
               // MessageBox.Show("Порт не подключен!");
            }
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;
            resetChart();
        }
        public void resetChart()
        {
            LiveCharts.WinForms.CartesianChart cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            cartesianChart1.Width = 600;
            cartesianChart1.Height = 300;
            cartesianChart1.Visible = false;
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Series 1",
                    Values = new ChartValues<double> {}
                }

            };
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Measure",

                //Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" }
            });


            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Distance CM",
                MinValue = 0,
                MaxValue = 50,
                //,LabelFormatter = value => value.ToString("C")
            });

            cartesianChart1.LegendLocation = LegendLocation.Right;


            cartesianChart1.DataClick += CartesianChart1OnDataClick;

            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(cartesianChart1);
            cartesianChart1.Visible = true;
            this.cartesianChart2 = cartesianChart1;
        }
        private void CartesianChart1OnDataClick(object sender, ChartPoint chartPoint)
        {
            MessageBox.Show("You clicked (" + chartPoint.X + "," + chartPoint.Y + ")");
        }

        private void RadarControlPanel_Load(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            resetChart();
        }

       private List<PointF> points = new List<PointF>();
        private async  void buttonStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Не выбран порт!");
            MessageBox.Show("Не возможно принять и отобразить данные, так как нет подключение к COM-порту!");
            int numberOfReadings = 200; // Указываете количество тестовых данных, которое вы хотите сгенерировать
            await GenerateTestData(numberOfReadings);
            ////String a = textBox1.Text;
            //int numberOfReadings = 0;
            //Int32.TryParse(textBox1.Text, out numberOfReadings);
            //CleanBuffer();

            //for (int i = 0; i < numberOfReadings; i++)
            //{

            //    Task<String> valueSerial = ReadSerial();
            //    String finalValueSerial = await valueSerial;
            //    Double d = Convert.ToDouble(finalValueSerial);

            //    this.cartesianChart2.Series[0].Values.Add(d);
            //    int barValue = Convert.ToInt32(d);        // Добавляем X и Y координаты в список
            //    points.Add(new PointF(i, (float)d));
            //    if (barValue > 100)
            //    {

            //        barValue = 100;
            //    }
            //    progressBar1.Value = barValue;
            //    label4.Text = d.ToString();
            //}
         
        }
   
        private async Task GenerateTestData(int numberOfReadings)
        {
            CleanBuffer();

            Random random = new Random();
           
           
            for (int i = 0; i < numberOfReadings; i++)
            {
                double randomValue = random.NextDouble() * 200; // Генерируем случайное значение от 0 до 200
                this.cartesianChart2.Series[0].Values.Add(randomValue);

                int barValue = (int)randomValue;
                if (barValue > 100)
                {
                    barValue = 100;
                }
                progressBar1.Value = barValue;
                label4.Text = barValue.ToString();

                points.Add(new PointF(i, (float)randomValue)); 
                
                // Добавляем координаты в список точек
            }

            // Сохраняем данные в CSV-файл (это можно сделать и в другом методе, если нужно)

        }
        private void SavePointsToCsv(string filePath, List<PointF> points)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
             
                foreach (PointF point in points)
                {
                    writer.WriteLine($"{point.X},{point.Y}");
                }
            }
        }
        public void CleanBuffer()
        {
           // port.DiscardInBuffer();
        }
        public async Task<String> ReadSerial()
        {
            String stringSerial = "";

            await Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Starting Read");

                stringSerial = port.ReadLine();
            });


            return stringSerial;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            //port.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Создаем диалог выбора папки для сохранения файла
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                saveFileDialog.Title = "Save Data";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Получаем путь к файлу из диалога
                    string filePath = saveFileDialog.FileName;

                    // Вызываем метод сохранения данных в CSV-файле
                    SavePointsToCsv(filePath, points);

                    // После сохранения можно вывести сообщение об успешном сохранении
                    MessageBox.Show("Data saved successfully.", "Save Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
    }


