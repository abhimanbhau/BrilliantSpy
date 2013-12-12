﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace BrilliantSpy
{
    public partial class SuggestionForm : Form
    {
        FtpWebRequest request;

        public SuggestionForm()
        {
            InitializeComponent();
        }

        private void SuggestionForm_Load(object sender, EventArgs e)
        {
            //placeholder
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
                    @"\featureRequest.txt", sb.ToString());
                request = WebRequest.Create(new Uri(Properties.Settings.Default.ftpIpAddress + fileName))
                    as FtpWebRequest;
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.UseBinary = true;
                request.UsePassive = true;
                request.KeepAlive = true;
                request.Credentials = new NetworkCredential(userName, passWord);
                request.ConnectionGroupName = "group";
                using (FileStream fs = File.OpenRead(Properties.Settings.Default.homeDirectory +
                    @"\featureRequest.txt"))
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
    }
}