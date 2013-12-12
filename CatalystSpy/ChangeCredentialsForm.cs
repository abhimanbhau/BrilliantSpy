﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinSpy
{
    public partial class ChangeCredentialsForm : Form
    {
        public ChangeCredentialsForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
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

        private void ChangeCredentialsForm_Load(object sender, EventArgs e)
        {
            lblNote.Text = "Note : \n"
                + "Username and password both are case-sensitive";
        }
    }
}
