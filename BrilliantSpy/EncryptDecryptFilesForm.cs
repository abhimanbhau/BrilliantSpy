using System;
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
            openFileDialog.Filter = "BrilliantSpy Captured Image Files (*.bmp)|*.bmp";
            openFileDialog.InitialDirectory = Properties.Settings.Default.homeDirectory;
            openFileDialog.Multiselect = true;
        }

        private void btnDecryptFiles_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show(this, "Error in Decrypting files\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            listFiles.Items.Clear();
            lblWarning.Text = "";
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            listFiles.Items.Clear();
            lblWarning.Text = "";
            MessageBox.Show(this, "List is cleared", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEncryptFiles_Click(object sender, EventArgs e)
        {
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
            lblWarning.Text = "";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            foreach (string file in openFileDialog.FileNames)
            {
                listFiles.Items.Add(file);
            }
            if (listFiles.Items.Count > 5)
            {
                lblWarning.Text = "You have selected more than '5' files" +
                    "Operation may take\n significant time" +
                " on slower/older machines";
            }
        }
    }
}
