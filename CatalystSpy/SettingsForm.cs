using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CatalystSpy
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (!(Directory.Exists(Properties.Settings.Default.homeDirectory)))
            {
                Directory.CreateDirectory(Properties.Settings.Default.homeDirectory);
            }
            long size = DirectoryTools.getSize(Properties.Settings.Default.homeDirectory);
            if (size != 0)
            {
                size = size / 1024;
                txtsize.Text = size.ToString() + " KBytes | " + ((float)size / 1024).ToString()
                    + " MBytes";
            }
            else
                txtsize.Text = "Currently using no bit";
        }

        private void btnClearStorage_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Really want to delete?", "Action can't be undone",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
               System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    DirectoryTools.deleteDirectory(Properties.Settings.Default.homeDirectory);
                    MessageBox.Show(this, "Successfully cleared storage", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtsize.Text = "Currently using no bit";
                }
                catch (DirectoryNotFoundException ex)
                {
                    MessageBox.Show(this, "Already Cleared\n" + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangeCredentialsForm form = new ChangeCredentialsForm();
            form.ShowDialog();
        }

        private void btnChangeMotion_Click(object sender, EventArgs e)
        {
            try
            {
                double motionLevel = Double.Parse(txtMotionLevel.Text.Trim());
                Properties.Settings.Default.motionLevel = motionLevel;
                Properties.Settings.Default.Save();
                MessageBox.Show(this, "Detector Process Level saved successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Invalid value\nThe value must be valid float or double\n" +
                ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnSetCustomWarningMessage_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.customWarningMessage = txtCustomWarningMessage.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show(this, "Custom warning message saved successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnIsHiddenSet_Click(object sender, EventArgs e)
        {
            switch (cmbIsHidden.Text)
            {
                case "YES":
                    Properties.Settings.Default.isDirectoryHidden = true;
                    Properties.Settings.Default.Save();
                    break;
                case "NO":
                    Properties.Settings.Default.isDirectoryHidden = false;
                    Properties.Settings.Default.Save();
                    break;
            }
            MessageBox.Show(this, "Parameter successfully saved\nRestart for changes to happen", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnChangeHomeDirectory_Click(object sender, EventArgs e)
        {
            ChangeHomeDirectoryForm form = new ChangeHomeDirectoryForm();
            form.ShowDialog();
        }
    }
}
