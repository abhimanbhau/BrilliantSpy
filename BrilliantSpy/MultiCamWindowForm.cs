using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Vision.Motion;
using System.Media;
using System.IO;
using AForge.Controls;
using AForge.Video;
using MetroFramework.Forms;

namespace BrilliantSpy
{
    public partial class MultiCamWindowForm : MetroForm
    {
        string HistoryDBSavePath = Properties.Settings.Default.homeDirectory +
            @"\" + DateTime.UtcNow.ToShortDateString() + @"\";
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
            txtMotionLevel1.Text = Convert.ToString(Math.Round(Properties.Settings.Default.motionLevelCam1,
                2));
            txtMotionLevel2.Text = Convert.ToString(Math.Round(Properties.Settings.Default.motionLevelCam2,
                2));
            txtMotionLevel3.Text = Convert.ToString(Math.Round(Properties.Settings.Default.motionLevelCam3,
                2));
            txtMotionLevel4.Text = Convert.ToString(Math.Round(Properties.Settings.Default.motionLevelCam4,
                2));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtMotionLevel1.Text = Convert.ToString(Math.Round(Properties.Settings.Default.motionLevelCam1,
                2));
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtMotionLevel2.Text = Convert.ToString(Math.Round(Properties.Settings.Default.motionLevelCam2,
                2));
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtMotionLevel3.Text = Convert.ToString(Math.Round(Properties.Settings.Default.motionLevelCam3,
                2));
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtMotionLevel4.Text = Convert.ToString(Math.Round(Properties.Settings.Default.motionLevelCam4,
                2));
        }

        private void cam1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VideoCaptureDeviceForm form = new VideoCaptureDeviceForm();
            form.Text = "Select the camera.Recommended Res is 640*480 & keep defaults";
            if (form.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                videoSource1 = new VideoCaptureDevice(form.VideoDeviceMoniker);
                videoSource1.Start();
                videoSourcePlayer1.VideoSource = videoSource1;
                videoSourcePlayer1.NewFrame += videoSourcePlayer1_NewFrame;
                pcbStatus1.BackColor = Color.Green;
            }
        }

        private void videoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
        {
            Bitmap temp, tempCapture;
            tempCapture = new Bitmap(image);
            temp = new Bitmap(image);
            float motion;
            if (detector1 != null)
            {
                if (detector1.MotionProcessingAlgorithm is BlobCountingObjectsProcessing)
                {
                    BlobCountingObjectsProcessing countProcessor = (BlobCountingObjectsProcessing)
                        detector1.MotionProcessingAlgorithm;
                    detectedObject = countProcessor.ObjectsCount;
                }
                if (Properties.Settings.Default.isShowMotionInPlayer)
                {
                    motion = detector1.ProcessFrame(image);
                }
                else
                {
                    motion = detector1.ProcessFrame(temp);
                }
                if (motion > Properties.Settings.Default.motionLevelCam1)
                {
                    lstHistory.Items.Add("Motion[CAM 1] ->" + motion + " @"
                         + DateTime.UtcNow.ToString());
                    pcbStatus1.BackColor = Color.Red;
                    AlertBySound();
                    if (Properties.Settings.Default.isShowMotionInPlayer)
                    {
                        temp.Save(HistoryDBSavePath + "CAM1 " + counter + ".bmp", ImageFormat.Bmp);
                        counter++;
                    }
                    else
                    {
                        tempCapture.Save(HistoryDBSavePath + "CAM1 " + counter + ".bmp", ImageFormat.Bmp);
                        counter++;
                    }
                }
                txtDetectorLevel1.Text = Convert.ToString(Math.Round(motion, 3));
            }
            temp.Dispose();
            tempCapture.Dispose();
        }

        private void cam2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VideoCaptureDeviceForm form = new VideoCaptureDeviceForm();
            form.Text = "Select the camera.Recommended Res is 640*480 & keep defaults";
            if (form.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                videoSource2 = new VideoCaptureDevice(form.VideoDeviceMoniker);
                videoSource2.Start();
                videoSourcePlayer2.VideoSource = videoSource2;
                videoSourcePlayer2.NewFrame += videoSourcePlayer2_NewFrame;
                pcbStatus2.BackColor = Color.Green;
            }
        }

        private void videoSourcePlayer2_NewFrame(object sender, ref Bitmap image)
        {
            Bitmap temp, tempCapture;
            tempCapture = new Bitmap(image);
            temp = new Bitmap(image);
            float motion;
            if (detector2 != null)
            {
                if (detector2.MotionProcessingAlgorithm is BlobCountingObjectsProcessing)
                {
                    BlobCountingObjectsProcessing countProcessor = (BlobCountingObjectsProcessing)
                        detector2.MotionProcessingAlgorithm;
                    detectedObject = countProcessor.ObjectsCount;
                }
                if (Properties.Settings.Default.isShowMotionInPlayer)
                {
                    motion = detector2.ProcessFrame(image);
                }
                else
                {
                    motion = detector2.ProcessFrame(temp);
                }
                if (motion > Properties.Settings.Default.motionLevelCam2)
                {
                    lstHistory.Items.Add("Motion[CAM 2] ->" + motion + " @"
                         + DateTime.UtcNow.ToString());
                    pcbStatus2.BackColor = Color.Red;
                    AlertBySound();
                    if (Properties.Settings.Default.isShowMotionInPlayer)
                    {
                        temp.Save(HistoryDBSavePath + "CAM2 " + counter + ".bmp", ImageFormat.Bmp);
                        counter++;
                    }
                    else
                    {
                        tempCapture.Save(HistoryDBSavePath + "CAM2 " + counter + ".bmp", ImageFormat.Bmp);
                        counter++;
                    }
                }
                txtDetectorLevel2.Text = Convert.ToString(Math.Round(motion, 3));
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
                sound = new SoundPlayer(Properties.Resources.siren04);
                sound.PlayLooping();
            }
        }

        private void camera3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VideoCaptureDeviceForm form = new VideoCaptureDeviceForm();
            form.Text = "Select the camera.Recommended Res is 640*480 & keep defaults";
            if (form.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                videoSource3 = new VideoCaptureDevice(form.VideoDeviceMoniker);
                videoSource3.Start();
                videoSourcePlayer3.VideoSource = videoSource3;
                videoSourcePlayer3.NewFrame += videoSourcePlayer3_NewFrame;
                pcbStatus3.BackColor = Color.Green;
            }
        }

        private void videoSourcePlayer3_NewFrame(object sender, ref Bitmap image)
        {
            Bitmap temp, tempCapture;
            tempCapture = new Bitmap(image);
            temp = new Bitmap(image);
            float motion;
            if (detector3 != null)
            {
                if (detector3.MotionProcessingAlgorithm is BlobCountingObjectsProcessing)
                {
                    BlobCountingObjectsProcessing countProcessor = (BlobCountingObjectsProcessing)
                        detector3.MotionProcessingAlgorithm;
                    detectedObject = countProcessor.ObjectsCount;
                }
                if (Properties.Settings.Default.isShowMotionInPlayer)
                {
                    motion = detector3.ProcessFrame(image);
                }
                else
                {
                    motion = detector3.ProcessFrame(temp);
                }
                if (motion > Properties.Settings.Default.motionLevelCam3)
                {
                    lstHistory.Items.Add("Motion[CAM 3] ->" + motion + " @"
                         + DateTime.UtcNow.ToString());
                    pcbStatus3.BackColor = Color.Red;
                    AlertBySound();
                    if (Properties.Settings.Default.isShowMotionInPlayer)
                    {
                        temp.Save(HistoryDBSavePath + "CAM3 " + counter + ".bmp", ImageFormat.Bmp);
                        counter++;
                    }
                    else
                    {
                        tempCapture.Save(HistoryDBSavePath + "CAM3 " + counter + ".bmp", ImageFormat.Bmp);
                        counter++;
                    }
                }
                txtDetectorLevel3.Text = Convert.ToString(Math.Round(motion, 3));
            }
            temp.Dispose();
            tempCapture.Dispose();
        }

        private void camera4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VideoCaptureDeviceForm form = new VideoCaptureDeviceForm();
            form.Text = "Select the camera.Recommended Res is 640*480 & keep defaults";
            if (form.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                videoSource4 = new VideoCaptureDevice(form.VideoDeviceMoniker);
                videoSource4.Start();
                videoSourcePlayer4.VideoSource = videoSource4;
                videoSourcePlayer4.NewFrame += videoSourcePlayer4_NewFrame;
                pcbStatus4.BackColor = Color.Green;
            }
        }

        private void videoSourcePlayer4_NewFrame(object sender, ref Bitmap image)
        {
            Bitmap temp, tempCapture;
            tempCapture = new Bitmap(image);
            temp = new Bitmap(image);
            float motion;
            if (detector4 != null)
            {
                if (detector4.MotionProcessingAlgorithm is BlobCountingObjectsProcessing)
                {
                    BlobCountingObjectsProcessing countProcessor = (BlobCountingObjectsProcessing)
                        detector4.MotionProcessingAlgorithm;
                    detectedObject = countProcessor.ObjectsCount;
                }
                if (Properties.Settings.Default.isShowMotionInPlayer)
                {
                    motion = detector4.ProcessFrame(image);
                }
                else
                {
                    motion = detector4.ProcessFrame(temp);
                }
                if (motion > Properties.Settings.Default.motionLevelCam4)
                {
                    lstHistory.Items.Add("Motion[CAM 4] ->" + motion + " @"
                         + DateTime.UtcNow.ToString());
                    pcbStatus4.BackColor = Color.Red;
                    AlertBySound();
                    if (Properties.Settings.Default.isShowMotionInPlayer)
                    {
                        temp.Save(HistoryDBSavePath + "CAM4 " + counter + ".bmp", ImageFormat.Bmp);
                        counter++;
                    }
                    else
                    {
                        tempCapture.Save(HistoryDBSavePath + "CAM4 " + counter + ".bmp", ImageFormat.Bmp);
                        counter++;
                    }
                }
                txtDetectorLevel4.Text = Convert.ToString(Math.Round(motion, 3));
            }
            temp.Dispose();
            tempCapture.Dispose();
        }

        private void MotionDetectorAlgorithmStart(short CamNumber)
        {
            MotionDetector detector = null;
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
                            detector = null;
                            detector = new MotionDetector(
                                new SimpleBackgroundModelingDetector(),
                                new MotionAreaHighlighting());
                            detector.Reset();
                            break;

                        case "BORDER":
                            detector = null;
                            detector = new MotionDetector(
                                new SimpleBackgroundModelingDetector(),
                                new MotionBorderHighlighting());
                            detector.Reset();
                            break;

                        case "GRID":
                            detector = null;
                            detector = new MotionDetector(
                                new SimpleBackgroundModelingDetector(),
                                new GridMotionAreaProcessing());
                            detector.Reset();
                            break;

                        case "BLOB":
                            detector = null;
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
                            detector = null;
                            detector = new MotionDetector(
                                new TwoFramesDifferenceDetector(),
                                new MotionAreaHighlighting());
                            detector.Reset();
                            break;

                        case "BORDER":
                            detector = null;
                            detector = new MotionDetector(
                                new TwoFramesDifferenceDetector(),
                                new MotionBorderHighlighting());
                            detector.Reset();
                            break;

                        case "GRID":
                            detector = null;
                            detector = new MotionDetector(
                                new TwoFramesDifferenceDetector(),
                                new GridMotionAreaProcessing());
                            detector.Reset();
                            break;

                        case "BLOB":
                            detector = null;
                            detector = new MotionDetector(
                                new TwoFramesDifferenceDetector(),
                                new BlobCountingObjectsProcessing());
                            detector.Reset();
                            break;
                    }
                    break;
            }
            if (CamNumber == 1)
            {
                detector1 = detector;
            }
            else if (CamNumber == 2)
            {
                detector2 = detector;
            }
            else if (CamNumber == 3)
            {
                detector3 = detector;
            }
            else if (CamNumber == 4)
            {
                detector4 = detector;
            }
            else { };
            detector = null;
        }

        private void simpleBGModellingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (videoSource1 == null)
            {
                noSourceRunningError();
            }
            {
                detectorMode = "BG";
                MotionDetectorAlgorithmStart(1);
            }
        }

        private void areaHighLightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (videoSource1 == null)
            {
                noSourceRunningError();
            }
            {
                motionProcess = "AREA";
                MotionDetectorAlgorithmStart(1);
            }
        }

        private void twoFrameDifferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (videoSource1 == null)
            {
                noSourceRunningError();
            }
            {
                detectorMode = "DIFF";
                MotionDetectorAlgorithmStart(1);
            }
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (videoSource1 == null)
            {
                noSourceRunningError();
            }
            {
                detectorMode = "NONE";
                MotionDetectorAlgorithmStart(1);
            }
        }

        private void noneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (videoSource2 == null)
            {
                noSourceRunningError();
            }
            {
                detectorMode = "NONE";
                MotionDetectorAlgorithmStart(2);
            }
        }

        private void noneToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (videoSource3 == null)
            {
                noSourceRunningError();
            }
            {
                detectorMode = "NONE";
                MotionDetectorAlgorithmStart(3);
            }
        }

        private void noneToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (videoSource4 == null)
            {
                noSourceRunningError();
            }
            {
                detectorMode = "NONE";
                MotionDetectorAlgorithmStart(4);
            }
        }

        private void simpleBGModellingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (videoSource2 == null)
            {
                noSourceRunningError();
            }
            {
                detectorMode = "BG";
                MotionDetectorAlgorithmStart(2);
            }
        }

        private void simpleBGModellingToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (videoSource3 == null)
            {
                noSourceRunningError();
            }
            {
                detectorMode = "BG";
                MotionDetectorAlgorithmStart(3);
            }
        }

        private void simpleBGModellingToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (videoSource4 == null)
            {
                noSourceRunningError();
            }
            {
                detectorMode = "BG";
                MotionDetectorAlgorithmStart(4);
            }
        }

        private void twoFrameDifferenceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (videoSource2 == null)
            {
                noSourceRunningError();
            }
            {
                detectorMode = "DIFF";
                MotionDetectorAlgorithmStart(2);
            }
        }

        private void twoFrameDifferenceToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (videoSource3 == null)
            {
                noSourceRunningError();
            }
            {
                detectorMode = "DIFF";
                MotionDetectorAlgorithmStart(3);
            }
        }

        private void twoFrameDifferenceToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (videoSource4 == null)
            {
                noSourceRunningError();
            }
            {
                detectorMode = "DIFF";
                MotionDetectorAlgorithmStart(4);
            }
        }

        private void areaHighLightToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (videoSource2 == null)
            {
                noSourceRunningError();
            }
            {
                motionProcess = "AREA";
                MotionDetectorAlgorithmStart(2);
            }
        }

        private void areaHighLightToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (videoSource3 == null)
            {
                noSourceRunningError();
            }
            {
                motionProcess = "AREA";
                MotionDetectorAlgorithmStart(3);
            }
        }

        private void areaHighLightToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (videoSource4 == null)
            {
                noSourceRunningError();
            }
            {
                motionProcess = "AREA";
                MotionDetectorAlgorithmStart(4);
            }
        }

        private void borderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (videoSource1 == null)
            {
                noSourceRunningError();
            }
            {
                motionProcess = "BORDER";
                MotionDetectorAlgorithmStart(1);
            }
        }

        private void borderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (videoSource2 == null)
            {
                noSourceRunningError();
            }
            {
                motionProcess = "BORDER";
                MotionDetectorAlgorithmStart(2);
            }
        }

        private void borderToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (videoSource3 == null)
            {
                noSourceRunningError();
            }
            {
                motionProcess = "BORDER";
                MotionDetectorAlgorithmStart(3);
            }
        }

        private void borderToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (videoSource4 == null)
            {
                noSourceRunningError();
            }
            {
                motionProcess = "BORDER";
                MotionDetectorAlgorithmStart(4);
            }
        }

        private void gridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (videoSource1 == null)
            {
                noSourceRunningError();
            }
            {
                motionProcess = "GRID";
                MotionDetectorAlgorithmStart(1);
            }
        }

        private void gridToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (videoSource2 == null)
            {
                noSourceRunningError();
            }
            {
                motionProcess = "GRID";
                MotionDetectorAlgorithmStart(2);
            }
        }

        private void gridToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (videoSource3 == null)
            {
                noSourceRunningError();
            }
            {
                motionProcess = "GRID";
                MotionDetectorAlgorithmStart(3);
            }
        }

        private void gridToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (videoSource4 == null)
            {
                noSourceRunningError();
            }
            {
                motionProcess = "GRID";
                MotionDetectorAlgorithmStart(4);
            }
        }

        private void blobCountingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (videoSource1 == null)
            {
                noSourceRunningError();
            }
            {
                motionProcess = "BLOB";
                MotionDetectorAlgorithmStart(1);
            }
        }

        private void blobCountingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (videoSource2 == null)
            {
                noSourceRunningError();
            }
            {
                motionProcess = "BLOB";
                MotionDetectorAlgorithmStart(2);
            }
        }

        private void blobCountingToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (videoSource3 == null)
            {
                noSourceRunningError();
            }
            {
                motionProcess = "BLOB";
                MotionDetectorAlgorithmStart(3);
            }
        }

        private void blobCountingToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (videoSource4 == null)
            {
                noSourceRunningError();
            }
            {
                motionProcess = "BLOB";
                MotionDetectorAlgorithmStart(4);
            }
        }

        private void noSourceRunningError()
        {
            MessageBox.Show(this, "Please start video feed from camera",
                    "No source detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MultiCamWindowForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(this, "Do You Really Want To Quit", "Really Quit?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            else
            {
                stopVideoSources();
                this.Dispose();
            }
            Properties.Settings.Default.howManyRuns++;
            Properties.Settings.Default.Save();
        }

        private void stopVideoSources()
        {
            if (videoSource1 != null)
            {
                videoSource1.SignalToStop();
                videoSource1.Stop();
            }

            if (videoSource2 != null)
            {
                videoSource2.SignalToStop();
                videoSource2.Stop();
            }

            if (videoSource3 != null)
            {
                videoSource3.SignalToStop();
                videoSource3.Stop();
            }

            if (videoSource4 != null)
            {
                videoSource4.SignalToStop();
                videoSource4.Stop();
            }

            if (detector1 != null)
            {
                detector1 = null;
            }

            if (detector2 != null)
            {
                detector2 = null;
            }

            if (detector3 != null)
            {
                detector3 = null;
            }

            if (detector4 != null)
            {
                detector4 = null;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stopVideoSources();
            StopAlarmSound();
            resetStatusColorMotionText();
        }

        private void resetStatusColorMotionText()
        {
            pcbStatus1.BackColor = Color.Transparent;
            pcbStatus2.BackColor = Color.Transparent;
            pcbStatus3.BackColor = Color.Transparent;
            pcbStatus4.BackColor = Color.Transparent;
            txtDetectorLevel1.Text = "";
            txtDetectorLevel2.Text = "";
            txtDetectorLevel3.Text = "";
            txtDetectorLevel4.Text = "";
        }

        private void StopAlarmSound()
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
                StopAlarmSound();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("No sound playing" + ex.Message);
            }
        }

        private void btnResetDetector_Click(object sender, EventArgs e)
        {
            resetMotionDetectors();
            resetStatusColorMotionText();
        }

        private void resetMotionDetectors()
        {
            if (detector1 != null)
            {
                detector1 = null;
            }

            if (detector2 != null)
            {
                detector2 = null;
            }

            if (detector3 != null)
            {
                detector3 = null;
            }

            if (detector4 != null)
            {
                detector4 = null;
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
            InteractiveSettingsForm form = new InteractiveSettingsForm();
            form.ShowDialog();
        }

        private void suggestAnIdeaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuggestionForm form = new SuggestionForm();
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

        private void followMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FollowMeForm form = new FollowMeForm();
            form.ShowDialog();
        }
    }
}