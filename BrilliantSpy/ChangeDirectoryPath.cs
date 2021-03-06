﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MetroFramework.Forms;

namespace BrilliantSpy
{
    public partial class ChangeDirectoryPath : MetroForm
    {
        private string directoryToChange;
        private string directoryToChangePath;

        public ChangeDirectoryPath(string directoryType)
        {
            InitializeComponent();
            directoryToChange = directoryType;
        }

        private void ChangeDirectoryPath_Load(object sender, EventArgs e)
        {
            this.Style = Properties.Settings.Default.colorScheme;
            this.Theme = Properties.Settings.Default.theme;

            metroLabel1.Style = Properties.Settings.Default.colorScheme;
            metroLabel2.Style = Properties.Settings.Default.colorScheme;
            metroLabel1.Theme = Properties.Settings.Default.theme;
            metroLabel2.Theme = Properties.Settings.Default.theme;

            txtCurrentDirectoryPath.Style = Properties.Settings.Default.colorScheme;
            txtNewDirectoryPath.Style = Properties.Settings.Default.colorScheme;
            txtNewDirectoryPath.Theme = Properties.Settings.Default.theme; ;
            txtCurrentDirectoryPath.Theme = Properties.Settings.Default.theme;

            btnBrowse.Style = Properties.Settings.Default.colorScheme;
            btnNewSet.Style = Properties.Settings.Default.colorScheme;
            btnBrowse.Theme = Properties.Settings.Default.theme;
            btnNewSet.Theme = Properties.Settings.Default.theme;

            switch (directoryToChange)
            {
                case "HOME":
                    this.Text = "Change Home Directory Path";
                    directoryToChangePath = Properties.Settings.Default.homeDirectory;
                    txtCurrentDirectoryPath.Text = directoryToChangePath;
                    break;

                case "ENCRYPTION":
                    this.Text = "Change Encryption Directory Path";
                    directoryToChangePath = Properties.Settings.Default.encryptedFilesDirectory;
                    txtCurrentDirectoryPath.Text = directoryToChangePath;
                    break;

                case "DECRYPTION":
                    this.Text = "Change Decryption Directory Path";
                    directoryToChangePath = Properties.Settings.Default.decryptedFilesDirectory;
                    txtCurrentDirectoryPath.Text = directoryToChangePath;
                    break;

                case "COMPRESSION":
                    this.Text = "Change Compression Directory Path";
                    directoryToChangePath = Properties.Settings.Default.compressedFileDirectory;
                    txtCurrentDirectoryPath.Text = directoryToChangePath;
                    break;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            selectFolder.RootFolder = Environment.SpecialFolder.Desktop;
            selectFolder.ShowNewFolderButton = true;
            selectFolder.ShowDialog();
            txtNewDirectoryPath.Text = selectFolder.SelectedPath;
        }

        private void btnNewSet_Click(object sender, EventArgs e)
        {
            switch (directoryToChange)
            {
                case "HOME":
                    if (MessageBox.Show(this,
                        "Are you sure to change directory\n" +
                        "After you click ok, directory will be changed\n",
                        "Read note", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) ==
                        System.Windows.Forms.DialogResult.Cancel)
                    {
                        break;
                    }
                    else
                    {
                        Properties.Settings.Default.homeDirectory = txtNewDirectoryPath.Text;
                        Properties.Settings.Default.Save();
                        MessageBox.Show(this, "Please restart the application immidiately",
                            "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                    break;

                case "ENCRYPTION":
                    if (MessageBox.Show(this,
                        "Are you sure to change directory\n" +
                        "After you click ok, directory will be changed\n",
                        "Read note", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) ==
                        System.Windows.Forms.DialogResult.Cancel)
                    {
                        this.Close();
                    }
                    else
                    {
                        Properties.Settings.Default.encryptedFilesDirectory = txtNewDirectoryPath.Text;
                        Properties.Settings.Default.Save();
                        MessageBox.Show(this, "Please restart the application immidiately",
                            "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                    break;

                case "DECRYPTION":
                    if (MessageBox.Show(this,
                        "Are you sure to change directory\n" +
                        "After you click ok, directory will be changed\n",
                        "Read note", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) ==
                        System.Windows.Forms.DialogResult.Cancel)
                    {
                        this.Close();
                    }
                    else
                    {
                        Properties.Settings.Default.decryptedFilesDirectory = txtNewDirectoryPath.Text;
                        Properties.Settings.Default.Save();
                        MessageBox.Show(this, "Please restart the application immidiately",
                            "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                    break;

                case "COMPRESSION":
                    if (MessageBox.Show(this,
                        "Are you sure to change directory\n" +
                        "After you click ok, directory will be changed\n",
                        "Read note", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) ==
                        System.Windows.Forms.DialogResult.Cancel)
                    {
                        this.Close();
                    }
                    else
                    {
                        Properties.Settings.Default.compressedFileDirectory = txtNewDirectoryPath.Text;
                        Properties.Settings.Default.Save();
                        MessageBox.Show(this, "Please restart the application immidiately",
                            "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                    break;
            }
        }
    }
}
