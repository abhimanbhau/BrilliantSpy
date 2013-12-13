namespace BrilliantSpy_MultiCam
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
            this.followMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.videoSourcePlayer2 = new AForge.Controls.VideoSourcePlayer();
            this.videoSourcePlayer3 = new AForge.Controls.VideoSourcePlayer();
            this.videoSourcePlayer4 = new AForge.Controls.VideoSourcePlayer();
            this.MainMenuStrip.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
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
            this.MainMenuStrip.Size = new System.Drawing.Size(1084, 24);
            this.MainMenuStrip.TabIndex = 2;
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
            // 
            // startFeedFromVideoToolStripMenuItem
            // 
            this.startFeedFromVideoToolStripMenuItem.Name = "startFeedFromVideoToolStripMenuItem";
            this.startFeedFromVideoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.startFeedFromVideoToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.startFeedFromVideoToolStripMenuItem.Text = "Start Feed From Video";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.exitToolStripMenuItem.Text = "Exit";
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
            // 
            // twoFrameDifferenceToolStripMenuItem
            // 
            this.twoFrameDifferenceToolStripMenuItem.Name = "twoFrameDifferenceToolStripMenuItem";
            this.twoFrameDifferenceToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.twoFrameDifferenceToolStripMenuItem.Text = "Two Frame Difference";
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.noneToolStripMenuItem.Text = "None";
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
            // 
            // borderToolStripMenuItem
            // 
            this.borderToolStripMenuItem.Name = "borderToolStripMenuItem";
            this.borderToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.borderToolStripMenuItem.Text = "Border";
            // 
            // gridMotionProcessingToolStripMenuItem
            // 
            this.gridMotionProcessingToolStripMenuItem.Name = "gridMotionProcessingToolStripMenuItem";
            this.gridMotionProcessingToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.gridMotionProcessingToolStripMenuItem.Text = "Grid Motion Processing";
            // 
            // blobCountingToolStripMenuItem
            // 
            this.blobCountingToolStripMenuItem.Name = "blobCountingToolStripMenuItem";
            this.blobCountingToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.blobCountingToolStripMenuItem.Text = "Blob Counting";
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
            this.viewPreviousImagesToolStripMenuItem.Name = "viewPreviousImagesToolStripMenuItem";
            this.viewPreviousImagesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.viewPreviousImagesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.viewPreviousImagesToolStripMenuItem.Text = "View Previous Images";
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
            // 
            // compressToolStripMenuItem
            // 
            this.compressToolStripMenuItem.Name = "compressToolStripMenuItem";
            this.compressToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.compressToolStripMenuItem.Text = "Compress";
            // 
            // preferancesToolStripMenuItem
            // 
            this.preferancesToolStripMenuItem.Name = "preferancesToolStripMenuItem";
            this.preferancesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.preferancesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.preferancesToolStripMenuItem.Text = "Preferences";
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
            // suggestAnIdeaToolStripMenuItem
            // 
            this.suggestAnIdeaToolStripMenuItem.Name = "suggestAnIdeaToolStripMenuItem";
            this.suggestAnIdeaToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.suggestAnIdeaToolStripMenuItem.Text = "Suggest an idea/Request a feature";
            // 
            // suggetionsToolStripMenuItem
            // 
            this.suggetionsToolStripMenuItem.Name = "suggetionsToolStripMenuItem";
            this.suggetionsToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.suggetionsToolStripMenuItem.Text = "Report Bug";
            // 
            // openSourceLicensesToolStripMenuItem
            // 
            this.openSourceLicensesToolStripMenuItem.Name = "openSourceLicensesToolStripMenuItem";
            this.openSourceLicensesToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.openSourceLicensesToolStripMenuItem.Text = "Open Source Licenses";
            // 
            // aboutMeToolStripMenuItem
            // 
            this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            this.aboutMeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutMeToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.aboutMeToolStripMenuItem.Text = "About Me";
            // 
            // followMeToolStripMenuItem
            // 
            this.followMeToolStripMenuItem.Name = "followMeToolStripMenuItem";
            this.followMeToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.followMeToolStripMenuItem.Text = "Follow Me";
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
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(880, 630);
            this.tableLayoutPanel.TabIndex = 3;
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
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BrilliantSpy_MultiCam.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.MainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindowForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrilliantSpy-MultiCam : Turns Your PC Into An Intelligent Spy";
            this.Load += new System.EventHandler(this.MainWindowForm_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem blobCountingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPreviousImagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem compressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suggestAnIdeaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suggetionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSourceLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem followMeToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer2;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer3;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer4;

    }
}

