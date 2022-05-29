using AltoHttp;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public HttpDownloader client;
        public string target = $"{Application.StartupPath}\\Downloads";

        private void LoadX()
        {
            resumeButton.Enabled = false;
            downloadButton.Enabled = false;
            fileExtension.Enabled = false;
            fileName.Enabled = false;
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {

            if (fileExtension.Text == "" || fileExtension.Text == null)
            {
                fileExtension.Text = "rar";
            }

            if(fileName.Text == "" || fileName.Text == null)
            {
                fileName.Text = "your_installed_file";
            }

            if (!Directory.Exists(target))
            {
                Directory.CreateDirectory(target);
            }

            try
            {

                client = new HttpDownloader(url.Text, $"{target}\\{fileName.Text}.{fileExtension.Text}");

                client.DownloadCompleted += DownloadCompleted;
                client.ProgressChanged += ProgressChanged;

                downloadButton.Enabled = false;
                pauseButton.Enabled = true;

                url.Enabled = false;
                fileExtension.Enabled = false;
                fileName.Enabled = false;

                client.Start();

            }
            catch
            {
                statusLabel.Text = "Invalid URL";
                downloadButton.Enabled = true;
                return;
            }

        }

        private void ProgressChanged(object sender, AltoHttp.ProgressChangedEventArgs e)
        {
            progress.Value = (int)e.Progress;
            labelProgress.Text = $"{e.Progress.ToString("0.00")}%";
            speed.Text = string.Format("{0} MB/s", (e.SpeedInBytes / 1024d / 1024d).ToString("0.00"));

            downloadLabel.Text = string.Format("{0} MB", (client.TotalBytesReceived / 1024d / 1024d).ToString("0.00"));
            statusLabel.Text = "Downloading...";
        }

        private void DownloadCompleted(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                statusLabel.Text = $"Completed!";
                labelProgress.Text = "100%";
                speed.Text = "0.00 MB/s";
                MessageBox.Show($"{target}\\{fileName.Text}.{fileExtension.Text}", "File downloaded successful!");

                downloadButton.Enabled = true;
                fileExtension.Enabled = true;
                fileName.Enabled = true;
                pauseButton.Enabled = false;
                resumeButton.Enabled = false;
                url.Enabled = true;
            });
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                client.Resume();
            }

            resumeButton.Enabled = false;
            pauseButton.Enabled = true;
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                client.Pause();
            }

            speed.Text = "0.00 MB/s";
            resumeButton.Enabled = true;
            pauseButton.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadX();
        }

        private void url_TextChanged(object sender, EventArgs e)
        {
            if (url.Text.Contains(" ") || url.Text == "" || url.Text == null)
            {
                downloadButton.Enabled = false;
                fileExtension.Enabled = false;
                fileName.Enabled = false;
            }
            else
            {
                downloadButton.Enabled = true;
                fileExtension.Enabled = true;
                fileName.Enabled = true;
            }
        }

        private void downloads_Click(object sender, EventArgs e)
        {
            Process.Start(target);
        }
    }
}
