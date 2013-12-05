namespace CatalystSpy
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnAForge
            // 
            this.btnAForge.Location = new System.Drawing.Point(12, 116);
            this.btnAForge.Name = "btnAForge";
            this.btnAForge.Size = new System.Drawing.Size(307, 23);
            this.btnAForge.TabIndex = 5;
            this.btnAForge.Text = "AForge.NET";
            this.btnAForge.UseVisualStyleBackColor = true;
            this.btnAForge.Click += new System.EventHandler(this.btnAForge_Click);
            // 
            // btnKellerman
            // 
            this.btnKellerman.Location = new System.Drawing.Point(12, 87);
            this.btnKellerman.Name = "btnKellerman";
            this.btnKellerman.Size = new System.Drawing.Size(307, 23);
            this.btnKellerman.TabIndex = 4;
            this.btnKellerman.Text = "Kellerman .Net Encryption Library";
            this.btnKellerman.UseVisualStyleBackColor = true;
            this.btnKellerman.Click += new System.EventHandler(this.btnKellerman_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(307, 58);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "This software is free to use and distribute,\n untill this copyright notice and \na" +
    "uthor\'s name(Abhiman Kolte) are mentioned in credits.";
            // 
            // OpenSourceLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CatalystSpy.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(331, 151);
            this.Controls.Add(this.btnAForge);
            this.Controls.Add(this.btnKellerman);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpenSourceLicenseForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open Source Licenses";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAForge;
        private System.Windows.Forms.Button btnKellerman;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}