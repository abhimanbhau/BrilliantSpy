namespace BrilliantSpy
{
    partial class FirstRunForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstRunForm));
            this.btnChangeCredentials = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnChangeCredentials
            // 
            this.btnChangeCredentials.Highlight = false;
            this.btnChangeCredentials.Location = new System.Drawing.Point(20, 313);
            this.btnChangeCredentials.Name = "btnChangeCredentials";
            this.btnChangeCredentials.Size = new System.Drawing.Size(352, 35);
            this.btnChangeCredentials.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnChangeCredentials.StyleManager = null;
            this.btnChangeCredentials.TabIndex = 1;
            this.btnChangeCredentials.Text = "Click Here To Change Credentials";
            this.btnChangeCredentials.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnChangeCredentials.Click += new System.EventHandler(this.btnChangeCredentials_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(20, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(352, 247);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = resources.GetString("metroLabel1.Text");
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // FirstRunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 371);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnChangeCredentials);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FirstRunForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Initial Setup (Recommended)";
            this.Load += new System.EventHandler(this.FirstRunForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnChangeCredentials;
        private MetroFramework.Controls.MetroLabel metroLabel1;

    }
}