﻿namespace BrilliantSpy
{
    partial class CompressFilesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.listFiles = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.btnClearList = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCompressFiles = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Select Files to encrypt";
            this.openFileDialog.Multiselect = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(106, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(218, 29);
            this.txtPassword.TabIndex = 18;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listFiles
            // 
            this.listFiles.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFiles.ForeColor = System.Drawing.Color.RoyalBlue;
            this.listFiles.FormattingEnabled = true;
            this.listFiles.ItemHeight = 21;
            this.listFiles.Location = new System.Drawing.Point(12, 66);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(377, 172);
            this.listFiles.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnBrowse, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClearList, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(395, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(75, 172);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrowse.Highlight = false;
            this.btnBrowse.Location = new System.Drawing.Point(3, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(69, 80);
            this.btnBrowse.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnBrowse.StyleManager = null;
            this.btnBrowse.TabIndex = 22;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearList.Highlight = false;
            this.btnClearList.Location = new System.Drawing.Point(3, 89);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(69, 80);
            this.btnClearList.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnClearList.StyleManager = null;
            this.btnClearList.TabIndex = 23;
            this.btnClearList.Text = "Clear";
            this.btnClearList.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 224F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtPassword, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCompressFiles, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 244);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(458, 37);
            this.tableLayoutPanel2.TabIndex = 25;
            // 
            // btnCompressFiles
            // 
            this.btnCompressFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCompressFiles.Highlight = false;
            this.btnCompressFiles.Location = new System.Drawing.Point(332, 5);
            this.btnCompressFiles.Name = "btnCompressFiles";
            this.btnCompressFiles.Size = new System.Drawing.Size(121, 27);
            this.btnCompressFiles.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnCompressFiles.StyleManager = null;
            this.btnCompressFiles.TabIndex = 20;
            this.btnCompressFiles.Text = "Compress";
            this.btnCompressFiles.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCompressFiles.Click += new System.EventHandler(this.btnCompressFiles_Click);
            // 
            // CompressFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BrilliantSpy.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(485, 304);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.listFiles);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompressFilesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "CompressFilesForm";
            this.Load += new System.EventHandler(this.CompressFilesForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ListBox listFiles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private MetroFramework.Controls.MetroButton btnClearList;
        private MetroFramework.Controls.MetroButton btnCompressFiles;
    }
}