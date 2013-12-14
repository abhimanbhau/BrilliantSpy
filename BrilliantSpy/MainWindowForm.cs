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
using AForge.Video.VFW;

namespace BrilliantSpy
{
    public partial class MainWindowForm : Form
    {

        string HistoryDBSavePath = Properties.Settings.Default.homeDirectory +
            "\\" + DateTime.UtcNow.ToShortDateString();
        VideoCaptureDevice videoSource;
        FileVideoSource fileVideoSource;
        MotionDetector detector;
        SoundPlayer sound;
        AVIWriter writer = new AVIWriter("wmv3");
        int detectedObject = 0;
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

            if (!Directory.Exists(Properties.Settings.Default.videoCaptureFolder))
            {
                Directory.CreateDirectory(Properties.Settings.Default.videoCaptureFolder);
            }
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            lblDetectorLevel.Text = Convert.ToString(Math.Round(Properties.Settings.
                Default.motionLevel, 1));
            lblWarning.Text = "";
            txtCurrentMotion.Visible = false;
            lblCurrentTime.Text = Convert.ToString("Current System Time -> " +
                DateTime.UtcNow.ToString().Trim());
        }

        private void startFeedFromCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VideoCaptureDeviceForm form = new VideoCaptureDeviceForm();
            form.Text = "Select the camera.Recommended Res is 640*480 & keep defaults";
            if (form.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                videoSource = new VideoCaptureDevice(form.VideoDeviceMoniker);
                videoSource.Start();
                videoSourcePlayer.VideoSource = videoSource;
                videoSourcePlayer.NewFrame += videoSourcePlayer_NewFrame;
                pcbStatusPanel.BackColor = Color.Green;
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

                        case "BLOB":
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

                        case "BLOB":
                            detector = new MotionDetector(
                                new SimpleBackgroundModelingDetector(),
                                new BlobCountingObjectsProcessing());
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

                        case "BLOB":
                            detector = new MotionDetector(
                                new TwoFramesDifferenceDetector(),
                                new BlobCountingObjectsProcessing());
                            detector.Reset();
                            break;
                    }
                    break;
            }
        }

        private void videoSourcePlayer_NewFrame(object sender, ref Bitmap image)
        {
            Bitmap temp, tempCapture;
            tempCapture = new Bitmap(image);
            temp = new Bitmap(image);
            float motion;
            if (detector != null)
            {
                if (detector.MotionProcessingAlgorithm is BlobCountingObjectsProcessing)
                {
                    BlobCountingObjectsProcessing countProcessor = (BlobCountingObjectsProcessing)
                        detector.MotionProcessingAlgorithm;
                    detectedObject = countProcessor.ObjectsCount;
                }
                if (Properties.Settings.Default.isShowMotionInPlayer)
                {
                    motion = detector.ProcessFrame(image);
                }
                else
                {
                    motion = detector.ProcessFrame(temp);
                }
                if (motion > Properties.Settings.Default.motionLevel)
                {
                    HistoryList.Items.Add("Motion ->" + motion + "       @"
                        + DateTime.UtcNow.ToString());
                    pcbStatusPanel.BackColor = Color.Red;
                    lblWarning.Text = Properties.Settings.Default.customWarningMessage;
                    AlertBySound();
                    if (Properties.Settings.Default.isShowMotionInPlayer)
                    {
                        temp.Save(HistoryDBSavePath + "\\00" + counter + ".bmp", ImageFormat.Bmp);
                        counter++;
                    }
                    else
                    {
                        tempCapture.Save(HistoryDBSavePath + "\\00" + counter + ".bmp", ImageFormat.Bmp);
                        counter++;
                    }
                }
                else
                {
                    if (chbEnableMotionDisplay.Checked == true)
                    {
                        txtCurrentMotion.Text = "MOTION->" + motion;
                    }
                }
            }
            temp.Dispose();
            tempCapture.Dispose();
        }

        private void AlertBySound()
        {
            if (sound != null)
            {
                return;
            }
            else
            {
                sound = new SoundPlayer(Properties.Resources.siren);
                sound.PlayLooping();
            }
        }

        private void MainWindowForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(this, "Do You Really want to close the application",
                "Really Quit?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                StopVideoSource();
                this.Dispose();
            }
            Properties.Settings.Default.howManyRuns = Properties.Settings.Default.howManyRuns + 1;
            Properties.Settings.Default.Save();
            if (writer != null)
            {
                writer.Close();
            }
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
            if (detector != null)
            {
                detector = null;
            }
        }

        private void startFeedFromVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Properties.Settings.Default.homeDirectory;
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Select a file to process";
            openFileDialog.Filter = "BrilliantSpy Supported Video Files (*.avi)|*.avi";
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
            SelectImageFolderForm form = new SelectImageFolderForm();
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
            LoginForm LoginForm = new BrilliantSpy.LoginForm();
            LoginForm.Text = "Re-login with your credentials";
            LoginForm.ShowDialog();
            if (LoginForm.getLoginStatus())
            {
                SettingsForm form = new SettingsForm();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show(this, "Authentication is required to access settings",
                    "Note",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            try
            {
                StopVideoSource();
                StopAlertSound();
                lblWarning.Text = "";
                pcbStatusPanel.BackColor = Color.Green;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("No video source loaded" + ex.Message);
            }
        }

        private void StopAlertSound()
        {
            if (sound == null)
            {
                return;
            }
            else
            {
                sound.Stop();
                sound.Dispose();
                sound = null;
            }
        }

        private void btnStopAlarm_Click(object sender, EventArgs e)
        {
            try
            {
                StopAlertSound();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("No sound playing" + ex.Message);
            }
        }

        private void btnClearHistoryBox_Click(object sender, EventArgs e)
        {
            HistoryList.Items.Clear();
        }

        private void btnSaveMotionHistory_Click(object sender, EventArgs e)
        {
            saveFile.Filter = "BrilliantSpy History Save File (*.txt)|*.txt";
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                foreach (Object item in HistoryList.Items)
                {
                    sb.AppendLine(item.ToString());
                }
                File.WriteAllText(saveFile.FileName, sb.ToString());
            }
        }

        private void btnRefreshDetectorLevel_Click(object sender, EventArgs e)
        {
            lblDetectorLevel.Text = Convert.ToString(Math.Round(Properties.Settings.
                Default.motionLevel, 1));
        }

        private void suggestAnIdeaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuggestionForm form = new SuggestionForm();
            form.ShowDialog();
        }

        private void videoSourcePlayer_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("This is where you get the preview of your web-cam " +
            "or video feed", videoSourcePlayer);
        }

        private void btnStopProcessing_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Stops the motion detector processing", btnStopProcessing);
        }

        private void btnStopAlarm_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Stops alarm if it was turned on falsely", btnStopAlarm);
        }

        private void HistoryList_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Contains history of all recorded motion which exceeded threshold",
                HistoryList);
        }

        private void chbEnableMotionDisplay_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Displays the motion processing data for every frame " +
            "Helpful in analysing thresholds for different situations", chbEnableMotionDisplay);
        }

        private void lblDetectorLevel_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("This is max threshold value above which any motion is considered as intrusion",
                lblDetectorLevel);
        }

        private void pcbStatusPanel_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("This Box remains green untill no suspect-able motion is detected",
                pcbStatusPanel);
        }

        private void blobCountingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (videoSource == null && fileVideoSource == null)
            {
                MessageBox.Show(this, "Please start video feed from camera or vide file first",
                   "No source detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                motionProcess = "BLOB";
                MotionDetectorAlgorithmStart();
            }
        }

        private void followMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FollowMeForm form = new FollowMeForm();
            form.ShowDialog();
        }

        private void btnResetDetector_Click(object sender, EventArgs e)
        {
            if (detector != null)
            {
                pcbStatusPanel.BackColor = Color.Green;
                lblWarning.Text = "";
                StopAlertSound();
                detector.Reset();
            }
            else
            {
                MessageBox.Show(this, "No instance of feed found\nDetector isn't running", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearHistoryBox_Click_1(object sender, EventArgs e)
        {
            if (HistoryList.Items.Count != 0)
            {
                HistoryList.Items.Clear();
            }
            else
            {
                MessageBox.Show(this, "Already cleared", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
