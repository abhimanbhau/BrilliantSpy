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
            txtCurrentMotion.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = Convert.ToString(Math.Round(Properties.Settings.Default.motionLevelCam1,
                1));
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = Convert.ToString(Math.Round(Properties.Settings.Default.motionLevelCam2,
                1));
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = Convert.ToString(Math.Round(Properties.Settings.Default.motionLevelCam3,
                1));
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = Convert.ToString(Math.Round(Properties.Settings.Default.motionLevelCam4,
                1));
        }
    }
}
