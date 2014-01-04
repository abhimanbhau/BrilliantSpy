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
    public partial class FirstRunForm : MetroForm
    {
        public FirstRunForm()
        {
            InitializeComponent();
        }

        private void FirstRunForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(this, "I see you are running the app for first time\n"
            + "Let's do the basic setup", "Initial setup(Recommended)",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Style = metroLabel1.Style = Properties.Settings.Default.colorScheme;
            this.Theme = metroLabel1.Theme = Properties.Settings.Default.theme;
        }

        private void btnChangeCredentials_Click(object sender, EventArgs e)
        {
            ChangeCredentialsForm form = new ChangeCredentialsForm();
            form.ShowDialog();
            this.Close();
        }
    }
}
