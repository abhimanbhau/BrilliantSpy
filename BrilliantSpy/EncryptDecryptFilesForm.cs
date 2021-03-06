﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace BrilliantSpy
{
    public partial class EncryptDecryptFilesForm : MetroForm
    {
        public EncryptDecryptFilesForm()
        {
            InitializeComponent();
        }

        private void EncryptDecryptFilesForm_Load(object sender, EventArgs e)
        {
            this.Style = metroLabel1.Style = btnBrowse.Style = btnClearList.Style
                = btnDecryptFiles.Style = btnEncryptFiles.Style
                = Properties.Settings.Default.colorScheme;
            this.Theme = metroLabel1.Theme = btnBrowse.Theme = btnClearList.Theme
                = btnDecryptFiles.Theme = btnEncryptFiles.Theme
                = Properties.Settings.Default.theme;

            openFileDialog.Filter = "BrilliantSpy Captured Image Files (*.bmp)|*.bmp";
            openFileDialog.InitialDirectory = Properties.Settings.Default.homeDirectory;
            openFileDialog.Multiselect = true;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            foreach (string file in openFileDialog.FileNames)
            {
                listFiles.Items.Add(file);
            }
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            listFiles.Items.Clear();
        }

        private void btnEncryptFiles_Click(object sender, EventArgs e)
        {
            if (listFiles.Items.Count == 0)
            {

                return;
            }
            try
            {
                foreach (object path in listFiles.Items)
                {
                    FileEncryptTools.encryptFile(path.ToString(), txtPassword.Text);
                }
                MessageBox.Show(this, "Successfully encrypted all selected image files\n"
                    + @"Encrypted files are stored in " + Properties.Settings.Default.homeDirectory +
                     @"\Encrypted directory", "Success"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error in encrypting files\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            listFiles.Items.Clear();
        }

        private void btnDecryptFiles_Click(object sender, EventArgs e)
        {
            if (listFiles.Items.Count == 0)
            {

                return;
            }
            try
            {
                foreach (object path in listFiles.Items)
                {
                    FileEncryptTools.decryptFile(path.ToString(), txtPassword.Text);
                }
                MessageBox.Show(this, "Successfully decrypted all selected image files\n"
                    + @"Decrypted files are stored in " +
                    Properties.Settings.Default.homeDirectory +
                    @"\decrypted " +
                    "directory",
                    "Success"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error in decrypting files" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            listFiles.Items.Clear();
        }
    }
}
