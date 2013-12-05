namespace CatalystSpy
{
    partial class ChangeHomeDirectoryForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnBrowseNewDirectory = new System.Windows.Forms.Button();
            this.txtNewDirectory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrentHomeDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Image = global::CatalystSpy.Properties.Resources.OK;
            this.btnOk.Location = new System.Drawing.Point(16, 212);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 34);
            this.btnOk.TabIndex = 11;
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnBrowseNewDirectory
            // 
            this.btnBrowseNewDirectory.Image = global::CatalystSpy.Properties.Resources.folder;
            this.btnBrowseNewDirectory.Location = new System.Drawing.Point(306, 137);
            this.btnBrowseNewDirectory.Name = "btnBrowseNewDirectory";
            this.btnBrowseNewDirectory.Size = new System.Drawing.Size(66, 43);
            this.btnBrowseNewDirectory.TabIndex = 10;
            this.btnBrowseNewDirectory.UseVisualStyleBackColor = true;
            // 
            // txtNewDirectory
            // 
            this.txtNewDirectory.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewDirectory.Location = new System.Drawing.Point(16, 142);
            this.txtNewDirectory.Name = "txtNewDirectory";
            this.txtNewDirectory.Size = new System.Drawing.Size(270, 30);
            this.txtNewDirectory.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "New Home Directory";
            // 
            // txtCurrentHomeDirectory
            // 
            this.txtCurrentHomeDirectory.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentHomeDirectory.Location = new System.Drawing.Point(16, 53);
            this.txtCurrentHomeDirectory.Name = "txtCurrentHomeDirectory";
            this.txtCurrentHomeDirectory.Size = new System.Drawing.Size(270, 30);
            this.txtCurrentHomeDirectory.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Current Storage Directory";
            // 
            // ChangeHomeDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CatalystSpy.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnBrowseNewDirectory);
            this.Controls.Add(this.txtNewDirectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCurrentHomeDirectory);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeHomeDirectoryForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeHomeDirectoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnBrowseNewDirectory;
        private System.Windows.Forms.TextBox txtNewDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurrentHomeDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog selectFolder;
    }
}