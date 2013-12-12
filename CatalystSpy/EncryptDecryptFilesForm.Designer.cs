namespace BrilliantSpy
{
    partial class EncryptDecryptFilesForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnDecryptFiles = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnEncryptFiles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.listFiles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Select Files to encrypt";
            this.openFileDialog.Multiselect = true;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(12, 252);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(44, 17);
            this.lblWarning.TabIndex = 15;
            this.lblWarning.Text = "AAA";
            // 
            // btnDecryptFiles
            // 
            this.btnDecryptFiles.Location = new System.Drawing.Point(324, 215);
            this.btnDecryptFiles.Name = "btnDecryptFiles";
            this.btnDecryptFiles.Size = new System.Drawing.Size(65, 25);
            this.btnDecryptFiles.TabIndex = 14;
            this.btnDecryptFiles.Text = "Decrypt";
            this.btnDecryptFiles.UseVisualStyleBackColor = true;
            this.btnDecryptFiles.Click += new System.EventHandler(this.btnDecryptFiles_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Image = global::BrilliantSpy.Properties.Resources.clear;
            this.btnClearList.Location = new System.Drawing.Point(395, 78);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(75, 50);
            this.btnClearList.TabIndex = 13;
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // btnEncryptFiles
            // 
            this.btnEncryptFiles.Location = new System.Drawing.Point(253, 215);
            this.btnEncryptFiles.Name = "btnEncryptFiles";
            this.btnEncryptFiles.Size = new System.Drawing.Size(65, 25);
            this.btnEncryptFiles.TabIndex = 12;
            this.btnEncryptFiles.Text = "Encrypt";
            this.btnEncryptFiles.UseVisualStyleBackColor = true;
            this.btnEncryptFiles.Click += new System.EventHandler(this.btnEncryptFiles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(109, 218);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(138, 20);
            this.txtPassword.TabIndex = 10;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Image = global::BrilliantSpy.Properties.Resources.vallet;
            this.btnBrowse.Location = new System.Drawing.Point(395, 22);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 50);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // listFiles
            // 
            this.listFiles.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFiles.ForeColor = System.Drawing.Color.RoyalBlue;
            this.listFiles.FormattingEnabled = true;
            this.listFiles.ItemHeight = 21;
            this.listFiles.Location = new System.Drawing.Point(12, 22);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(377, 172);
            this.listFiles.TabIndex = 8;
            // 
            // EncryptDecryptFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BrilliantSpy.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(482, 291);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnDecryptFiles);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnEncryptFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.listFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EncryptDecryptFilesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EncryptDecryptFilesForm";
            this.Load += new System.EventHandler(this.EncryptDecryptFilesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnDecryptFiles;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnEncryptFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ListBox listFiles;
    }
}