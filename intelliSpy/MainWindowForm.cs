using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using AForge.Vision.Motion;
using AForge.Video.DirectShow;
using System.Media;
using System.IO;

namespace intelliSpy
{
    public partial class MainWindowForm : Form
    {

        string HistoryDBSavePath = Properties.Settings.Default.homeDirectory +
            "\\" + DateTime.UtcNow.ToShortDateString();
        VideoCaptureDevice videoSource;
        FileVideoSource fileVideoSource;
        MotionDetector detector;
        SoundPlayer sound;
        string[] files;
        int counter;
        string detectorMode = "DIFF";
        string motionProcess = "Area";

        public MainWindowForm()
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
                DirectoryInfo info = new DirectoryInfo(Properties.Settings.Default.homeDirectory);
                info.Attributes = FileAttributes.Hidden;
            }

            else
            {
                DirectoryInfo info = new DirectoryInfo(Properties.Settings.Default.homeDirectory);
                info.Attributes = FileAttributes.Normal;
            }
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            lblDetectorLevel.Text = Convert.ToString(Properties.Settings.Default.motionLevel);
            txtCurrentMotion.Visible = false;
        }

        private void startFeedFromCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VideoCaptureDeviceForm form = new VideoCaptureDeviceForm();
            if (form.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                videoSource = new VideoCaptureDevice(form.VideoDeviceMoniker);
                videoSource.Start();
                detector = new MotionDetector(new TwoFramesDifferenceDetector(),
                    new MotionAreaHighlighting());
                videoSourcePlayer.VideoSource = videoSource;
                videoSourcePlayer.NewFrame += videoSourcePlayer_NewFrame;
                StatusPanel.BackColor = Color.Green;
            }
        }

        private void MotionDetectorAlgorithmStart()
        {

            switch (detectorMode)
            {
                case "NONE":
                    switch (motionProcess)
                    {
                        case "AREA":
                            detector = null;
                            break;

                        case "BORDER":
                            detector = null;
                            break;

                        case "GRID":
                            detector = null;
                            break;
                    }
                    break;

                case "BG":
                    switch (motionProcess)
                    {
                        case "AREA":
                            detector = new MotionDetector(
                                new SimpleBackgroundModelingDetector(),
                                new MotionAreaHighlighting());
                            detector.Reset();
                            break;

                        case "BORDER":
                            detector = new MotionDetector(
                                new SimpleBackgroundModelingDetector(),
                                new MotionBorderHighlighting());
                            detector.Reset();
                            break;

                        case "GRID":
                            detector = new MotionDetector(
                                new SimpleBackgroundModelingDetector(),
                                new GridMotionAreaProcessing());
                            detector.Reset();
                            break;
                    }
                    break;

                case "DIFF":
                    switch (motionProcess)
                    {
                        case "AREA":
                            detector = new MotionDetector(
                                new TwoFramesDifferenceDetector(),
                                new MotionAreaHighlighting());
                            detector.Reset();
                            break;

                        case "BORDER":
                            detector = new MotionDetector(
                                new TwoFramesDifferenceDetector(),
                                new MotionBorderHighlighting());
                            detector.Reset();
                            break;

                        case "GRID":
                            detector = new MotionDetector(
                                new TwoFramesDifferenceDetector(),
                                new GridMotionAreaProcessing());
                            detector.Reset();
                            break;
                    }
                    break;
            }
        }

        private void videoSourcePlayer_NewFrame(object sender, ref Bitmap image)
        {
            Bitmap temp;
            if (detector != null)
            {
                temp = new Bitmap(image);
                float motion = detector.ProcessFrame(image);
                if (motion > Properties.Settings.Default.motionLevel)
                {
                    HistoryList.Items.Add("Motion ->" + motion + "       @"
                        + DateTime.UtcNow.ToString());
                    StatusPanel.BackColor = Color.Red;
                    lblWarning.Text = Properties.Settings.Default.customWarningMessage;
                    AlertBySound();
                    temp.Save(HistoryDBSavePath + "\\00" + counter + ".bmp", ImageFormat.Bmp);
                    counter++;
                }
                else
                {
                    StatusPanel.BackColor = Color.Green;
                    // WarningMessage.Text = "";
                    if (chbEnableMotionDisplay.Checked == true)
                    {
                        txtCurrentMotion.Text = "MOTION->" + motion;
                    }
                }
                temp.Dispose();
            }
        }

        private void AlertBySound()
        {
            sound = new SoundPlayer(Properties.Resources.siren);
            sound.PlayLooping();
        }

        private void MainWindowForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopVideoSource();
            this.Dispose();
        }

        private void StopVideoSource()
        {
            if (videoSource != null)
            {
                videoSource.SignalToStop();
                videoSource.Stop();
                videoSource = null;
            }
            else if (fileVideoSource != null)
            {
                fileVideoSource.SignalToStop();
                fileVideoSource.Stop();
                fileVideoSource = null;
            }
        }

        private void startFeedFromVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileVideoSource = new FileVideoSource(openFileDialog.FileName);
                fileVideoSource.Start();
                detector = new MotionDetector(new TwoFramesDifferenceDetector(),
                    new MotionAreaHighlighting());
                videoSourcePlayer.VideoSource = fileVideoSource;
                videoSourcePlayer.NewFrame += videoSourcePlayer_NewFrame;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
