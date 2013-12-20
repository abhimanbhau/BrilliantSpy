using System;
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
    public partial class SelectImageFolderForm : MetroForm
    {
        public SelectImageFolderForm()
        {
            InitializeComponent();
        }

        private void SelectImageFolderForm_Load(object sender, EventArgs e)
        {
            string[] folders = Directory.GetDirectories(Properties.Settings.Default.homeDirectory);
            if (folders.Length == 0)
            {
                lstFolders.Items.Add("No history folders available");
            }
            else
            {
                foreach (string dir in folders)
                {
                    if (DirectoryTools.getSize(dir) == 0)
                    {
                        continue;
                    }
                    else
                    {
                        lstFolders.Items.Add(dir);
                    }
                }
            }
        }

        private void btnSelectedFolder_Click(object sender, EventArgs e)
        {
            if (lstFolders.Text.Trim() == "")
            {
                MessageBox.Show(this, "Please select a folder from the list",
                    "Did you select a folder?",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else
            {
                ViewCapturedImagesForm form = new ViewCapturedImagesForm(lstFolders.Text);
                form.ShowDialog();
            }
        }
    }
}
