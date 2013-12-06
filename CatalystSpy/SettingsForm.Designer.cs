namespace CatalystSpy
{
    partial class SettingsForm
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
            this.btnChangeHomeDirectory = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnIsHiddenSet = new System.Windows.Forms.Button();
            this.cmbIsHidden = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSetCustomWarningMessage = new System.Windows.Forms.Button();
            this.txtCustomWarningMessage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnResetDefault = new System.Windows.Forms.Button();
            this.txtMotionLevel = new System.Windows.Forms.TextBox();
            this.btnChangeMotion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClearStorage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChangeHomeDirectory
            // 
            this.btnChangeHomeDirectory.Location = new System.Drawing.Point(372, 373);
            this.btnChangeHomeDirectory.Name = "btnChangeHomeDirectory";
            this.btnChangeHomeDirectory.Size = new System.Drawing.Size(75, 23);
            this.btnChangeHomeDirectory.TabIndex = 35;
            this.btnChangeHomeDirectory.Text = "Change";
            this.btnChangeHomeDirectory.UseVisualStyleBackColor = true;
            this.btnChangeHomeDirectory.Click += new System.EventHandler(this.btnChangeHomeDirectory_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(317, 21);
            this.label7.TabIndex = 34;
            this.label7.Text = "Change CatalystSpy Storage Directory";
            // 
            // btnIsHiddenSet
            // 
            this.btnIsHiddenSet.Image = global::CatalystSpy.Properties.Resources.OK;
            this.btnIsHiddenSet.Location = new System.Drawing.Point(372, 318);
            this.btnIsHiddenSet.Name = "btnIsHiddenSet";
            this.btnIsHiddenSet.Size = new System.Drawing.Size(75, 34);
            this.btnIsHiddenSet.TabIndex = 33;
            this.btnIsHiddenSet.UseVisualStyleBackColor = true;
            this.btnIsHiddenSet.Click += new System.EventHandler(this.btnIsHiddenSet_Click);
            // 
            // cmbIsHidden
            // 
            this.cmbIsHidden.FormattingEnabled = true;
            this.cmbIsHidden.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cmbIsHidden.Location = new System.Drawing.Point(254, 324);
            this.cmbIsHidden.Name = "cmbIsHidden";
            this.cmbIsHidden.Size = new System.Drawing.Size(111, 21);
            this.cmbIsHidden.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 21);
            this.label6.TabIndex = 31;
            this.label6.Text = "CatalystSpy Storage Hidden?";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSetCustomWarningMessage
            // 
            this.btnSetCustomWarningMessage.Image = global::CatalystSpy.Properties.Resources.OK;
            this.btnSetCustomWarningMessage.Location = new System.Drawing.Point(372, 275);
            this.btnSetCustomWarningMessage.Name = "btnSetCustomWarningMessage";
            this.btnSetCustomWarningMessage.Size = new System.Drawing.Size(75, 34);
            this.btnSetCustomWarningMessage.TabIndex = 30;
            this.btnSetCustomWarningMessage.UseVisualStyleBackColor = true;
            this.btnSetCustomWarningMessage.Click += new System.EventHandler(this.btnSetCustomWarningMessage_Click);
            // 
            // txtCustomWarningMessage
            // 
            this.txtCustomWarningMessage.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomWarningMessage.Location = new System.Drawing.Point(12, 281);
            this.txtCustomWarningMessage.Name = "txtCustomWarningMessage";
            this.txtCustomWarningMessage.Size = new System.Drawing.Size(350, 23);
            this.txtCustomWarningMessage.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "Custom Warning Message";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnResetDefault
            // 
            this.btnResetDefault.Location = new System.Drawing.Point(12, 413);
            this.btnResetDefault.Name = "btnResetDefault";
            this.btnResetDefault.Size = new System.Drawing.Size(94, 23);
            this.btnResetDefault.TabIndex = 27;
            this.btnResetDefault.Text = "Reset Default";
            this.btnResetDefault.UseVisualStyleBackColor = true;
            this.btnResetDefault.Click += new System.EventHandler(this.btnResetDefault_Click);
            // 
            // txtMotionLevel
            // 
            this.txtMotionLevel.Location = new System.Drawing.Point(295, 193);
            this.txtMotionLevel.Name = "txtMotionLevel";
            this.txtMotionLevel.Size = new System.Drawing.Size(71, 20);
            this.txtMotionLevel.TabIndex = 26;
            this.txtMotionLevel.Text = "0.2";
            // 
            // btnChangeMotion
            // 
            this.btnChangeMotion.Location = new System.Drawing.Point(372, 191);
            this.btnChangeMotion.Name = "btnChangeMotion";
            this.btnChangeMotion.Size = new System.Drawing.Size(75, 23);
            this.btnChangeMotion.TabIndex = 25;
            this.btnChangeMotion.Text = "Change";
            this.btnChangeMotion.UseVisualStyleBackColor = true;
            this.btnChangeMotion.Click += new System.EventHandler(this.btnChangeMotion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Change Motion Process Level";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(372, 137);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(75, 23);
            this.btnChangePassword.TabIndex = 23;
            this.btnChangePassword.Text = "Change";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Change Credentials";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClearStorage
            // 
            this.btnClearStorage.Location = new System.Drawing.Point(372, 78);
            this.btnClearStorage.Name = "btnClearStorage";
            this.btnClearStorage.Size = new System.Drawing.Size(75, 23);
            this.btnClearStorage.TabIndex = 21;
            this.btnClearStorage.Text = "Clear";
            this.btnClearStorage.UseVisualStyleBackColor = true;
            this.btnClearStorage.Click += new System.EventHandler(this.btnClearStorage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Clear CatalystSpy storage";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtsize
            // 
            this.txtsize.Location = new System.Drawing.Point(197, 23);
            this.txtsize.Name = "txtsize";
            this.txtsize.Size = new System.Drawing.Size(250, 20);
            this.txtsize.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Current Disk Usage";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CatalystSpy.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(459, 448);
            this.Controls.Add(this.btnChangeHomeDirectory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnIsHiddenSet);
            this.Controls.Add(this.cmbIsHidden);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSetCustomWarningMessage);
            this.Controls.Add(this.txtCustomWarningMessage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnResetDefault);
            this.Controls.Add(this.txtMotionLevel);
            this.Controls.Add(this.btnChangeMotion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClearStorage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsize);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsFormWindow";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeHomeDirectory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnIsHiddenSet;
        private System.Windows.Forms.ComboBox cmbIsHidden;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSetCustomWarningMessage;
        private System.Windows.Forms.TextBox txtCustomWarningMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnResetDefault;
        private System.Windows.Forms.TextBox txtMotionLevel;
        private System.Windows.Forms.Button btnChangeMotion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClearStorage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsize;
        private System.Windows.Forms.Label label1;
    }
}