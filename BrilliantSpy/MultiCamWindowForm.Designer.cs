﻿namespace BrilliantSpy
{
    partial class MultiCamWindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiCamWindowForm));
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.videoSourcePlayer4 = new AForge.Controls.VideoSourcePlayer();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.videoSourcePlayer2 = new AForge.Controls.VideoSourcePlayer();
            this.videoSourcePlayer3 = new AForge.Controls.VideoSourcePlayer();
            this.followMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSourceLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suggetionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suggestAnIdeaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPreviousImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridMotionProcessingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaHighlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highlightingAlgorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blobCountingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoFrameDifferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleBackgroundModellingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motionDetectionAlgorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startFeedFromCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurrentMotion = new System.Windows.Forms.TextBox();
            this.txtDetectorLevel1 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.txtDetectorLevel2 = new System.Windows.Forms.TextBox();
            this.txtDetectorLevel3 = new System.Windows.Forms.TextBox();
            this.txtDetectorLevel4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pcbStatus1 = new AForge.Controls.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pcbStatus2 = new System.Windows.Forms.PictureBox();
            this.pcbStatus3 = new System.Windows.Forms.PictureBox();
            this.pcbStatus4 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStopAlarm = new System.Windows.Forms.Button();
            this.btnResetDetector = new System.Windows.Forms.Button();
            this.cam1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cam2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camera3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camera4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStatus1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStatus2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStatus3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStatus4)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourcePlayer1.KeepAspectRatio = true;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(3, 3);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(434, 309);
            this.videoSourcePlayer1.TabIndex = 0;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // videoSourcePlayer4
            // 
            this.videoSourcePlayer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourcePlayer4.KeepAspectRatio = true;
            this.videoSourcePlayer4.Location = new System.Drawing.Point(443, 318);
            this.videoSourcePlayer4.Name = "videoSourcePlayer4";
            this.videoSourcePlayer4.Size = new System.Drawing.Size(434, 309);
            this.videoSourcePlayer4.TabIndex = 3;
            this.videoSourcePlayer4.Text = "videoSourcePlayer4";
            this.videoSourcePlayer4.VideoSource = null;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.videoSourcePlayer1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.videoSourcePlayer2, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.videoSourcePlayer3, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.videoSourcePlayer4, 1, 1);
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(880, 630);
            this.tableLayoutPanel.TabIndex = 5;
            // 
            // videoSourcePlayer2
            // 
            this.videoSourcePlayer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourcePlayer2.KeepAspectRatio = true;
            this.videoSourcePlayer2.Location = new System.Drawing.Point(443, 3);
            this.videoSourcePlayer2.Name = "videoSourcePlayer2";
            this.videoSourcePlayer2.Size = new System.Drawing.Size(434, 309);
            this.videoSourcePlayer2.TabIndex = 1;
            this.videoSourcePlayer2.Text = "videoSourcePlayer2";
            this.videoSourcePlayer2.VideoSource = null;
            // 
            // videoSourcePlayer3
            // 
            this.videoSourcePlayer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourcePlayer3.KeepAspectRatio = true;
            this.videoSourcePlayer3.Location = new System.Drawing.Point(3, 318);
            this.videoSourcePlayer3.Name = "videoSourcePlayer3";
            this.videoSourcePlayer3.Size = new System.Drawing.Size(434, 309);
            this.videoSourcePlayer3.TabIndex = 2;
            this.videoSourcePlayer3.Text = "videoSourcePlayer3";
            this.videoSourcePlayer3.VideoSource = null;
            // 
            // followMeToolStripMenuItem
            // 
            this.followMeToolStripMenuItem.Image = global::BrilliantSpy.Properties.Resources.cloud;
            this.followMeToolStripMenuItem.Name = "followMeToolStripMenuItem";
            this.followMeToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.followMeToolStripMenuItem.Text = "Follow Me";
            // 
            // aboutMeToolStripMenuItem
            // 
            this.aboutMeToolStripMenuItem.Image = global::BrilliantSpy.Properties.Resources.user;
            this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            this.aboutMeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutMeToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.aboutMeToolStripMenuItem.Text = "About Me";
            // 
            // openSourceLicensesToolStripMenuItem
            // 
            this.openSourceLicensesToolStripMenuItem.Image = global::BrilliantSpy.Properties.Resources.world;
            this.openSourceLicensesToolStripMenuItem.Name = "openSourceLicensesToolStripMenuItem";
            this.openSourceLicensesToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.openSourceLicensesToolStripMenuItem.Text = "Open Source Licenses";
            // 
            // suggetionsToolStripMenuItem
            // 
            this.suggetionsToolStripMenuItem.Image = global::BrilliantSpy.Properties.Resources.pen;
            this.suggetionsToolStripMenuItem.Name = "suggetionsToolStripMenuItem";
            this.suggetionsToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.suggetionsToolStripMenuItem.Text = "Report Bug";
            // 
            // suggestAnIdeaToolStripMenuItem
            // 
            this.suggestAnIdeaToolStripMenuItem.Image = global::BrilliantSpy.Properties.Resources.bubble;
            this.suggestAnIdeaToolStripMenuItem.Name = "suggestAnIdeaToolStripMenuItem";
            this.suggestAnIdeaToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.suggestAnIdeaToolStripMenuItem.Text = "Suggest an idea/Request a feature";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suggestAnIdeaToolStripMenuItem,
            this.suggetionsToolStripMenuItem,
            this.openSourceLicensesToolStripMenuItem,
            this.aboutMeToolStripMenuItem,
            this.followMeToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // preferancesToolStripMenuItem
            // 
            this.preferancesToolStripMenuItem.Image = global::BrilliantSpy.Properties.Resources.settings;
            this.preferancesToolStripMenuItem.Name = "preferancesToolStripMenuItem";
            this.preferancesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.preferancesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.preferancesToolStripMenuItem.Text = "Preferences";
            // 
            // compressToolStripMenuItem
            // 
            this.compressToolStripMenuItem.Image = global::BrilliantSpy.Properties.Resources.data;
            this.compressToolStripMenuItem.Name = "compressToolStripMenuItem";
            this.compressToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.compressToolStripMenuItem.Text = "Compress";
            // 
            // toolsToolStripMenuItem1
            // 
            this.toolsToolStripMenuItem1.Image = global::BrilliantSpy.Properties.Resources.key;
            this.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
            this.toolsToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.toolsToolStripMenuItem1.Text = "Encrypt/Decrypt";
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
            // viewPreviousImagesToolStripMenuItem
            // 
            this.viewPreviousImagesToolStripMenuItem.Image = global::BrilliantSpy.Properties.Resources.photo;
            this.viewPreviousImagesToolStripMenuItem.Name = "viewPreviousImagesToolStripMenuItem";
            this.viewPreviousImagesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.viewPreviousImagesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.viewPreviousImagesToolStripMenuItem.Text = "View Previous Images";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPreviousImagesToolStripMenuItem});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // gridMotionProcessingToolStripMenuItem
            // 
            this.gridMotionProcessingToolStripMenuItem.Name = "gridMotionProcessingToolStripMenuItem";
            this.gridMotionProcessingToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.gridMotionProcessingToolStripMenuItem.Text = "Grid Motion Processing";
            // 
            // borderToolStripMenuItem
            // 
            this.borderToolStripMenuItem.Name = "borderToolStripMenuItem";
            this.borderToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.borderToolStripMenuItem.Text = "Border";
            // 
            // areaHighlightToolStripMenuItem
            // 
            this.areaHighlightToolStripMenuItem.Name = "areaHighlightToolStripMenuItem";
            this.areaHighlightToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.areaHighlightToolStripMenuItem.Text = "Area Highlight";
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
            // blobCountingToolStripMenuItem
            // 
            this.blobCountingToolStripMenuItem.Name = "blobCountingToolStripMenuItem";
            this.blobCountingToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.blobCountingToolStripMenuItem.Text = "Blob Counting";
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Image = global::BrilliantSpy.Properties.Resources.None;
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.noneToolStripMenuItem.Text = "None";
            // 
            // twoFrameDifferenceToolStripMenuItem
            // 
            this.twoFrameDifferenceToolStripMenuItem.Name = "twoFrameDifferenceToolStripMenuItem";
            this.twoFrameDifferenceToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.twoFrameDifferenceToolStripMenuItem.Text = "Two Frame Difference";
            // 
            // simpleBackgroundModellingToolStripMenuItem
            // 
            this.simpleBackgroundModellingToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.simpleBackgroundModellingToolStripMenuItem.Name = "simpleBackgroundModellingToolStripMenuItem";
            this.simpleBackgroundModellingToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.simpleBackgroundModellingToolStripMenuItem.Text = "Simple Background Modelling";
            this.simpleBackgroundModellingToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
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
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::BrilliantSpy.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // startFeedFromCameraToolStripMenuItem
            // 
            this.startFeedFromCameraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cam1ToolStripMenuItem,
            this.cam2ToolStripMenuItem,
            this.camera3ToolStripMenuItem,
            this.camera4ToolStripMenuItem});
            this.startFeedFromCameraToolStripMenuItem.Image = global::BrilliantSpy.Properties.Resources.camera;
            this.startFeedFromCameraToolStripMenuItem.Name = "startFeedFromCameraToolStripMenuItem";
            this.startFeedFromCameraToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.startFeedFromCameraToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.startFeedFromCameraToolStripMenuItem.Text = "Start Feed From Camera";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startFeedFromCameraToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
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
            this.MainMenuStrip.Size = new System.Drawing.Size(1180, 24);
            this.MainMenuStrip.TabIndex = 4;
            this.MainMenuStrip.Text = "MainMenuStrip";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCurrentMotion, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDetectorLevel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtDetectorLevel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDetectorLevel3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDetectorLevel4, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(883, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(285, 190);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Motion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCurrentMotion
            // 
            this.txtCurrentMotion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCurrentMotion.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentMotion.Location = new System.Drawing.Point(161, 6);
            this.txtCurrentMotion.Name = "txtCurrentMotion";
            this.txtCurrentMotion.ReadOnly = true;
            this.txtCurrentMotion.Size = new System.Drawing.Size(118, 29);
            this.txtCurrentMotion.TabIndex = 2;
            // 
            // txtDetectorLevel1
            // 
            this.txtDetectorLevel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDetectorLevel1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetectorLevel1.Location = new System.Drawing.Point(161, 43);
            this.txtDetectorLevel1.Name = "txtDetectorLevel1";
            this.txtDetectorLevel1.ReadOnly = true;
            this.txtDetectorLevel1.Size = new System.Drawing.Size(118, 29);
            this.txtDetectorLevel1.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(6, 40);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(146, 34);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Detector Level 1";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(6, 77);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(146, 34);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Detector Level 2";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel3.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.Location = new System.Drawing.Point(6, 114);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(146, 34);
            this.linkLabel3.TabIndex = 6;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Detector Level 3";
            this.linkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel4.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.Location = new System.Drawing.Point(6, 151);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(146, 36);
            this.linkLabel4.TabIndex = 7;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Detector Level 4";
            this.linkLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // txtDetectorLevel2
            // 
            this.txtDetectorLevel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDetectorLevel2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetectorLevel2.Location = new System.Drawing.Point(161, 80);
            this.txtDetectorLevel2.Name = "txtDetectorLevel2";
            this.txtDetectorLevel2.ReadOnly = true;
            this.txtDetectorLevel2.Size = new System.Drawing.Size(118, 29);
            this.txtDetectorLevel2.TabIndex = 8;
            // 
            // txtDetectorLevel3
            // 
            this.txtDetectorLevel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDetectorLevel3.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetectorLevel3.Location = new System.Drawing.Point(161, 117);
            this.txtDetectorLevel3.Name = "txtDetectorLevel3";
            this.txtDetectorLevel3.ReadOnly = true;
            this.txtDetectorLevel3.Size = new System.Drawing.Size(118, 29);
            this.txtDetectorLevel3.TabIndex = 9;
            // 
            // txtDetectorLevel4
            // 
            this.txtDetectorLevel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDetectorLevel4.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetectorLevel4.Location = new System.Drawing.Point(161, 154);
            this.txtDetectorLevel4.Name = "txtDetectorLevel4";
            this.txtDetectorLevel4.ReadOnly = true;
            this.txtDetectorLevel4.Size = new System.Drawing.Size(118, 29);
            this.txtDetectorLevel4.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 56);
            this.label3.TabIndex = 0;
            this.label3.Text = "Status 1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 201F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pcbStatus1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.pcbStatus2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.pcbStatus3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.pcbStatus4, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(883, 226);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(285, 224);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // pcbStatus1
            // 
            this.pcbStatus1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbStatus1.Image = null;
            this.pcbStatus1.Location = new System.Drawing.Point(87, 3);
            this.pcbStatus1.Name = "pcbStatus1";
            this.pcbStatus1.Size = new System.Drawing.Size(195, 50);
            this.pcbStatus1.TabIndex = 1;
            this.pcbStatus1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 56);
            this.label4.TabIndex = 2;
            this.label4.Text = "Status 2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 56);
            this.label5.TabIndex = 3;
            this.label5.Text = "Status 3";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 56);
            this.label6.TabIndex = 4;
            this.label6.Text = "Status 4";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbStatus2
            // 
            this.pcbStatus2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbStatus2.Location = new System.Drawing.Point(87, 59);
            this.pcbStatus2.Name = "pcbStatus2";
            this.pcbStatus2.Size = new System.Drawing.Size(195, 50);
            this.pcbStatus2.TabIndex = 5;
            this.pcbStatus2.TabStop = false;
            // 
            // pcbStatus3
            // 
            this.pcbStatus3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbStatus3.Location = new System.Drawing.Point(87, 115);
            this.pcbStatus3.Name = "pcbStatus3";
            this.pcbStatus3.Size = new System.Drawing.Size(195, 50);
            this.pcbStatus3.TabIndex = 6;
            this.pcbStatus3.TabStop = false;
            // 
            // pcbStatus4
            // 
            this.pcbStatus4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbStatus4.Location = new System.Drawing.Point(87, 171);
            this.pcbStatus4.Name = "pcbStatus4";
            this.pcbStatus4.Size = new System.Drawing.Size(195, 50);
            this.pcbStatus4.TabIndex = 7;
            this.pcbStatus4.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel3.Controls.Add(this.lstHistory, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnClear, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(883, 456);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(285, 154);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // lstHistory
            // 
            this.lstHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.Location = new System.Drawing.Point(3, 3);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(233, 148);
            this.lstHistory.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Image = global::BrilliantSpy.Properties.Resources.clear;
            this.btnClear.Location = new System.Drawing.Point(242, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(40, 148);
            this.btnClear.TabIndex = 1;
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33331F));
            this.tableLayoutPanel4.Controls.Add(this.btnStop, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnStopAlarm, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnResetDetector, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(886, 614);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(285, 40);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // btnStop
            // 
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStop.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(3, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(89, 34);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnStopAlarm
            // 
            this.btnStopAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStopAlarm.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopAlarm.Location = new System.Drawing.Point(98, 3);
            this.btnStopAlarm.Name = "btnStopAlarm";
            this.btnStopAlarm.Size = new System.Drawing.Size(89, 34);
            this.btnStopAlarm.TabIndex = 1;
            this.btnStopAlarm.Text = "STOP ALARM";
            this.btnStopAlarm.UseVisualStyleBackColor = true;
            // 
            // btnResetDetector
            // 
            this.btnResetDetector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResetDetector.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetDetector.Location = new System.Drawing.Point(193, 3);
            this.btnResetDetector.Name = "btnResetDetector";
            this.btnResetDetector.Size = new System.Drawing.Size(89, 34);
            this.btnResetDetector.TabIndex = 2;
            this.btnResetDetector.Text = "RESET";
            this.btnResetDetector.UseVisualStyleBackColor = true;
            // 
            // cam1ToolStripMenuItem
            // 
            this.cam1ToolStripMenuItem.Name = "cam1ToolStripMenuItem";
            this.cam1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cam1ToolStripMenuItem.Text = "Camera 1";
            this.cam1ToolStripMenuItem.Click += new System.EventHandler(this.cam1ToolStripMenuItem_Click);
            // 
            // cam2ToolStripMenuItem
            // 
            this.cam2ToolStripMenuItem.Name = "cam2ToolStripMenuItem";
            this.cam2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cam2ToolStripMenuItem.Text = "Camera 2";
            // 
            // camera3ToolStripMenuItem
            // 
            this.camera3ToolStripMenuItem.Name = "camera3ToolStripMenuItem";
            this.camera3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.camera3ToolStripMenuItem.Text = "Camera 3";
            // 
            // camera4ToolStripMenuItem
            // 
            this.camera4ToolStripMenuItem.Name = "camera4ToolStripMenuItem";
            this.camera4ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.camera4ToolStripMenuItem.Text = "Camera 4";
            // 
            // MultiCamWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BrilliantSpy.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(1180, 657);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.MainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MultiCamWindowForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrilliantSpy : Turns Your PC Into An Intelligent Spy";
            this.Load += new System.EventHandler(this.MultiCamWindowForm_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStatus1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStatus2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStatus3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStatus4)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer2;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer3;
        private System.Windows.Forms.ToolStripMenuItem followMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSourceLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suggetionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suggestAnIdeaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPreviousImagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridMotionProcessingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaHighlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highlightingAlgorithmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blobCountingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twoFrameDifferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleBackgroundModellingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motionDetectionAlgorithmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startFeedFromCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCurrentMotion;
        private System.Windows.Forms.TextBox txtDetectorLevel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private AForge.Controls.PictureBox pcbStatus1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pcbStatus2;
        private System.Windows.Forms.PictureBox pcbStatus3;
        private System.Windows.Forms.PictureBox pcbStatus4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.TextBox txtDetectorLevel2;
        private System.Windows.Forms.TextBox txtDetectorLevel3;
        private System.Windows.Forms.TextBox txtDetectorLevel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStopAlarm;
        private System.Windows.Forms.Button btnResetDetector;
        private System.Windows.Forms.ToolStripMenuItem cam1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cam2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camera3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camera4ToolStripMenuItem;

    }
}