namespace BrilliantSpy
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnChangeDirectory = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Directory To Change Path";
            // 
            // cmbSelectChangeDirectory
            // 
            this.cmbSelectChangeDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSelectChangeDirectory.FormattingEnabled = true;
            this.cmbSelectChangeDirectory.Items.AddRange(new object[] {
            "HOME",
            "ENCRYPTION",
            "DECRYPTION",
            "COMPRESSION"});
            this.cmbSelectChangeDirectory.Location = new System.Drawing.Point(3, 3);
            this.cmbSelectChangeDirectory.Name = "cmbSelectChangeDirectory";
            this.cmbSelectChangeDirectory.Size = new System.Drawing.Size(308, 21);
            this.cmbSelectChangeDirectory.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 314F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cmbSelectChangeDirectory, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnChangeDirectory, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 106);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(408, 28);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnChangeDirectory
            // 
            this.btnChangeDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangeDirectory.Highlight = false;
            this.btnChangeDirectory.Location = new System.Drawing.Point(317, 3);
            this.btnChangeDirectory.Name = "btnChangeDirectory";
            this.btnChangeDirectory.Size = new System.Drawing.Size(88, 22);
            this.btnChangeDirectory.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnChangeDirectory.StyleManager = null;
            this.btnChangeDirectory.TabIndex = 2;
            this.btnChangeDirectory.Text = "OK";
            this.btnChangeDirectory.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnChangeDirectory.Click += new System.EventHandler(this.btnChangeDirectory_Click);
            // 
            // ChangeDirectoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BrilliantSpy.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(450, 157);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeDirectoriesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Change Directory(s) Path";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSelectChangeDirectory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroButton btnChangeDirectory;

    }
}