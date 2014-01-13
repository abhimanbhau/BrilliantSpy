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
            this.btnSelect = new MetroFramework.Controls.MetroButton();
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
            // btnSelect
            // 
            this.btnSelect.Highlight = false;
            this.btnSelect.Location = new System.Drawing.Point(259, 281);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSelect.StyleManager = null;
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // SelectImageFolderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 317);
            this.Controls.Add(this.btnSelect);
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
        private MetroFramework.Controls.MetroButton btnSelect;
    }
}