namespace BrilliantSpy
{
    partial class SplashHubForm
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
            this.tileLogin = new MetroFramework.Controls.MetroTile();
            this.tileExit = new MetroFramework.Controls.MetroTile();
            this.tileGuidedTour = new MetroFramework.Controls.MetroTile();
            this.tileFacebook = new MetroFramework.Controls.MetroTile();
            this.tileGithub = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // tileLogin
            // 
            this.tileLogin.ActiveControl = null;
            this.tileLogin.CustomBackground = false;
            this.tileLogin.CustomForeColor = false;
            this.tileLogin.Location = new System.Drawing.Point(23, 63);
            this.tileLogin.Name = "tileLogin";
            this.tileLogin.PaintTileCount = true;
            this.tileLogin.Size = new System.Drawing.Size(304, 133);
            this.tileLogin.Style = MetroFramework.MetroColorStyle.Orange;
            this.tileLogin.StyleManager = null;
            this.tileLogin.TabIndex = 0;
            this.tileLogin.Text = "Login";
            this.tileLogin.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tileLogin.TileCount = 0;
            this.tileLogin.Click += new System.EventHandler(this.tileLogin_Click);
            // 
            // tileExit
            // 
            this.tileExit.ActiveControl = null;
            this.tileExit.CustomBackground = false;
            this.tileExit.CustomForeColor = false;
            this.tileExit.Location = new System.Drawing.Point(333, 63);
            this.tileExit.Name = "tileExit";
            this.tileExit.PaintTileCount = true;
            this.tileExit.Size = new System.Drawing.Size(203, 133);
            this.tileExit.Style = MetroFramework.MetroColorStyle.Red;
            this.tileExit.StyleManager = null;
            this.tileExit.TabIndex = 1;
            this.tileExit.Text = "Exit";
            this.tileExit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tileExit.TileCount = 0;
            this.tileExit.Click += new System.EventHandler(this.tileExit_Click);
            // 
            // tileGuidedTour
            // 
            this.tileGuidedTour.ActiveControl = null;
            this.tileGuidedTour.CustomBackground = false;
            this.tileGuidedTour.CustomForeColor = false;
            this.tileGuidedTour.Location = new System.Drawing.Point(23, 202);
            this.tileGuidedTour.Name = "tileGuidedTour";
            this.tileGuidedTour.PaintTileCount = true;
            this.tileGuidedTour.Size = new System.Drawing.Size(227, 221);
            this.tileGuidedTour.Style = MetroFramework.MetroColorStyle.Purple;
            this.tileGuidedTour.StyleManager = null;
            this.tileGuidedTour.TabIndex = 2;
            this.tileGuidedTour.Text = "View Product Guided Tour";
            this.tileGuidedTour.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tileGuidedTour.TileCount = 0;
            // 
            // tileFacebook
            // 
            this.tileFacebook.ActiveControl = null;
            this.tileFacebook.CustomBackground = false;
            this.tileFacebook.CustomForeColor = false;
            this.tileFacebook.Location = new System.Drawing.Point(256, 283);
            this.tileFacebook.Name = "tileFacebook";
            this.tileFacebook.PaintTileCount = true;
            this.tileFacebook.Size = new System.Drawing.Size(140, 140);
            this.tileFacebook.Style = MetroFramework.MetroColorStyle.Blue;
            this.tileFacebook.StyleManager = null;
            this.tileFacebook.TabIndex = 4;
            this.tileFacebook.Text = "Facebook";
            this.tileFacebook.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tileFacebook.TileCount = 0;
            this.tileFacebook.Click += new System.EventHandler(this.tileFacebook_Click);
            // 
            // tileGithub
            // 
            this.tileGithub.ActiveControl = null;
            this.tileGithub.CustomBackground = false;
            this.tileGithub.CustomForeColor = false;
            this.tileGithub.Location = new System.Drawing.Point(402, 283);
            this.tileGithub.Name = "tileGithub";
            this.tileGithub.PaintTileCount = true;
            this.tileGithub.Size = new System.Drawing.Size(134, 140);
            this.tileGithub.Style = MetroFramework.MetroColorStyle.Teal;
            this.tileGithub.StyleManager = null;
            this.tileGithub.TabIndex = 5;
            this.tileGithub.Text = "Github";
            this.tileGithub.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tileGithub.TileCount = 0;
            this.tileGithub.Click += new System.EventHandler(this.tileGithub_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(269, 227);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(254, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Follow Project On FB/Github";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // SplashHubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 446);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tileGithub);
            this.Controls.Add(this.tileFacebook);
            this.Controls.Add(this.tileGuidedTour);
            this.Controls.Add(this.tileExit);
            this.Controls.Add(this.tileLogin);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashHubForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Welcome To BrilliantSpy";
            this.Load += new System.EventHandler(this.SplashHubForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileLogin;
        private MetroFramework.Controls.MetroTile tileExit;
        private MetroFramework.Controls.MetroTile tileGuidedTour;
        private MetroFramework.Controls.MetroTile tileFacebook;
        private MetroFramework.Controls.MetroTile tileGithub;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}