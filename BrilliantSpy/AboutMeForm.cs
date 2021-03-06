﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace BrilliantSpy
{
    partial class AboutMeForm : MetroForm
    {
        public AboutMeForm()
        {
            InitializeComponent();
            this.Text = String.Format("About {0}", AssemblyTitle);
            //this.labelProductName.Text = AssemblyProduct;
            //this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            //this.labelCopyright.Text = AssemblyCopyright;
            //this.labelCompanyName.Text = AssemblyCompany;
            //this.textBoxDescription.Text = AssemblyDescription;
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void AboutMeForm_Load(object sender, EventArgs e)
        {
            this.Theme = Properties.Settings.Default.theme;
            metroLabel1.Theme = Properties.Settings.Default.theme;
            metroLabel2.Theme = Properties.Settings.Default.theme;
            metroLabel3.Theme = Properties.Settings.Default.theme;
            metroLabel4.Theme = Properties.Settings.Default.theme;
            metroLink1.Theme = Properties.Settings.Default.theme;
            metroLink2.Theme = Properties.Settings.Default.theme;
            metroLink3.Theme = Properties.Settings.Default.theme;
            metroLink4.Theme = Properties.Settings.Default.theme;

            this.Style = Properties.Settings.Default.colorScheme;
            metroLabel1.Style = Properties.Settings.Default.colorScheme;
            metroLabel2.Style = Properties.Settings.Default.colorScheme;
            metroLabel3.Style = Properties.Settings.Default.colorScheme;
            metroLabel4.Style = Properties.Settings.Default.colorScheme;
            metroLink1.Style = Properties.Settings.Default.colorScheme;
            metroLink2.Style = Properties.Settings.Default.colorScheme;
            metroLink3.Style = Properties.Settings.Default.colorScheme;
            metroLink4.Style = Properties.Settings.Default.colorScheme;
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.facebook.com/abhimanbhau");
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.vit.edu");
        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:abhimanbhau@gmail.com");
        }

        private void metroLink4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.github.com/abhimanbhau");
        }

    }
}
