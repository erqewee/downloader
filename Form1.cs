using System;
using System.Diagnostics;
using System.IO;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

using AltoHttp;

namespace Downloader
{
    public partial class Downloader : Form
    {
        public Downloader()
        {
            InitializeComponent();
        }

        string PATH = $"{Application.StartupPath}\\Downloads";

        public HttpDownloader Client;

        private void Downloader_Load(object sender, EventArgs e)
        {
            downloadButton.Enabled = false;
            fileName.Enabled = false;
            cancelButton.Enabled = false;
            resumeButton.Enabled = false;
            pauseButton.Enabled = false;
        }

        private void addDownload_Click(object sender, EventArgs e)
        {
            string URL = targetURL.Text;
            string NAME = fileName.Text;

            if (selectDownloadFolder.SelectedPath != "")
            {
                PATH = selectDownloadFolder.SelectedPath;
            }

            if (!Directory.Exists(PATH))
            {
                Directory.CreateDirectory(PATH);
            }

            Client = new HttpDownloader(URL, $"{PATH}\\{NAME}");

            try { 
                Client.DownloadCompleted += DownloadCompletedDataReceived;
                Client.ProgressChanged += ProgressDataReceived;

                Client.Start();

                targetURL.Enabled = false;
                targetURL.Text = "";

                downloadButton.Text = "Downloading";
                downloadButton.Enabled = false;

                cancelButton.Enabled = true;
                pauseButton.Enabled = true;
            } catch {
                targetURL.Enabled = true;
                targetURL.Text = "Invalid URL detected.";

                downloadButton.Text = "Download";
                downloadButton.Enabled = false;

                cancelButton.Enabled = false;
                resumeButton.Enabled = false;
                pauseButton.Enabled = false;
            }; 
        }

        private void DownloadCompletedDataReceived(object sender, EventArgs args)
        {
            Invoke((MethodInvoker)delegate
            {
                downloadButton.Text = "Download";
                downloadButton.Enabled = true;

                downloaded.Text = "Downloaded: 0MB";

                speed.Text = "Speed: 0.00 MB/s";
                MessageBox.Show($"{PATH}\\{fileName.Text}", "File downloaded successful!");

                downloadProgress.Value = 0;

                targetURL.Enabled = true;
                fileName.Enabled = true;
                pauseButton.Enabled = false;
                cancelButton.Enabled = false;
                resumeButton.Enabled = false;

                if(RADButton.Checked)
                {
                    Process.Start($"{PATH}\\{fileName.Text}");
                }
            });
        }

        private void ProgressDataReceived(object sender, AltoHttp.ProgressChangedEventArgs args)
        {
            downloadProgress.Value = (int)args.Progress;
            speed.Text = "Speed: " + string.Format("{0} MB/s", (args.SpeedInBytes / 1024d / 1024d).ToString("0.00"));
            downloaded.Text = "Downloaded: " + string.Format("{0} MB", (args.TotalBytesReceived / 1024d / 1024d).ToString("0.00"));
        }

        private void targetURL_TextChanged(object sender, EventArgs e)
        {
            if(targetURL.Text.Contains(" ") || !targetURL.Text.StartsWith("http") || targetURL.Text == "" || targetURL.Text == null)
            {
                downloadButton.Enabled = false;
                fileName.Enabled = false;
            } else
            {
                downloadButton.Enabled = true;
                fileName.Enabled = true;
            }
        }

        private void selectDownloadPath_Click(object sender, EventArgs e)
        {
            selectDownloadFolder.ShowDialog();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if(Client != null)
            {
                Client.StopReset();

                targetURL.Enabled = true;
                fileName.Enabled = true;

                downloadButton.Text = "Download";
                downloadButton.Enabled = true;

                downloaded.Text = "Downloaded: 0MB";
                downloadProgress.Value = 0;

                cancelButton.Enabled = false;
                pauseButton.Enabled = false;
                resumeButton.Enabled = false;
            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (Client != null)
            {
                Client.Pause();

                downloadButton.Text = "Paused";

                cancelButton.Enabled = true;
                pauseButton.Enabled = false;
                resumeButton.Enabled = true;
            }
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            if (Client != null)
            {
                Client.Resume();

                downloadButton.Text = "Downloading";

                cancelButton.Enabled = true;
                pauseButton.Enabled = true;
                resumeButton.Enabled = false;
            }
        }
    }
}
