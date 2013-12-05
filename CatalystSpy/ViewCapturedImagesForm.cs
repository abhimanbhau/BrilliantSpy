using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CatalystSpy
{
    public partial class ViewCapturedImagesForm : Form
    {
        string HistoryDBPath = Properties.Settings.Default.homeDirectory +
            "\\" + DateTime.UtcNow.ToShortDateString() + "\\";
        static string[] images;
        int position = 0;

        public ViewCapturedImagesForm()
        {
            InitializeComponent();
        }

        private void ViewCapturedImagesForm_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(HistoryDBPath))
            {
                images = Directory.GetFiles(Properties.Settings.Default.homeDirectory +
                    "\\" + DateTime.UtcNow.ToShortDateString()
                    + "\\");
            }
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            if (images.Length != 0)
            {
                HistoryViewer.Image = new Bitmap(images[position]);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ViewNextPicture();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ViewPreviousPicture();
        }

        private void ViewCapturedImagesForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left )
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
    }
}
