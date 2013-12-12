namespace WinSpy
{
    partial class ChangeDirectoriesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSelectChangeDirectory = new System.Windows.Forms.ComboBox();
            this.btnChangeDirectory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Directory To Change Path";
            // 
            // cmbSelectChangeDirectory
            // 
            this.cmbSelectChangeDirectory.FormattingEnabled = true;
            this.cmbSelectChangeDirectory.Items.AddRange(new object[] {
            "HOME",
            "ENCRYPTION",
            "DECRYPTION",
            "COMPRESSION"});
            this.cmbSelectChangeDirectory.Location = new System.Drawing.Point(12, 38);
            this.cmbSelectChangeDirectory.Name = "cmbSelectChangeDirectory";
            this.cmbSelectChangeDirectory.Size = new System.Drawing.Size(216, 21);
            this.cmbSelectChangeDirectory.TabIndex = 1;
            // 
            // btnChangeDirectory
            // 
            this.btnChangeDirectory.Location = new System.Drawing.Point(234, 38);
            this.btnChangeDirectory.Name = "btnChangeDirectory";
            this.btnChangeDirectory.Size = new System.Drawing.Size(65, 21);
            this.btnChangeDirectory.TabIndex = 2;
            this.btnChangeDirectory.Text = "OK";
            this.btnChangeDirectory.UseVisualStyleBackColor = true;
            this.btnChangeDirectory.Click += new System.EventHandler(this.btnChangeDirectory_Click);
            // 
            // ChangeDirectoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinSpy.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(384, 71);
            this.Controls.Add(this.btnChangeDirectory);
            this.Controls.Add(this.cmbSelectChangeDirectory);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeDirectoriesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Directory(s) Path";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSelectChangeDirectory;
        private System.Windows.Forms.Button btnChangeDirectory;

    }
}