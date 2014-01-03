using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using MetroFramework.Forms;

namespace BrilliantSpy
{
    public partial class BugReportSuggestionForm : MetroForm
    {
        FtpWebRequest request;

        public BugReportSuggestionForm()
        {
            InitializeComponent();
        }

        private void BugReportForm_Load(object sender, EventArgs e)
        {
            this.Style = Properties.Settings.Default.colorScheme;
            this.Theme = Properties.Settings.Default.theme;
            txtTitle.Style = Properties.Settings.Default.colorScheme;
            txtTitle.Theme = Properties.Settings.Default.theme;
            txtMessage.Style = Properties.Settings.Default.colorScheme;
            txtMessage.Theme = Properties.Settings.Default.theme;
            metroLabel1.Style = Properties.Settings.Default.colorScheme;
            metroLabel2.Style = Properties.Settings.Default.colorScheme;
            btnAdvancedReport.Style = Properties.Settings.Default.colorScheme;
            btnSubmit.Style = Properties.Settings.Default.colorScheme;
            metroLabel1.Theme = Properties.Settings.Default.theme;
            metroLabel2.Theme = Properties.Settings.Default.theme;
            btnAdvancedReport.Theme = Properties.Settings.Default.theme;
            btnSubmit.Theme = Properties.Settings.Default.theme;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = "abhimanbhau";
                string passWord = "kolte";
                Random rand = new Random();
                string fileName = rand.NextDouble().ToString();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(txtTitle.Text);
                sb.AppendLine(txtMessage.Text);
                File.WriteAllText(Properties.Settings.Default.homeDirectory +
                    @"\bugReport.txt", sb.ToString());
                request = WebRequest.Create(new Uri(Properties.Settings.Default.ftpIpAddress + fileName))
                    as FtpWebRequest;
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.UseBinary = true;
                request.UsePassive = true;
                request.KeepAlive = true;
                request.Credentials = new NetworkCredential(userName, passWord);
                request.ConnectionGroupName = "group";
                using (FileStream fs = File.OpenRead(Properties.Settings.Default.homeDirectory +
                    @"\bugReport.txt"))
                {
                    byte[] buffer = new byte[fs.Length];
                    fs.Read(buffer, 0, buffer.Length);
                    fs.Close();
                    Stream requestStream = request.GetRequestStream();
                    requestStream.Write(buffer, 0, buffer.Length);
                    requestStream.Close();
                    requestStream.Flush();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "There was an error sending bug report \n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdvancedReport_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "If you want to send any error logs or screenshot of"
                + " error or force close.\nUpload it on dropbox that will open after OK button pressed",
                "Thanks in advanced for your valuable suggestions",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.OK)
            {
                System.Diagnostics.Process.Start("http://www.drivehq.com/Dropbox/Dropbox.aspx?dropBoxID=94245865");
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
