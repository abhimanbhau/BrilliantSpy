using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CatalystSpy
{
    public partial class OpenSourceLicenseForm : Form
    {
        public OpenSourceLicenseForm()
        {
            InitializeComponent();
        }

        private void btnKellerman_Click(object sender, EventArgs e)
        {
            ViewLicenseForm form = new ViewLicenseForm("Kellerman");
            form.ShowDialog();
        }

        private void btnAForge_Click(object sender, EventArgs e)
        {
            ViewLicenseForm form = new ViewLicenseForm("AForge");
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewLicenseForm form = new ViewLicenseForm("CatalystSpy");
            form.ShowDialog();
        }
    }
}
