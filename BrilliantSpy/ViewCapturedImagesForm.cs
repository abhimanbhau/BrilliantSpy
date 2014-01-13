using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MetroFramework.Forms;

namespace BrilliantSpy
{
    public partial class ViewCapturedImagesForm : MetroForm
    {
        string HistoryDBPath;
        static string[] images;
        int position = 0;

        public ViewCapturedImagesForm(string path)
        {
            InitializeComponent();
            HistoryDBPath = path;
        }

        private void ViewCapturedImagesForm_Load(object sender, EventArgs e)
        {
            this.Style = Properties.Settings.Default.colorScheme;
            this.Theme = Properties.Settings.Default.theme;

            images = Directory.GetFiles(HistoryDBPath + "\\", "*.*");
            if (images.Length != 0)
            {
                HistoryViewer.Image = new Bitmap(images[position]);
            }

        }

        private void ViewCapturedImagesForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey && e.KeyCode == Keys.Left)
            {
                ViewPreviousPicture();
            }
            else if (e.KeyCode == Keys.Right)
            {
                ViewNextPicture();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void ViewNextPicture()
        {
            if (images.Length == 0)
            {
                return;
            }
            int max_history = images.Length - 1;
            if (position == max_history)
            {
                return;
            }
            position++;
            HistoryViewer.Image = new Bitmap(images[position]);
        }

        private void ViewPreviousPicture()
        {
            if (position == 0)
                return;
            else
            {
                --position;
                HistoryViewer.Image = new Bitmap(images[position]);
            }
        }


        private void ViewCapturedImagesForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                ViewPreviousPicture();
            }
            else if (e.KeyCode == Keys.Right)
            {
                ViewNextPicture();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            ViewPreviousPicture();
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            ViewNextPicture();
        }
    }
}
