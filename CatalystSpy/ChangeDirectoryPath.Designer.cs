namespace WinSpy
{
    partial class ChangeDirectoryPath
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
            this.txtCurrentDirectoryPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewDirectoryPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnNewSet = new System.Windows.Forms.Button();
            this.selectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Path";
            // 
            // txtCurrentDirectoryPath
            // 
            this.txtCurrentDirectoryPath.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentDirectoryPath.Location = new System.Drawing.Point(12, 43);
            this.txtCurrentDirectoryPath.Name = "txtCurrentDirectoryPath";
            this.txtCurrentDirectoryPath.ReadOnly = true;
            this.txtCurrentDirectoryPath.Size = new System.Drawing.Size(286, 23);
            this.txtCurrentDirectoryPath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Path";
            // 
            // txtNewDirectoryPath
            // 
            this.txtNewDirectoryPath.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewDirectoryPath.Location = new System.Drawing.Point(12, 129);
            this.txtNewDirectoryPath.Name = "txtNewDirectoryPath";
            this.txtNewDirectoryPath.Size = new System.Drawing.Size(286, 23);
            this.txtNewDirectoryPath.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBrowse.Image = global::WinSpy.Properties.Resources.vallet;
            this.btnBrowse.Location = new System.Drawing.Point(12, 158);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(44, 40);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnNewSet
            // 
            this.btnNewSet.Location = new System.Drawing.Point(62, 158);
            this.btnNewSet.Name = "btnNewSet";
            this.btnNewSet.Size = new System.Drawing.Size(44, 40);
            this.btnNewSet.TabIndex = 5;
            this.btnNewSet.Text = "SET";
            this.btnNewSet.UseVisualStyleBackColor = true;
            this.btnNewSet.Click += new System.EventHandler(this.btnNewSet_Click);
            // 
            // ChangeDirectoryPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinSpy.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(310, 202);
            this.Controls.Add(this.btnNewSet);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtNewDirectoryPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCurrentDirectoryPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeDirectoryPath";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change   XYZ   Directory Path";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ChangeDirectoryPath_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCurrentDirectoryPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewDirectoryPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnNewSet;
        private System.Windows.Forms.FolderBrowserDialog selectFolder;
    }
}