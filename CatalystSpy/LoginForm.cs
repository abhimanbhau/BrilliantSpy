using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinSpy
{
    public partial class LoginForm : Form
    {
        private bool loginSuccessfull = false;

        public bool getLoginStatus()
        {
            return loginSuccessfull;
        }

        public LoginForm()
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

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoLogin();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoLogin();
            }
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoLogin();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
