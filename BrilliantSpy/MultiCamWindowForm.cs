using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BrilliantSpy
{
    public partial class MultiCamWindowForm : Form
    {
        public MultiCamWindowForm()
        {
            InitializeComponent();
        }

        private void MultiCamWindowForm_Load(object sender, EventArgs e)
        {

        }

        private void txtDetectorLevel_Click(object sender, EventArgs e)
        {
            txtDetectorLevel.Text = Convert.ToString(Math.Round(Properties.Settings.Default.motionLevel, 1));
        }
    }
}
