using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BrilliantSpy
{
    public partial class FirstRunForm : InteractiveSettingsForm
    {
        public FirstRunForm()
        {
            InitializeComponent();
        }

        private void FirstRunForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(this, "As We can see you are running application for first time\n"
                + "So we recommend you to do initial setup\n"
                + "Default username and password is 'abhiman'\n"
                + "Its highly recommended that you do initial configuration for security purpose\n"
                + "Have a good day\n"
                + "Abhimanbhau Kolte", "Read carefully",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Text = "Initial configuration window";
        }
    }
}
