using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace BrilliantSpy
{
    public partial class InteractiveSettingsForm : MetroForm
    {
        public InteractiveSettingsForm()
        {
            InitializeComponent();

        }

        private void InteractiveSettingsForm_Load(object sender, EventArgs e)
        {
            if (!(Directory.Exists(Properties.Settings.Default.homeDirectory)))
            {
                Directory.CreateDirectory(Properties.Settings.Default.homeDirectory);
            }

            calculateSpaceUsage();
        }

        private void calculateSpaceUsage()
        {
            long size = DirectoryTools.getSize(Properties.Settings.Default.homeDirectory);

            if (size != 0 && size < 5242880000)
            {
                txtCurrentUsage.Text = (size / 1024).ToString() + " KBytes";
            }
            else if (size > 5242880000)
            {
                txtCurrentUsage.Text = ((size / 1024) / 1024).ToString() + " MBytes";
            }
            else
            {
                txtCurrentUsage.Text = "EMPTY";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.Save();
            }
        }

        private void btnClearStorage_Click(object sender, EventArgs e)
        {
            ClearStorageDirectoriesForm form = new ClearStorageDirectoriesForm();
            form.ShowDialog();
        }

        private void btnSetColorScheme_Click(object sender, EventArgs e)
        {
            switch (cmbColorScheme.Text.ToString())
            {
                case "BLACK":
                    Properties.Settings.Default.colorScheme = MetroFramework.MetroColorStyle.Black;
                    break;

                case "WHITE":
                    Properties.Settings.Default.colorScheme = MetroFramework.MetroColorStyle.White;
                    break;

                case "SILVER":
                    Properties.Settings.Default.colorScheme = MetroFramework.MetroColorStyle.Silver;
                    break;

                case "BLUE":
                    Properties.Settings.Default.colorScheme = MetroFramework.MetroColorStyle.Blue;
                    break;

                case "GREEN":
                    Properties.Settings.Default.colorScheme = MetroFramework.MetroColorStyle.Green;
                    break;

                case "LIME":
                    Properties.Settings.Default.colorScheme = MetroFramework.MetroColorStyle.Lime;
                    break;

                case "TEAL":
                    Properties.Settings.Default.colorScheme = MetroFramework.MetroColorStyle.Teal;
                    break;

                case "ORANGE":
                    Properties.Settings.Default.colorScheme = MetroFramework.MetroColorStyle.Orange;
                    break;

                case "BROWN":
                    Properties.Settings.Default.colorScheme = MetroFramework.MetroColorStyle.Brown;
                    break;

                case "PINK":
                    Properties.Settings.Default.colorScheme = MetroFramework.MetroColorStyle.Pink;
                    break;

                case "MANGENTA":
                    Properties.Settings.Default.colorScheme = MetroFramework.MetroColorStyle.Magenta;
                    break;

                case "PURPLE":
                    Properties.Settings.Default.colorScheme = MetroFramework.MetroColorStyle.Purple;
                    break;

                case "RED":
                    Properties.Settings.Default.colorScheme = MetroFramework.MetroColorStyle.Red;
                    break;

                case "YELLOW":
                    Properties.Settings.Default.colorScheme = MetroFramework.MetroColorStyle.Yellow;
                    break;

                default:
                    MessageBox.Show(this, "Did You Select Valid Choice?", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            Properties.Settings.Default.Save();
            MessageBox.Show(this, "Restart to apply changes", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSetTheme_Click(object sender, EventArgs e)
        {
            switch (cmbTheme.Text.ToString())
            {
                case "Light":
                    Properties.Settings.Default.theme = MetroFramework.MetroThemeStyle.Light;
                    break;

                case "Dark":
                    Properties.Settings.Default.theme = MetroFramework.MetroThemeStyle.Dark;
                    break;

                default:
                    MessageBox.Show(this, "Did You Select Valid Choice?", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            Properties.Settings.Default.Save();
            MessageBox.Show(this, "Restart to apply changes", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
