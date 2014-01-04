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
    public partial class OpenSourceLicenseForm : MetroForm
    {
        public OpenSourceLicenseForm()
        {
            InitializeComponent();
        }

        private void btnBrilliantSpy_Click(object sender, EventArgs e)
        {
            ViewLicenseForm form = new ViewLicenseForm("BrilliantSpy");
            form.ShowDialog();
        }

        private void btnAForge_Click_1(object sender, EventArgs e)
        {
            ViewLicenseForm form = new ViewLicenseForm("AForge");
            form.ShowDialog();
        }

        private void btnKellerman_Click_1(object sender, EventArgs e)
        {
            ViewLicenseForm form = new ViewLicenseForm("Kellerman");
            form.ShowDialog();
        }

        private void btnMetroFramework_Click(object sender, EventArgs e)
        {
            ViewLicenseForm form = new ViewLicenseForm("Metro");
            form.ShowDialog();
        }

        private void OpenSourceLicenseForm_Load(object sender, EventArgs e)
        {
            this.Style = Properties.Settings.Default.colorScheme;
            this.Theme = Properties.Settings.Default.theme;
        }
    }
}