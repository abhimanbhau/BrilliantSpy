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

        private void ChangeDirectoriesForm_Load(object sender, EventArgs e)
        {
            this.Style = Properties.Settings.Default.colorScheme;
            this.Theme = Properties.Settings.Default.theme;

            cmbSelectChangeDirectory.Theme = Properties.Settings.Default.theme;
            btnChangeDirectory.Theme = Properties.Settings.Default.theme;
            cmbSelectChangeDirectory.Style = Properties.Settings.Default.colorScheme;
            btnChangeDirectory.Style = Properties.Settings.Default.colorScheme;

            metroLabel1.Style = Properties.Settings.Default.colorScheme;
            metroLabel1.Theme = Properties.Settings.Default.theme;
        }

    }
}
