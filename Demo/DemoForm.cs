using Demo.PanelControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Demo.bd;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace Demo
{
    public partial class DemoForm : Form
    {
        public const string connectionString = @"Data Source=COMP-AZIZ\SQLEXPRESS;Initial Catalog=PrecepDB;Integrated Security=True";

        public DemoForm()
        {
            InitializeComponent();
         
            // Проверяем, существует ли база данных

            try
            {
                // Проверяем, существует ли база данных
                bool databaseExists = CheckDatabaseExists(connectionString);

                // Если база данных не существует, создаем ее
                if (!databaseExists)
                {
                    // Создаем базу данных и таблицы
                    using (var context = new MyDbContext(connectionString))
                    {
                  
                        context.Database.Create();
                    }

                    MessageBox.Show("База данных создана успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    using (var context = new MyDbContext(connectionString))
                    {
                        //context.Database.Initialize(true);
                        context.SaveChanges();
                    }

                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при создании базы данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            AnalyticControlPanel analyticControlPanel = new AnalyticControlPanel();
            addUserControl(analyticControlPanel);
        }

        private bool CheckDatabaseExists(string connectionString)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                
                    return true;
                }
            }
            catch (SqlException)
            {
              
                return false;
            }
        }
    

    private void LidarRadioButton_Click(object sender, EventArgs e)
        {
            LidarControlPanel lidarControlPanel = new LidarControlPanel();
            addUserControl(lidarControlPanel);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill; 
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
            
        }
   
        private void MainRadiobutton_Click(object sender, EventArgs e)
        {
           AnalyticControlPanel analyticControlPanel = new AnalyticControlPanel();
            addUserControl(analyticControlPanel);
        }

        private void CameraRadioButtton_Click(object sender, EventArgs e)
        {
            CameraControlPanel cameraControlPanel = new CameraControlPanel();
            addUserControl(cameraControlPanel);
            
        }

        private void GNSSRadioButton_Click(object sender, EventArgs e)
        {
            MapControlPanel mapControlPanel = new MapControlPanel();
            addUserControl(mapControlPanel);
           
        }

        private void RadarRadioButton_Click(object sender, EventArgs e)
        {
           RadarControlPanel radarControlPanel = new RadarControlPanel();
           addUserControl(radarControlPanel);
          
        }
        private void AnalysRadioButton_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
