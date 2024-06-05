using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.PanelControl
{
    public partial class AnalyticControlPanel : UserControl
    {
        public AnalyticControlPanel()
        {
            InitializeComponent();
        }

        private void guna2ButtonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (radarRadioButton.Checked == true)
                {
                    dgvData.DataSource = radarLoadCSV(nameFileTextBox.Text);
                }
                else if (lidarRadioButton.Checked == true)
                {
                    dgvData.DataSource = lidarLoadCSV(nameFileTextBox.Text);
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
                                Daln = int.Parse(data[0])
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
            
        }
    }

    public class ViewAnalyticRadar
    {
        public int Daln {get;set;}
        
    }
    public class ViewAnalyticLidar
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    public class ViewPicture
    {
        public int Pic { get; set; }
    }
    
}
