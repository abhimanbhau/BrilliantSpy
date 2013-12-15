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
    public partial class ChangeDirectoriesForm : MetroForm
    {
        public ChangeDirectoriesForm()
        {
            InitializeComponent();
        }

        private void btnChangeDirectory_Click(object sender, EventArgs e)
        {
            ChangeDirectoryPath form = new ChangeDirectoryPath(cmbSelectChangeDirectory.Text.ToString().
                Trim());
            form.Show();
        }

    }
}
