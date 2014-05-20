using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;

namespace DownloadFile
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (GetFileNameFromUrl(txtUri.Text) == "")
            {
                return;
            }

            if (rbtSync.Checked)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(new Uri(txtUri.Text), GetFileNameFromUrl(txtUri.Text));
                    MessageBox.Show("Download Complete (Synchrouns)", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start(Application.StartupPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rbtAsync.Checked)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                    webClient.DownloadFileAsync(new Uri(txtUri.Text), GetFileNameFromUrl(txtUri.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            pbDownload.Value = e.ProgressPercentage;
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Complete (Asynchrouns)", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pbDownload.Value = 0;
            Process.Start(Application.StartupPath);
        }

        private string GetFileNameFromUrl(string url)
        {
            string[] token = url.Split('/');
            if (token.Length > 0)
            {
                return token[token.Length - 1];
            }
            MessageBox.Show("Can't get file name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return "";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
