using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Vision.Motion;
using System.Media;
using System.IO;

namespace BrilliantSpy
{
    public partial class MultiCamWindowForm : Form
    {
        string HistoryDBSavePath = Properties.Settings.Default.homeDirectory +
            "\\" + DateTime.UtcNow.ToShortDateString();
        VideoCaptureDevice videoSource1, videoSource2, videoSource3, videoSource4;
        MotionDetector detector1, detector2, detector3, detector4;
        SoundPlayer sound;
        int detectedObject = 0;
        string[] files;
        int counter;
        string detectorMode = "DIFF";
        string motionProcess = "Area";

        public MultiCamWindowForm()
        {
            InitializeComponent();
            if (Directory.Exists(HistoryDBSavePath + "\\"))
            {
                files = Directory.GetFiles(HistoryDBSavePath + "\\");
            }

            else
            {
                Directory.CreateDirectory(HistoryDBSavePath + "\\");
                files = Directory.GetFiles(HistoryDBSavePath + "\\");
            }

            counter = files.Length + 1;

            if (Properties.Settings.Default.isDirectoryHidden)
            {
                DirectoryInfo info = new DirectoryInfo(Properties.Settings.
                    Default.homeDirectory);
                info.Attributes = FileAttributes.Hidden;
            }

            else
            {
                DirectoryInfo info = new DirectoryInfo(Properties.Settings.
                    Default.homeDirectory);
                info.Attributes = FileAttributes.Normal;
            }

            if (!Directory.Exists(Properties.Settings.Default.videoCaptureFolder))
            {
                Directory.CreateDirectory(Properties.Settings.Default.videoCaptureFolder);
            }
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

        private void cam1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VideoCaptureDeviceForm form = new VideoCaptureDeviceForm();
            form.Text = "Select the camera.Recommended Res is 640*480 & keep defaults";
            if (form.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                
            }
        }
    }
}
