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

namespace CatalystSpy
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
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            lblDetectorLevel.Text = Convert.ToString(Properties.Settings.
                Default.motionLevel);
            lblWarning.Text = "";
            txtCurrentMotion.Visible = false;
        }

        private void startFeedFromCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VideoCaptureDeviceForm form = new VideoCaptureDeviceForm();
            if (form.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                videoSource = new VideoCaptureDevice(form.VideoDeviceMoniker);
                videoSource.Start();
                //detector = new MotionDetector(new TwoFramesDifferenceDetector(),
                //   new MotionAreaHighlighting());
                videoSourcePlayer.VideoSource = videoSource;
                videoSourcePlayer.NewFrame += videoSourcePlayer_NewFrame;
                pcbStatusPanel.BackColor = Color.Green;
            }
        }

        private void MotionDetectorAlgorithmStart()
        {
            // pcbStatusPanel.BackColor = Color.Green;
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
                    pcbStatusPanel.BackColor = Color.Red;
                    lblWarning.Text = Properties.Settings.Default.customWarningMessage;
                    AlertBySound();
                    temp.Save(HistoryDBSavePath + "\\00" + counter + ".bmp", ImageFormat.Bmp);
                    counter++;
                }
                else
                {
                    //pcbStatusPanel.BackColor = Color.Green;
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

        private void simpleBackgroundModellingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (videoSource == null && fileVideoSource == null)
            {
                MessageBox.Show(this, "Please start video feed from camera or vide file first",
                    "No source detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                detectorMode = "BG";
                MotionDetectorAlgorithmStart();
            }
        }

        private void twoFrameDifferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (videoSource == null && fileVideoSource == null)
            {
                MessageBox.Show(this, "Please start video feed from camera or vide file first",
                   "No source detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                detectorMode = "DIFF";
                MotionDetectorAlgorithmStart();
            }
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (videoSource == null && fileVideoSource == null)
            {
                MessageBox.Show(this, "Please start feed from camera or video file first",
                   "No source detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                detectorMode = "NONE";
                MotionDetectorAlgorithmStart();
            }
        }

        private void areaHighlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (videoSource == null && fileVideoSource == null)
            {
                MessageBox.Show(this, "Please start feed from camera or video file first",
                   "No source detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                motionProcess = "AREA";
                MotionDetectorAlgorithmStart();
            }
        }

        private void gridMotionProcessingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (videoSource == null && fileVideoSource == null)
            {
                MessageBox.Show(this, "Please start video feed from camera or vide file first",
                   "No source detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                motionProcess = "GRID";
                MotionDetectorAlgorithmStart();
            }
        }

        private void borderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (videoSource == null && fileVideoSource == null)
            {
                MessageBox.Show(this, "Please start video feed from camera or vide file first",
                   "No source detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                motionProcess = "BORDER";
                MotionDetectorAlgorithmStart();
            }
        }

        private void viewPreviousImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCapturedImagesForm form = new ViewCapturedImagesForm();
            form.ShowDialog();
        }

        private void toolsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EncryptDecryptFilesForm form = new EncryptDecryptFilesForm();
            form.ShowDialog();
        }

        private void compressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompressFilesForm form = new CompressFilesForm();
            form.ShowDialog();
        }

        private void preferancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm();
            form.ShowDialog();
        }

        private void suggetionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BugReportForm form = new BugReportForm();
            form.ShowDialog();
        }

        private void openSourceLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSourceLicenseForm form = new OpenSourceLicenseForm();
            form.ShowDialog();
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutMeForm form = new AboutMeForm();
            form.ShowDialog();
        }

        private void chbEnableMotionDisplay_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEnableMotionDisplay.Checked == true)
            {
                txtCurrentMotion.Visible = true;
                chbEnableMotionDisplay.Text = "Disable";
            }
            else
            {
                txtCurrentMotion.Visible = false;
                chbEnableMotionDisplay.Text = "Enable";
            }
        }

        private void btnStopProcessing_Click(object sender, EventArgs e)
        {
            StopVideoSource();
            StopAlertSound();
            lblWarning.Text = "";
            pcbStatusPanel.BackColor = Color.Green;
        }

        private void StopAlertSound()
        {
            sound.Stop();
            sound.Dispose();
        }

        private void btnStopAlarm_Click(object sender, EventArgs e)
        {
            StopAlertSound();
        }

    }
}
