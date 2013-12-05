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
    public partial class ChangeHomeDirectoryForm : Form
    {
        public ChangeHomeDirectoryForm()
        {
            InitializeComponent();
        }

        private void ChangeHomeDirectoryForm_Load(object sender, EventArgs e)
        {
            txtCurrentHomeDirectory.Text = Properties.Settings.Default.homeDirectory;
            txtCurrentHomeDirectory.ReadOnly = true;
        }

        private void btnBrowseNewDirectory_Click(object sender, EventArgs e)
        {
            selectFolder.ShowDialog();
            txtNewDirectory.Text = selectFolder.SelectedPath;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this,
               "Are you sure to change directory\n" +
               "After you click ok, directory will be changed\n" +
               "and your current directory contents will be deleted",
               "Read note",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Hand
               )
               ==
               System.Windows.Forms.DialogResult.Cancel)
            {
                this.Close();
            }
            else
            {
                Directory.Delete(Properties.Settings.Default.homeDirectory, true);
                Properties.Settings.Default.homeDirectory = txtNewDirectory.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show(this, "Please restart the application immidiately",
                    "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }
    }
}
