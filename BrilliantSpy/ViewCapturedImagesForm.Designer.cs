namespace BrilliantSpy
{
    partial class ViewCapturedImagesForm
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
            this.HistoryViewer = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrevious = new MetroFramework.Controls.MetroButton();
            this.btnNext = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryViewer)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HistoryViewer
            // 
            this.HistoryViewer.Image = global::BrilliantSpy.Properties.Resources.NO_Image;
            this.HistoryViewer.Location = new System.Drawing.Point(12, 67);
            this.HistoryViewer.Name = "HistoryViewer";
            this.HistoryViewer.Size = new System.Drawing.Size(638, 480);
            this.HistoryViewer.TabIndex = 3;
            this.HistoryViewer.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnPrevious, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNext, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 553);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(638, 33);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrevious.Highlight = false;
            this.btnPrevious.Location = new System.Drawing.Point(5, 5);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(310, 23);
            this.btnPrevious.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnPrevious.StyleManager = null;
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.Text = "Back";
            this.btnPrevious.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNext.Highlight = false;
            this.btnNext.Location = new System.Drawing.Point(323, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(310, 23);
            this.btnNext.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnNext.StyleManager = null;
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // ViewCapturedImagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 609);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.HistoryViewer);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewCapturedImagesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "ViewHistoryForm";
            this.Load += new System.EventHandler(this.ViewCapturedImagesForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ViewCapturedImagesForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ViewCapturedImagesForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.HistoryViewer)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox HistoryViewer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroButton btnPrevious;
        private MetroFramework.Controls.MetroButton btnNext;
    }
}