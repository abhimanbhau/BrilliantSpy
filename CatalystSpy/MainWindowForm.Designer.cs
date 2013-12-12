namespace CatalystSpy
{
    partial class MainWindowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowForm));
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startFeedFromCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startFeedFromVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motionDetectionAlgorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleBackgroundModellingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoFrameDifferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highlightingAlgorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaHighlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridMotionProcessingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blobCountingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPreviousImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.compressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suggestAnIdeaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suggetionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSourceLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.btnStopAlarm = new System.Windows.Forms.Button();
            this.btnStopProcessing = new System.Windows.Forms.Button();
            this.lblDetectorLevel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chbEnableMotionDisplay = new System.Windows.Forms.CheckBox();
            this.txtCurrentMotion = new System.Windows.Forms.TextBox();
            this.MotionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pcbStatusPanel = new AForge.Controls.PictureBox();
            this.btnClearHistoryBox = new System.Windows.Forms.Button();
            this.btnSaveMotionHistory = new System.Windows.Forms.Button();
            this.btnRefreshDetectorLevel = new System.Windows.Forms.Button();
            this.HistoryList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStatusPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.motionDetectionAlgorithmToolStripMenuItem,
            this.highlightingAlgorithmToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(1008, 24);
            this.MainMenuStrip.TabIndex = 1;
            this.MainMenuStrip.Text = "MainMenuStrip";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startFeedFromCameraToolStripMenuItem,
            this.startFeedFromVideoToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // startFeedFromCameraToolStripMenuItem
            // 
            this.startFeedFromCameraToolStripMenuItem.Name = "startFeedFromCameraToolStripMenuItem";
            this.startFeedFromCameraToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.startFeedFromCameraToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.startFeedFromCameraToolStripMenuItem.Text = "Start Feed From Camera";
            this.startFeedFromCameraToolStripMenuItem.Click += new System.EventHandler(this.startFeedFromCameraToolStripMenuItem_Click);
            // 
            // startFeedFromVideoToolStripMenuItem
            // 
            this.startFeedFromVideoToolStripMenuItem.Name = "startFeedFromVideoToolStripMenuItem";
            this.startFeedFromVideoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.startFeedFromVideoToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.startFeedFromVideoToolStripMenuItem.Text = "Start Feed From Video";
            this.startFeedFromVideoToolStripMenuItem.Click += new System.EventHandler(this.startFeedFromVideoToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // motionDetectionAlgorithmToolStripMenuItem
            // 
            this.motionDetectionAlgorithmToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.motionDetectionAlgorithmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleBackgroundModellingToolStripMenuItem,
            this.twoFrameDifferenceToolStripMenuItem,
            this.noneToolStripMenuItem});
            this.motionDetectionAlgorithmToolStripMenuItem.Name = "motionDetectionAlgorithmToolStripMenuItem";
            this.motionDetectionAlgorithmToolStripMenuItem.Size = new System.Drawing.Size(169, 20);
            this.motionDetectionAlgorithmToolStripMenuItem.Text = "Motion Detection Algorithm";
            // 
            // simpleBackgroundModellingToolStripMenuItem
            // 
            this.simpleBackgroundModellingToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.simpleBackgroundModellingToolStripMenuItem.Name = "simpleBackgroundModellingToolStripMenuItem";
            this.simpleBackgroundModellingToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.simpleBackgroundModellingToolStripMenuItem.Text = "Simple Background Modelling";
            this.simpleBackgroundModellingToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.simpleBackgroundModellingToolStripMenuItem.Click += new System.EventHandler(this.simpleBackgroundModellingToolStripMenuItem_Click);
            // 
            // twoFrameDifferenceToolStripMenuItem
            // 
            this.twoFrameDifferenceToolStripMenuItem.Name = "twoFrameDifferenceToolStripMenuItem";
            this.twoFrameDifferenceToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.twoFrameDifferenceToolStripMenuItem.Text = "Two Frame Difference";
            this.twoFrameDifferenceToolStripMenuItem.Click += new System.EventHandler(this.twoFrameDifferenceToolStripMenuItem_Click);
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Image = global::CatalystSpy.Properties.Resources.None;
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.noneToolStripMenuItem.Text = "None";
            this.noneToolStripMenuItem.Click += new System.EventHandler(this.noneToolStripMenuItem_Click);
            // 
            // highlightingAlgorithmToolStripMenuItem
            // 
            this.highlightingAlgorithmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.areaHighlightToolStripMenuItem,
            this.borderToolStripMenuItem,
            this.gridMotionProcessingToolStripMenuItem,
            this.blobCountingToolStripMenuItem});
            this.highlightingAlgorithmToolStripMenuItem.Name = "highlightingAlgorithmToolStripMenuItem";
            this.highlightingAlgorithmToolStripMenuItem.Size = new System.Drawing.Size(175, 20);
            this.highlightingAlgorithmToolStripMenuItem.Text = "Motion Processing Algorithm";
            // 
            // areaHighlightToolStripMenuItem
            // 
            this.areaHighlightToolStripMenuItem.Name = "areaHighlightToolStripMenuItem";
            this.areaHighlightToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.areaHighlightToolStripMenuItem.Text = "Area Highlight";
            this.areaHighlightToolStripMenuItem.Click += new System.EventHandler(this.areaHighlightToolStripMenuItem_Click);
            // 
            // borderToolStripMenuItem
            // 
            this.borderToolStripMenuItem.Name = "borderToolStripMenuItem";
            this.borderToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.borderToolStripMenuItem.Text = "Border";
            this.borderToolStripMenuItem.Click += new System.EventHandler(this.borderToolStripMenuItem_Click);
            // 
            // gridMotionProcessingToolStripMenuItem
            // 
            this.gridMotionProcessingToolStripMenuItem.Name = "gridMotionProcessingToolStripMenuItem";
            this.gridMotionProcessingToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.gridMotionProcessingToolStripMenuItem.Text = "Grid Motion Processing";
            this.gridMotionProcessingToolStripMenuItem.Click += new System.EventHandler(this.gridMotionProcessingToolStripMenuItem_Click);
            // 
            // blobCountingToolStripMenuItem
            // 
            this.blobCountingToolStripMenuItem.Name = "blobCountingToolStripMenuItem";
            this.blobCountingToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.blobCountingToolStripMenuItem.Text = "Blob Counting";
            this.blobCountingToolStripMenuItem.Click += new System.EventHandler(this.blobCountingToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPreviousImagesToolStripMenuItem});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // viewPreviousImagesToolStripMenuItem
            // 
            this.viewPreviousImagesToolStripMenuItem.Image = global::CatalystSpy.Properties.Resources.Icon_320;
            this.viewPreviousImagesToolStripMenuItem.Name = "viewPreviousImagesToolStripMenuItem";
            this.viewPreviousImagesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.viewPreviousImagesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.viewPreviousImagesToolStripMenuItem.Text = "View Previous Images";
            this.viewPreviousImagesToolStripMenuItem.Click += new System.EventHandler(this.viewPreviousImagesToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem1,
            this.compressToolStripMenuItem,
            this.preferancesToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // toolsToolStripMenuItem1
            // 
            this.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
            this.toolsToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.toolsToolStripMenuItem1.Text = "Encrypt/Decrypt";
            this.toolsToolStripMenuItem1.Click += new System.EventHandler(this.toolsToolStripMenuItem1_Click);
            // 
            // compressToolStripMenuItem
            // 
            this.compressToolStripMenuItem.Name = "compressToolStripMenuItem";
            this.compressToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.compressToolStripMenuItem.Text = "Compress";
            this.compressToolStripMenuItem.Click += new System.EventHandler(this.compressToolStripMenuItem_Click);
            // 
            // preferancesToolStripMenuItem
            // 
            this.preferancesToolStripMenuItem.Name = "preferancesToolStripMenuItem";
            this.preferancesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.preferancesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.preferancesToolStripMenuItem.Text = "Preferences";
            this.preferancesToolStripMenuItem.Click += new System.EventHandler(this.preferancesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suggestAnIdeaToolStripMenuItem,
            this.suggetionsToolStripMenuItem,
            this.openSourceLicensesToolStripMenuItem,
            this.aboutMeToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // suggestAnIdeaToolStripMenuItem
            // 
            this.suggestAnIdeaToolStripMenuItem.Name = "suggestAnIdeaToolStripMenuItem";
            this.suggestAnIdeaToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.suggestAnIdeaToolStripMenuItem.Text = "Suggest an idea/Request a feature";
            this.suggestAnIdeaToolStripMenuItem.Click += new System.EventHandler(this.suggestAnIdeaToolStripMenuItem_Click);
            // 
            // suggetionsToolStripMenuItem
            // 
            this.suggetionsToolStripMenuItem.Name = "suggetionsToolStripMenuItem";
            this.suggetionsToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.suggetionsToolStripMenuItem.Text = "Report Bug";
            this.suggetionsToolStripMenuItem.Click += new System.EventHandler(this.suggetionsToolStripMenuItem_Click);
            // 
            // openSourceLicensesToolStripMenuItem
            // 
            this.openSourceLicensesToolStripMenuItem.Name = "openSourceLicensesToolStripMenuItem";
            this.openSourceLicensesToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.openSourceLicensesToolStripMenuItem.Text = "Open Source Licenses";
            this.openSourceLicensesToolStripMenuItem.Click += new System.EventHandler(this.openSourceLicensesToolStripMenuItem_Click);
            // 
            // aboutMeToolStripMenuItem
            // 
            this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            this.aboutMeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutMeToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.aboutMeToolStripMenuItem.Text = "About Me";
            this.aboutMeToolStripMenuItem.Click += new System.EventHandler(this.aboutMeToolStripMenuItem_Click);
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.Location = new System.Drawing.Point(0, 27);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(640, 480);
            this.videoSourcePlayer.TabIndex = 2;
            this.videoSourcePlayer.VideoSource = null;
            this.videoSourcePlayer.MouseHover += new System.EventHandler(this.videoSourcePlayer_MouseHover);
            // 
            // btnStopAlarm
            // 
            this.btnStopAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopAlarm.Location = new System.Drawing.Point(93, 630);
            this.btnStopAlarm.Name = "btnStopAlarm";
            this.btnStopAlarm.Size = new System.Drawing.Size(113, 23);
            this.btnStopAlarm.TabIndex = 18;
            this.btnStopAlarm.Text = "STOP ALARM";
            this.btnStopAlarm.UseVisualStyleBackColor = true;
            this.btnStopAlarm.Click += new System.EventHandler(this.btnStopAlarm_Click);
            this.btnStopAlarm.MouseHover += new System.EventHandler(this.btnStopAlarm_MouseHover);
            // 
            // btnStopProcessing
            // 
            this.btnStopProcessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopProcessing.Location = new System.Drawing.Point(12, 630);
            this.btnStopProcessing.Name = "btnStopProcessing";
            this.btnStopProcessing.Size = new System.Drawing.Size(75, 23);
            this.btnStopProcessing.TabIndex = 17;
            this.btnStopProcessing.Text = "STOP";
            this.btnStopProcessing.UseVisualStyleBackColor = true;
            this.btnStopProcessing.Click += new System.EventHandler(this.btnStopProcessing_Click);
            this.btnStopProcessing.MouseHover += new System.EventHandler(this.btnStopProcessing_MouseHover);
            // 
            // lblDetectorLevel
            // 
            this.lblDetectorLevel.AutoSize = true;
            this.lblDetectorLevel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetectorLevel.Location = new System.Drawing.Point(855, 316);
            this.lblDetectorLevel.Name = "lblDetectorLevel";
            this.lblDetectorLevel.Size = new System.Drawing.Size(80, 26);
            this.lblDetectorLevel.TabIndex = 25;
            this.lblDetectorLevel.Text = "aaaa";
            this.lblDetectorLevel.MouseHover += new System.EventHandler(this.lblDetectorLevel_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(847, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Detector Level";
            // 
            // chbEnableMotionDisplay
            // 
            this.chbEnableMotionDisplay.AutoSize = true;
            this.chbEnableMotionDisplay.Location = new System.Drawing.Point(675, 300);
            this.chbEnableMotionDisplay.Name = "chbEnableMotionDisplay";
            this.chbEnableMotionDisplay.Size = new System.Drawing.Size(59, 17);
            this.chbEnableMotionDisplay.TabIndex = 23;
            this.chbEnableMotionDisplay.Text = "Enable";
            this.chbEnableMotionDisplay.UseVisualStyleBackColor = true;
            this.chbEnableMotionDisplay.CheckedChanged += new System.EventHandler(this.chbEnableMotionDisplay_CheckedChanged);
            this.chbEnableMotionDisplay.MouseHover += new System.EventHandler(this.chbEnableMotionDisplay_MouseHover);
            // 
            // txtCurrentMotion
            // 
            this.txtCurrentMotion.Location = new System.Drawing.Point(674, 323);
            this.txtCurrentMotion.Name = "txtCurrentMotion";
            this.txtCurrentMotion.Size = new System.Drawing.Size(162, 20);
            this.txtCurrentMotion.TabIndex = 22;
            // 
            // MotionLabel
            // 
            this.MotionLabel.AutoSize = true;
            this.MotionLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotionLabel.Location = new System.Drawing.Point(670, 273);
            this.MotionLabel.Name = "MotionLabel";
            this.MotionLabel.Size = new System.Drawing.Size(171, 24);
            this.MotionLabel.TabIndex = 21;
            this.MotionLabel.Text = "Current Motion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(670, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Status";
            // 
            // pcbStatusPanel
            // 
            this.pcbStatusPanel.Image = null;
            this.pcbStatusPanel.Location = new System.Drawing.Point(674, 63);
            this.pcbStatusPanel.Name = "pcbStatusPanel";
            this.pcbStatusPanel.Size = new System.Drawing.Size(318, 197);
            this.pcbStatusPanel.TabIndex = 19;
            this.pcbStatusPanel.TabStop = false;
            this.pcbStatusPanel.MouseHover += new System.EventHandler(this.pcbStatusPanel_MouseHover);
            // 
            // btnClearHistoryBox
            // 
            this.btnClearHistoryBox.Image = global::CatalystSpy.Properties.Resources.clear;
            this.btnClearHistoryBox.Location = new System.Drawing.Point(901, 630);
            this.btnClearHistoryBox.Name = "btnClearHistoryBox";
            this.btnClearHistoryBox.Size = new System.Drawing.Size(48, 34);
            this.btnClearHistoryBox.TabIndex = 32;
            this.btnClearHistoryBox.UseVisualStyleBackColor = true;
            this.btnClearHistoryBox.Click += new System.EventHandler(this.btnClearHistoryBox_Click);
            // 
            // btnSaveMotionHistory
            // 
            this.btnSaveMotionHistory.Image = global::CatalystSpy.Properties.Resources.folder;
            this.btnSaveMotionHistory.Location = new System.Drawing.Point(955, 630);
            this.btnSaveMotionHistory.Name = "btnSaveMotionHistory";
            this.btnSaveMotionHistory.Size = new System.Drawing.Size(48, 34);
            this.btnSaveMotionHistory.TabIndex = 31;
            this.btnSaveMotionHistory.UseVisualStyleBackColor = true;
            this.btnSaveMotionHistory.Click += new System.EventHandler(this.btnSaveMotionHistory_Click);
            // 
            // btnRefreshDetectorLevel
            // 
            this.btnRefreshDetectorLevel.Location = new System.Drawing.Point(941, 319);
            this.btnRefreshDetectorLevel.Name = "btnRefreshDetectorLevel";
            this.btnRefreshDetectorLevel.Size = new System.Drawing.Size(26, 23);
            this.btnRefreshDetectorLevel.TabIndex = 30;
            this.btnRefreshDetectorLevel.Text = "R";
            this.btnRefreshDetectorLevel.UseVisualStyleBackColor = true;
            this.btnRefreshDetectorLevel.Click += new System.EventHandler(this.btnRefreshDetectorLevel_Click);
            // 
            // HistoryList
            // 
            this.HistoryList.FormattingEnabled = true;
            this.HistoryList.Location = new System.Drawing.Point(675, 412);
            this.HistoryList.Name = "HistoryList";
            this.HistoryList.Size = new System.Drawing.Size(328, 212);
            this.HistoryList.TabIndex = 29;
            this.HistoryList.MouseHover += new System.EventHandler(this.HistoryList_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(670, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Serious Motion History";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(147, 553);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(148, 30);
            this.lblWarning.TabIndex = 33;
            this.lblWarning.Text = "Warning";
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Open a video file to process";
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CatalystSpy.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(1008, 667);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnClearHistoryBox);
            this.Controls.Add(this.btnSaveMotionHistory);
            this.Controls.Add(this.btnRefreshDetectorLevel);
            this.Controls.Add(this.HistoryList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDetectorLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chbEnableMotionDisplay);
            this.Controls.Add(this.txtCurrentMotion);
            this.Controls.Add(this.MotionLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbStatusPanel);
            this.Controls.Add(this.btnStopAlarm);
            this.Controls.Add(this.btnStopProcessing);
            this.Controls.Add(this.videoSourcePlayer);
            this.Controls.Add(this.MainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindowForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CatalystSpy : Turns Your PC Into An Intelligent Spy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindowForm_FormClosing);
            this.Load += new System.EventHandler(this.MainWindowForm_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStatusPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startFeedFromCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startFeedFromVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motionDetectionAlgorithmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleBackgroundModellingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twoFrameDifferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highlightingAlgorithmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaHighlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridMotionProcessingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPreviousImagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem compressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suggetionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSourceLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer;
        private System.Windows.Forms.Button btnStopAlarm;
        private System.Windows.Forms.Button btnStopProcessing;
        private System.Windows.Forms.Label lblDetectorLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbEnableMotionDisplay;
        private System.Windows.Forms.TextBox txtCurrentMotion;
        private System.Windows.Forms.Label MotionLabel;
        private System.Windows.Forms.Label label1;
        private AForge.Controls.PictureBox pcbStatusPanel;
        private System.Windows.Forms.Button btnClearHistoryBox;
        private System.Windows.Forms.Button btnSaveMotionHistory;
        private System.Windows.Forms.Button btnRefreshDetectorLevel;
        private System.Windows.Forms.ListBox HistoryList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem preferancesToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.ToolStripMenuItem suggestAnIdeaToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem blobCountingToolStripMenuItem;
    }
}