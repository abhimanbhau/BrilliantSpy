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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.listFiles = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.btnClearList = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEncryptFiles = new MetroFramework.Controls.MetroButton();
            this.btnDecryptFiles = new MetroFramework.Controls.MetroButton();
            this.radDesktopAlert = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
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
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(100, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(139, 29);
            this.txtPassword.TabIndex = 10;
            // 
            // listFiles
            // 
            this.listFiles.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFiles.ForeColor = System.Drawing.Color.RoyalBlue;
            this.listFiles.FormattingEnabled = true;
            this.listFiles.ItemHeight = 21;
            this.listFiles.Location = new System.Drawing.Point(12, 71);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(377, 172);
            this.listFiles.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnBrowse, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClearList, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(395, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(75, 172);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrowse.Highlight = false;
            this.btnBrowse.Location = new System.Drawing.Point(4, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(67, 78);
            this.btnBrowse.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnBrowse.StyleManager = null;
            this.btnBrowse.TabIndex = 14;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearList.Highlight = false;
            this.btnClearList.Location = new System.Drawing.Point(4, 89);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(67, 79);
            this.btnClearList.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnClearList.StyleManager = null;
            this.btnClearList.TabIndex = 15;
            this.btnClearList.Text = "Clear";
            this.btnClearList.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtPassword, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEncryptFiles, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDecryptFiles, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 249);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(377, 37);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // btnEncryptFiles
            // 
            this.btnEncryptFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEncryptFiles.Highlight = false;
            this.btnEncryptFiles.Location = new System.Drawing.Point(245, 3);
            this.btnEncryptFiles.Name = "btnEncryptFiles";
            this.btnEncryptFiles.Size = new System.Drawing.Size(62, 31);
            this.btnEncryptFiles.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnEncryptFiles.StyleManager = null;
            this.btnEncryptFiles.TabIndex = 15;
            this.btnEncryptFiles.Text = "Encrypt";
            this.btnEncryptFiles.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnEncryptFiles.Click += new System.EventHandler(this.btnEncryptFiles_Click);
            // 
            // btnDecryptFiles
            // 
            this.btnDecryptFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDecryptFiles.Highlight = false;
            this.btnDecryptFiles.Location = new System.Drawing.Point(313, 3);
            this.btnDecryptFiles.Name = "btnDecryptFiles";
            this.btnDecryptFiles.Size = new System.Drawing.Size(61, 31);
            this.btnDecryptFiles.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDecryptFiles.StyleManager = null;
            this.btnDecryptFiles.TabIndex = 16;
            this.btnDecryptFiles.Text = "Decrypt";
            this.btnDecryptFiles.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDecryptFiles.Click += new System.EventHandler(this.btnDecryptFiles_Click);
            // 
            // EncryptDecryptFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 303);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.listFiles);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EncryptDecryptFilesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "EncryptDecryptFilesForm";
            this.Load += new System.EventHandler(this.EncryptDecryptFilesForm_Load);
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
        private MetroFramework.Controls.MetroButton btnEncryptFiles;
        private MetroFramework.Controls.MetroButton btnDecryptFiles;
        private Telerik.WinControls.UI.RadDesktopAlert radDesktopAlert;
    }
}