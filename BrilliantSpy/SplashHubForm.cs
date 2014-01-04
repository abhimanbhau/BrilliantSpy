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
    public partial class SplashHubForm : MetroForm
    {
        public bool isLogin = false;

        public SplashHubForm()
        {
            InitializeComponent();
        }

        private void SplashHubForm_Load(object sender, EventArgs e)
        {
            this.Style = Properties.Settings.Default.colorScheme;
            this.Theme = Properties.Settings.Default.theme;
        }

        private void tileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tileLogin_Click(object sender, EventArgs e)
        {
            isLogin = true;
            this.Close();
        }

        private void tileFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.facebook.com/abhimanbhau");
        }

        private void tileGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.github.com/abhimanbhau/BrilliantSpy");
        }
    }
}
