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

namespace Demo
{
    public partial class DemoForm : Form
    {
        public DemoForm()
        {
            InitializeComponent();
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
            panelContainer.Controls.Clear();
        }

        private void CameraRadioButtton_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
        }

        private void GNSSRadioButton_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
        }

        private void RadarRadioButton_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
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
