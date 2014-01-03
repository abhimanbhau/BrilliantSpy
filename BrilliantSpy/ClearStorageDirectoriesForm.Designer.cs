namespace BrilliantSpy
{
    partial class ClearStorageDirectoriesForm
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
            this.chbHomeDirectory = new MetroFramework.Controls.MetroCheckBox();
            this.chbCompressed = new MetroFramework.Controls.MetroCheckBox();
            this.chbDecrypted = new MetroFramework.Controls.MetroCheckBox();
            this.chbEncrypted = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.chbHomeDirectory, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.chbCompressed, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chbDecrypted, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chbEncrypted, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 82);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 100);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // chbHomeDirectory
            // 
            this.chbHomeDirectory.AutoSize = true;
            this.chbHomeDirectory.CustomBackground = false;
            this.chbHomeDirectory.CustomForeColor = false;
            this.chbHomeDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbHomeDirectory.FontSize = MetroFramework.MetroLinkSize.Small;
            this.chbHomeDirectory.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.chbHomeDirectory.Location = new System.Drawing.Point(3, 78);
            this.chbHomeDirectory.Name = "chbHomeDirectory";
            this.chbHomeDirectory.Size = new System.Drawing.Size(288, 19);
            this.chbHomeDirectory.Style = MetroFramework.MetroColorStyle.Blue;
            this.chbHomeDirectory.StyleManager = null;
            this.chbHomeDirectory.TabIndex = 3;
            this.chbHomeDirectory.Text = "Home Directory";
            this.chbHomeDirectory.Theme = MetroFramework.MetroThemeStyle.Light;
            this.chbHomeDirectory.UseStyleColors = false;
            this.chbHomeDirectory.UseVisualStyleBackColor = true;
            // 
            // chbCompressed
            // 
            this.chbCompressed.AutoSize = true;
            this.chbCompressed.CustomBackground = false;
            this.chbCompressed.CustomForeColor = false;
            this.chbCompressed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbCompressed.FontSize = MetroFramework.MetroLinkSize.Small;
            this.chbCompressed.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.chbCompressed.Location = new System.Drawing.Point(3, 53);
            this.chbCompressed.Name = "chbCompressed";
            this.chbCompressed.Size = new System.Drawing.Size(288, 19);
            this.chbCompressed.Style = MetroFramework.MetroColorStyle.Blue;
            this.chbCompressed.StyleManager = null;
            this.chbCompressed.TabIndex = 0;
            this.chbCompressed.Text = "Compressed Files Directory";
            this.chbCompressed.Theme = MetroFramework.MetroThemeStyle.Light;
            this.chbCompressed.UseStyleColors = false;
            this.chbCompressed.UseVisualStyleBackColor = true;
            // 
            // chbDecrypted
            // 
            this.chbDecrypted.AutoSize = true;
            this.chbDecrypted.CustomBackground = false;
            this.chbDecrypted.CustomForeColor = false;
            this.chbDecrypted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbDecrypted.FontSize = MetroFramework.MetroLinkSize.Small;
            this.chbDecrypted.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.chbDecrypted.Location = new System.Drawing.Point(3, 28);
            this.chbDecrypted.Name = "chbDecrypted";
            this.chbDecrypted.Size = new System.Drawing.Size(288, 19);
            this.chbDecrypted.Style = MetroFramework.MetroColorStyle.Blue;
            this.chbDecrypted.StyleManager = null;
            this.chbDecrypted.TabIndex = 2;
            this.chbDecrypted.Text = "Decrypted Files Directory";
            this.chbDecrypted.Theme = MetroFramework.MetroThemeStyle.Light;
            this.chbDecrypted.UseStyleColors = false;
            this.chbDecrypted.UseVisualStyleBackColor = true;
            // 
            // chbEncrypted
            // 
            this.chbEncrypted.AutoSize = true;
            this.chbEncrypted.CustomBackground = false;
            this.chbEncrypted.CustomForeColor = false;
            this.chbEncrypted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbEncrypted.FontSize = MetroFramework.MetroLinkSize.Small;
            this.chbEncrypted.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.chbEncrypted.Location = new System.Drawing.Point(3, 3);
            this.chbEncrypted.Name = "chbEncrypted";
            this.chbEncrypted.Size = new System.Drawing.Size(288, 19);
            this.chbEncrypted.Style = MetroFramework.MetroColorStyle.Blue;
            this.chbEncrypted.StyleManager = null;
            this.chbEncrypted.TabIndex = 1;
            this.chbEncrypted.Text = "Encrypted Files Directory";
            this.chbEncrypted.Theme = MetroFramework.MetroThemeStyle.Light;
            this.chbEncrypted.UseStyleColors = false;
            this.chbEncrypted.UseVisualStyleBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(155, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Select Directory To Clean";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // btnClear
            // 
            this.btnClear.Highlight = false;
            this.btnClear.Location = new System.Drawing.Point(227, 188);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 30);
            this.btnClear.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnClear.StyleManager = null;
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "GO";
            this.btnClear.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ClearStorageDirectoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 225);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClearStorageDirectoriesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Select Directories to Wipe Out";
            this.TextAlign = MetroFramework.Forms.TextAlign.Center;
            this.Load += new System.EventHandler(this.ClearStorageDirectoriesForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroCheckBox chbCompressed;
        private MetroFramework.Controls.MetroCheckBox chbEncrypted;
        private MetroFramework.Controls.MetroCheckBox chbDecrypted;
        private MetroFramework.Controls.MetroCheckBox chbHomeDirectory;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnClear;
    }
}