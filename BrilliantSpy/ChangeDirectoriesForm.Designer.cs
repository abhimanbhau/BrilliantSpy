﻿namespace BrilliantSpy
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnChangeDirectory = new MetroFramework.Controls.MetroButton();
            this.cmbSelectChangeDirectory = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 314F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnChangeDirectory, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbSelectChangeDirectory, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 82);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(408, 38);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnChangeDirectory
            // 
            this.btnChangeDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangeDirectory.Highlight = false;
            this.btnChangeDirectory.Location = new System.Drawing.Point(321, 5);
            this.btnChangeDirectory.Name = "btnChangeDirectory";
            this.btnChangeDirectory.Size = new System.Drawing.Size(82, 28);
            this.btnChangeDirectory.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnChangeDirectory.StyleManager = null;
            this.btnChangeDirectory.TabIndex = 2;
            this.btnChangeDirectory.Text = "OK";
            this.btnChangeDirectory.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnChangeDirectory.Click += new System.EventHandler(this.btnChangeDirectory_Click);
            // 
            // cmbSelectChangeDirectory
            // 
            this.cmbSelectChangeDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSelectChangeDirectory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSelectChangeDirectory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectChangeDirectory.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.cmbSelectChangeDirectory.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.cmbSelectChangeDirectory.FormattingEnabled = true;
            this.cmbSelectChangeDirectory.ItemHeight = 23;
            this.cmbSelectChangeDirectory.Items.AddRange(new object[] {
            "HOME",
            "ENCRYPTION",
            "DECRYPTION",
            "COMPRESSION"});
            this.cmbSelectChangeDirectory.Location = new System.Drawing.Point(5, 5);
            this.cmbSelectChangeDirectory.Name = "cmbSelectChangeDirectory";
            this.cmbSelectChangeDirectory.Size = new System.Drawing.Size(308, 29);
            this.cmbSelectChangeDirectory.Style = MetroFramework.MetroColorStyle.Blue;
            this.cmbSelectChangeDirectory.StyleManager = null;
            this.cmbSelectChangeDirectory.TabIndex = 3;
            this.cmbSelectChangeDirectory.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(19, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(219, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Select Directory to change its path";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = true;
            // 
            // ChangeDirectoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 130);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeDirectoriesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Change Directory(s) Path";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ChangeDirectoriesForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroButton btnChangeDirectory;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbSelectChangeDirectory;

    }
}