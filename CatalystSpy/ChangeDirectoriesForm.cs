using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CatalystSpy
{
    public partial class ChangeDirectoriesForm : Form
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
