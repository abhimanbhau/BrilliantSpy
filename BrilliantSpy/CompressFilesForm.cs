using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ionic.Zip;
using System.IO;
using MetroFramework.Forms;

namespace BrilliantSpy
{
    public partial class CompressFilesForm : MetroForm
    {
        public CompressFilesForm()
        {
            InitializeComponent();
        }

        private void CompressFilesForm_Load(object sender, EventArgs e)
        {
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
            if (listFiles.Items.Count > 5)
            {
                MessageBox.Show(this, "You have selected more than '5' files" +
                    "Operation may take\n significant time" +
                " on slower/older machines", "Read Carefully", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            listFiles.Items.Clear();
            MessageBox.Show(this, "List is cleared", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCompressFiles_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Properties.Settings.Default.compressedFileDirectory))
            {
                Directory.CreateDirectory(Properties.Settings.Default.compressedFileDirectory);
            }
            try
            {
                string password = txtPassword.Text.Trim();
                using (ZipFile zip = new ZipFile())
                {
                    if (password.Length != 0)
                    {
                        zip.Password = password;
                    }
                    foreach (String path in openFileDialog.FileNames)
                    {
                        zip.AddFile(path);
                    }
                    zip.Save(Properties.Settings.Default.compressedFileDirectory + @"\" +
                        DateTime.UtcNow.ToShortDateString() + ".zip");
                }
                MessageBox.Show(this, "Files successfully compressed", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "There was an error in encrypting files" + ex.Message
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
