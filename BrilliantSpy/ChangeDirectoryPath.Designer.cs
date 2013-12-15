namespace BrilliantSpy
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
            this.txtCurrentDirectoryPath = new System.Windows.Forms.TextBox();
            this.txtNewDirectoryPath = new System.Windows.Forms.TextBox();
            this.selectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.btnNewSet = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCurrentDirectoryPath
            // 
            this.txtCurrentDirectoryPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCurrentDirectoryPath.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentDirectoryPath.Location = new System.Drawing.Point(150, 5);
            this.txtCurrentDirectoryPath.Name = "txtCurrentDirectoryPath";
            this.txtCurrentDirectoryPath.ReadOnly = true;
            this.txtCurrentDirectoryPath.Size = new System.Drawing.Size(191, 23);
            this.txtCurrentDirectoryPath.TabIndex = 1;
            // 
            // txtNewDirectoryPath
            // 
            this.txtNewDirectoryPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewDirectoryPath.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewDirectoryPath.Location = new System.Drawing.Point(150, 37);
            this.txtNewDirectoryPath.Name = "txtNewDirectoryPath";
            this.txtNewDirectoryPath.Size = new System.Drawing.Size(191, 23);
            this.txtNewDirectoryPath.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtCurrentDirectoryPath, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNewDirectoryPath, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(346, 106);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnBrowse, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnNewSet, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(150, 69);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(191, 32);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrowse.Highlight = false;
            this.btnBrowse.Location = new System.Drawing.Point(3, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(89, 26);
            this.btnBrowse.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnBrowse.StyleManager = null;
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnNewSet
            // 
            this.btnNewSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewSet.Highlight = false;
            this.btnNewSet.Location = new System.Drawing.Point(98, 3);
            this.btnNewSet.Name = "btnNewSet";
            this.btnNewSet.Size = new System.Drawing.Size(90, 26);
            this.btnNewSet.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnNewSet.StyleManager = null;
            this.btnNewSet.TabIndex = 7;
            this.btnNewSet.Text = "Set";
            this.btnNewSet.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnNewSet.Click += new System.EventHandler(this.btnNewSet_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(5, 2);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(137, 30);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Current Path";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = false;
            this.metroLabel2.CustomForeColor = false;
            this.metroLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel2.Location = new System.Drawing.Point(5, 34);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(137, 30);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "New Path";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = false;
            // 
            // ChangeDirectoryPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BrilliantSpy.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(386, 186);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeDirectoryPath";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Change   XYZ   Directory Path";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ChangeDirectoryPath_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurrentDirectoryPath;
        private System.Windows.Forms.TextBox txtNewDirectoryPath;
        private System.Windows.Forms.FolderBrowserDialog selectFolder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private MetroFramework.Controls.MetroButton btnNewSet;
    }
}