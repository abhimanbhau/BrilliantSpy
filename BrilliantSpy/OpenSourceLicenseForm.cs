﻿using System;
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
            ViewLicenseForm form = new ViewLicenseForm("BrilliantSpy");
            form.ShowDialog();
        }

        private void OpenSourceLicenseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
