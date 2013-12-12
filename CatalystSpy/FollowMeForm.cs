using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CatalystSpy
{
    public partial class FollowMeForm : Form
    {
        public FollowMeForm()
        {
            InitializeComponent();
        }

        private void linkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/abhimanbhau/CatalystSpy");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:koltebhau@gmail.com");
        }

        private void linkDonate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:abhimanbhau@gmail.com");
        }

        private void FollowMeForm_Load(object sender, EventArgs e)
        {
            linkDonate.Text = "You can donate me \nvia paypal.\nTo donate Click Here";
        }
    }
}
