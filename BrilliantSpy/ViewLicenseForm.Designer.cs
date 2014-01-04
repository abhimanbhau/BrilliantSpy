namespace BrilliantSpy
{
    partial class ViewLicenseForm
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
            this.rtbLicenseView = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbLicenseView
            // 
            this.rtbLicenseView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbLicenseView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLicenseView.Location = new System.Drawing.Point(20, 60);
            this.rtbLicenseView.Name = "rtbLicenseView";
            this.rtbLicenseView.Size = new System.Drawing.Size(495, 361);
            this.rtbLicenseView.TabIndex = 1;
            this.rtbLicenseView.Text = "";
            // 
            // ViewLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 441);
            this.Controls.Add(this.rtbLicenseView);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewLicenseForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "ViewLicenseForm";
            this.Load += new System.EventHandler(this.ViewLicenseForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbLicenseView;

    }
}