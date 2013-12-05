﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CatalystSpy
{
    public partial class LoginPageForm : Form
    {
        private bool loginSuccessfull = false;

        public bool getLoginStatus()
        {
            return loginSuccessfull;
        }

        public LoginPageForm()
        {
            InitializeComponent();
        }

        private void LoginPageForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void DoLogin()
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool isValid = CredentialTools.validate(username, password);
            if (isValid)
            {
                loginSuccessfull = true;
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Error in validation", "Username/Password is incorrect",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DoLogin();
        }
    }
}
