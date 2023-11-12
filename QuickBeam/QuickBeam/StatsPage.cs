using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickBeam
{
    public partial class StatsPage : Form
    {
        public StatsPage()
        {
            InitializeComponent();
        }

        private void Slider_Drag(object sender, MouseEventArgs e)
        {
            ProgressBar progressBar = (sender as ProgressBar);
            if (Cursor.Position.X > progressBar.Location.X)
            {
                progressBar.Value = ((Cursor.Position.X - progressBar.Location.X) * 100) / (Cursor.Position.X - progressBar.Location.X + progressBar.Width);
            }
        }

        private void Slider3_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
