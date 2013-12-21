namespace BrilliantSpy
{
    partial class OpenSourceLicenseForm
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
            this.btnAForge = new System.Windows.Forms.Button();
            this.btnKellerman = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAForge
            // 
            this.btnAForge.Location = new System.Drawing.Point(12, 129);
            this.btnAForge.Name = "btnAForge";
            this.btnAForge.Size = new System.Drawing.Size(307, 23);
            this.btnAForge.TabIndex = 5;
            this.btnAForge.Text = "AForge.NET";
            this.btnAForge.UseVisualStyleBackColor = true;
            this.btnAForge.Click += new System.EventHandler(this.btnAForge_Click);
            // 
            // btnKellerman
            // 
            this.btnKellerman.Location = new System.Drawing.Point(12, 100);
            this.btnKellerman.Name = "btnKellerman";
            this.btnKellerman.Size = new System.Drawing.Size(307, 23);
            this.btnKellerman.TabIndex = 4;
            this.btnKellerman.Text = "Kellerman .Net Encryption Library";
            this.btnKellerman.UseVisualStyleBackColor = true;
            this.btnKellerman.Click += new System.EventHandler(this.btnKellerman_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "BrilliantSpy License";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenSourceLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 200);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAForge);
            this.Controls.Add(this.btnKellerman);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpenSourceLicenseForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Open Source Licenses";
            this.Load += new System.EventHandler(this.OpenSourceLicenseForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAForge;
        private System.Windows.Forms.Button btnKellerman;
        private System.Windows.Forms.Button button1;
    }
}