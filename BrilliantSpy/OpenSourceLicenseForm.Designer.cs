namespace BrilliantSpy
{
    partial class OpenSourceLicenseForm
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
            this.btnBrilliantSpy = new MetroFramework.Controls.MetroButton();
            this.btnKellerman = new MetroFramework.Controls.MetroButton();
            this.btnAForge = new MetroFramework.Controls.MetroButton();
            this.btnMetroFramework = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnBrilliantSpy, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnKellerman, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAForge, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMetroFramework, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(229, 144);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnBrilliantSpy
            // 
            this.btnBrilliantSpy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrilliantSpy.Highlight = false;
            this.btnBrilliantSpy.Location = new System.Drawing.Point(5, 5);
            this.btnBrilliantSpy.Name = "btnBrilliantSpy";
            this.btnBrilliantSpy.Size = new System.Drawing.Size(219, 27);
            this.btnBrilliantSpy.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnBrilliantSpy.StyleManager = null;
            this.btnBrilliantSpy.TabIndex = 0;
            this.btnBrilliantSpy.Text = "Brilliant Spy License";
            this.btnBrilliantSpy.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnBrilliantSpy.Click += new System.EventHandler(this.btnBrilliantSpy_Click);
            // 
            // btnKellerman
            // 
            this.btnKellerman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKellerman.Highlight = false;
            this.btnKellerman.Location = new System.Drawing.Point(5, 40);
            this.btnKellerman.Name = "btnKellerman";
            this.btnKellerman.Size = new System.Drawing.Size(219, 27);
            this.btnKellerman.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnKellerman.StyleManager = null;
            this.btnKellerman.TabIndex = 1;
            this.btnKellerman.Text = "Kellerman License";
            this.btnKellerman.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnKellerman.Click += new System.EventHandler(this.btnKellerman_Click_1);
            // 
            // btnAForge
            // 
            this.btnAForge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAForge.Highlight = false;
            this.btnAForge.Location = new System.Drawing.Point(5, 75);
            this.btnAForge.Name = "btnAForge";
            this.btnAForge.Size = new System.Drawing.Size(219, 27);
            this.btnAForge.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAForge.StyleManager = null;
            this.btnAForge.TabIndex = 2;
            this.btnAForge.Text = "AForge.NET License";
            this.btnAForge.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAForge.Click += new System.EventHandler(this.btnAForge_Click_1);
            // 
            // btnMetroFramework
            // 
            this.btnMetroFramework.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMetroFramework.Highlight = false;
            this.btnMetroFramework.Location = new System.Drawing.Point(5, 110);
            this.btnMetroFramework.Name = "btnMetroFramework";
            this.btnMetroFramework.Size = new System.Drawing.Size(219, 29);
            this.btnMetroFramework.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnMetroFramework.StyleManager = null;
            this.btnMetroFramework.TabIndex = 3;
            this.btnMetroFramework.Text = "Metro Framework License";
            this.btnMetroFramework.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnMetroFramework.Click += new System.EventHandler(this.btnMetroFramework_Click);
            // 
            // OpenSourceLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 224);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpenSourceLicenseForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Open Source Licenses";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroButton btnBrilliantSpy;
        private MetroFramework.Controls.MetroButton btnKellerman;
        private MetroFramework.Controls.MetroButton btnAForge;
        private MetroFramework.Controls.MetroButton btnMetroFramework;

    }
}