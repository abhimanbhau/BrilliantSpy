namespace BrilliantSpy
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
            this.startFeedFromVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startFeedFromCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrentMotion = new System.Windows.Forms.TextBox();
            this.txtDetectorLevel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.statusPanel = new AForge.Controls.PictureBox();
            this.tableLayoutPanel.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            // startFeedFromVideoToolStripMenuItem
            // 
            this.startFeedFromVideoToolStripMenuItem.Image = global::BrilliantSpy.Properties.Resources.video;
            this.startFeedFromVideoToolStripMenuItem.Name = "startFeedFromVideoToolStripMenuItem";
            this.startFeedFromVideoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.startFeedFromVideoToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.startFeedFromVideoToolStripMenuItem.Text = "Start Feed From Video";
            // 
            // startFeedFromCameraToolStripMenuItem
            // 
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
            this.startFeedFromVideoToolStripMenuItem,
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCurrentMotion, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDetectorLevel, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(883, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(285, 79);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Motion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Detector Level";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCurrentMotion
            // 
            this.txtCurrentMotion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCurrentMotion.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentMotion.Location = new System.Drawing.Point(164, 6);
            this.txtCurrentMotion.Name = "txtCurrentMotion";
            this.txtCurrentMotion.ReadOnly = true;
            this.txtCurrentMotion.Size = new System.Drawing.Size(115, 29);
            this.txtCurrentMotion.TabIndex = 2;
            // 
            // txtDetectorLevel
            // 
            this.txtDetectorLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDetectorLevel.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetectorLevel.Location = new System.Drawing.Point(164, 44);
            this.txtDetectorLevel.Name = "txtDetectorLevel";
            this.txtDetectorLevel.ReadOnly = true;
            this.txtDetectorLevel.Size = new System.Drawing.Size(115, 29);
            this.txtDetectorLevel.TabIndex = 3;
            this.txtDetectorLevel.Click += new System.EventHandler(this.txtDetectorLevel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 224);
            this.label3.TabIndex = 0;
            this.label3.Text = "Status";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 201F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.statusPanel, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(883, 115);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(285, 224);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // statusPanel
            // 
            this.statusPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusPanel.Image = null;
            this.statusPanel.Location = new System.Drawing.Point(87, 3);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(195, 218);
            this.statusPanel.TabIndex = 1;
            this.statusPanel.TabStop = false;
            // 
            // MultiCamWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BrilliantSpy.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(1180, 657);
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
            ((System.ComponentModel.ISupportInitialize)(this.statusPanel)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem startFeedFromVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startFeedFromCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurrentMotion;
        private System.Windows.Forms.TextBox txtDetectorLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private AForge.Controls.PictureBox statusPanel;

    }
}