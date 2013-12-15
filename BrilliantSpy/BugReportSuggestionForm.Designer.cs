namespace BrilliantSpy
{
    partial class BugReportSuggestionForm
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitle.Location = new System.Drawing.Point(132, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(390, 20);
            this.txtTitle.TabIndex = 7;
            // 
            // txtMessage
            // 
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Location = new System.Drawing.Point(132, 36);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(390, 200);
            this.txtMessage.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMessage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSubmit, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(527, 288);
            this.tableLayoutPanel1.TabIndex = 10;
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
            this.metroLabel1.Size = new System.Drawing.Size(119, 29);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Subject";
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
            this.metroLabel2.Location = new System.Drawing.Point(5, 33);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(119, 206);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Message";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSubmit.Highlight = false;
            this.btnSubmit.Location = new System.Drawing.Point(447, 244);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 39);
            this.btnSubmit.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnSubmit.StyleManager = null;
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // BugReportSuggestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BrilliantSpy.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(567, 368);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BugReportSuggestionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "BugReportForm";
            this.Load += new System.EventHandler(this.BugReportForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnSubmit;
    }
}