using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinSpy
{
    public partial class ViewLicenseForm : Form
    {
        string license;

        public ViewLicenseForm()
        {
            InitializeComponent();
        }

        public ViewLicenseForm(string whichLicense)
        {
            license = whichLicense;
            InitializeComponent();
        }

        private void ViewLicenseForm_Load(object sender, EventArgs e)
        {
            if (license == "WinSpy")
            {
                rtbLicenseView.Text = Properties.Resources.WinSpy_LICENSE;
                this.Text = "WinSpy License";
            }
            else if (license == "AForge")
            {
                rtbLicenseView.Text = Properties.Resources.Aforge_Net_License;
                this.Text = "AForge.Net Computer Vision Library License";
            }
            else
            {
                rtbLicenseView.Text = Properties.Resources.Aforge_Net_License;
                this.Text = "Kellerman .Net Encryption Library License";
            }
        }
    }
}
