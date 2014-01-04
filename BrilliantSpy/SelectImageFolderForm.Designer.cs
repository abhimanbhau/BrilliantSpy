namespace BrilliantSpy
{
    partial class SelectImageFolderForm
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
            this.lstFolders = new System.Windows.Forms.ListBox();
            this.btnSelectedFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstFolders
            // 
            this.lstFolders.FormattingEnabled = true;
            this.lstFolders.Location = new System.Drawing.Point(16, 63);
            this.lstFolders.Name = "lstFolders";
            this.lstFolders.Size = new System.Drawing.Size(318, 212);
            this.lstFolders.TabIndex = 0;
            // 
            // btnSelectedFolder
            // 
            this.btnSelectedFolder.Location = new System.Drawing.Point(259, 281);
            this.btnSelectedFolder.Name = "btnSelectedFolder";
            this.btnSelectedFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSelectedFolder.TabIndex = 1;
            this.btnSelectedFolder.Text = "Select";
            this.btnSelectedFolder.UseVisualStyleBackColor = true;
            this.btnSelectedFolder.Click += new System.EventHandler(this.btnSelectedFolder_Click);
            // 
            // SelectImageFolderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 317);
            this.Controls.Add(this.btnSelectedFolder);
            this.Controls.Add(this.lstFolders);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectImageFolderForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Select Folder From list below";
            this.Load += new System.EventHandler(this.SelectImageFolderForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstFolders;
        private System.Windows.Forms.Button btnSelectedFolder;
    }
}