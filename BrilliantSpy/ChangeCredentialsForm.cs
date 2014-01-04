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
    public partial class ChangeCredentialsForm : MetroForm
    {
        public ChangeCredentialsForm()
        {
            InitializeComponent();
        }

        private void txtReverifyPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                changeCredentials();
            }
        }

        private void changeCredentials()
        {
            if (txtOldUsername.Text.Length == 0 || txtOldPassword.Text.Length == 0 ||
                txtNewUsername.Text.Length == 0 || txtNewPassword.Text.Length == 0)
            {
                MessageBox.Show(this, "Enter Valid Credentials", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            else if (txtNewPassword.Text != txtReverifyPassword.Text)
            {
                MessageBox.Show(this, "New Password and Re-enter password field do not match",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtOldPassword.Text.Trim() == txtNewPassword.Text.Trim())
            {
                MessageBox.Show(this, "The old password and new password are same",
                    "Enter different password",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool isValid = CredentialTools.validate(txtOldUsername.Text, txtOldPassword.Text);
                if (isValid)
                {
                    CredentialTools.changeCredentials(txtNewUsername.Text, txtNewPassword.Text);
                    MessageBox.Show(this, "Credentials Successfully Changed", "Success"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "Enter Correct username/password", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            changeCredentials();
        }

        private void ChangeCredentialsForm_Load(object sender, EventArgs e)
        {
            this.Style = Properties.Settings.Default.colorScheme;
            this.Theme = Properties.Settings.Default.theme;

            metroLabel1.Style = Properties.Settings.Default.colorScheme;
            metroLabel2.Style = Properties.Settings.Default.colorScheme;
            metroLabel3.Style = Properties.Settings.Default.colorScheme;
            metroLabel4.Style = Properties.Settings.Default.colorScheme;
            metroLabel5.Style = Properties.Settings.Default.colorScheme;
            metroLabel1.Theme = Properties.Settings.Default.theme;
            metroLabel2.Theme = Properties.Settings.Default.theme;
            metroLabel3.Theme = Properties.Settings.Default.theme;
            metroLabel4.Theme = Properties.Settings.Default.theme;
            metroLabel5.Theme = Properties.Settings.Default.theme;

            btnSubmit.Style = Properties.Settings.Default.colorScheme;
            btnSubmit.Theme = Properties.Settings.Default.theme;
        }
    }
}
