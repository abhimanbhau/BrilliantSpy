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
    public partial class ClearStorageDirectoriesForm : MetroForm
    {
        public ClearStorageDirectoriesForm()
        {
            InitializeComponent();
        }

        private void ClearStorageDirectoriesForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                if (chbHomeDirectory.Checked)
                {
                    if (MessageBox.Show(this, "If home directory is parent directory of other directories\n"
                        + "contents of all directories may get deleted\n"
                        + "DO YOU WANT TO PROCEED?", "Read carefully",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                        == System.Windows.Forms.DialogResult.Yes)
                    {
                        DirectoryTools.deleteDirectory(Properties.Settings.Default.homeDirectory);
                    }
                    else
                    {
                        return;
                    }
                }

                if (chbEncrypted.Checked)
                {
                    DirectoryTools.deleteDirectory(Properties.Settings.Default.encryptedFilesDirectory);
                }

                if (chbDecrypted.Checked)
                {
                    DirectoryTools.deleteDirectory(Properties.Settings.Default.decryptedFilesDirectory);
                }

                if (chbCompressed.Checked)
                {
                    DirectoryTools.deleteDirectory(Properties.Settings.Default.compressedFileDirectory);
                }

                MessageBox.Show(this, "Selected directories have been cleaned", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "There was error in processing your request" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
