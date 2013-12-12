namespace BrilliantSpy
{
    partial class FollowMeForm
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
            this.linkGithub = new System.Windows.Forms.LinkLabel();
            this.linkContactMe = new System.Windows.Forms.LinkLabel();
            this.linkDonate = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkGithub
            // 
            this.linkGithub.AutoSize = true;
            this.linkGithub.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkGithub.Location = new System.Drawing.Point(12, 27);
            this.linkGithub.Name = "linkGithub";
            this.linkGithub.Size = new System.Drawing.Size(202, 24);
            this.linkGithub.TabIndex = 0;
            this.linkGithub.TabStop = true;
            this.linkGithub.Text = "Follow On Github";
            this.linkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGithub_LinkClicked);
            // 
            // linkContactMe
            // 
            this.linkContactMe.AutoSize = true;
            this.linkContactMe.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkContactMe.Location = new System.Drawing.Point(12, 84);
            this.linkContactMe.Name = "linkContactMe";
            this.linkContactMe.Size = new System.Drawing.Size(212, 24);
            this.linkContactMe.TabIndex = 1;
            this.linkContactMe.TabStop = true;
            this.linkContactMe.Text = "Contact Me (Mail)";
            this.linkContactMe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkDonate
            // 
            this.linkDonate.AutoSize = true;
            this.linkDonate.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkDonate.Location = new System.Drawing.Point(11, 134);
            this.linkDonate.Name = "linkDonate";
            this.linkDonate.Size = new System.Drawing.Size(57, 27);
            this.linkDonate.TabIndex = 2;
            this.linkDonate.TabStop = true;
            this.linkDonate.Text = "aaa";
            this.linkDonate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkDonate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDonate_LinkClicked);
            // 
            // FollowMeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BrilliantSpy.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.linkDonate);
            this.Controls.Add(this.linkContactMe);
            this.Controls.Add(this.linkGithub);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FollowMeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Follow Me";
            this.Load += new System.EventHandler(this.FollowMeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkGithub;
        private System.Windows.Forms.LinkLabel linkContactMe;
        private System.Windows.Forms.LinkLabel linkDonate;
    }
}