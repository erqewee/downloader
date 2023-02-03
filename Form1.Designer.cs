namespace Downloader
{
    partial class Downloader
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Downloader));
            this.panel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.selectDownloadPath = new Guna.UI2.WinForms.Guna2Button();
            this.downloadButton = new Guna.UI2.WinForms.Guna2Button();
            this.fileName = new Guna.UI2.WinForms.Guna2TextBox();
            this.targetURL = new Guna.UI2.WinForms.Guna2TextBox();
            this.selectDownloadFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.cancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.pauseButton = new Guna.UI2.WinForms.Guna2Button();
            this.resumeButton = new Guna.UI2.WinForms.Guna2Button();
            this.downloadProgress = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.RADButton = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.downloaded = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.speed);
            this.panel.Controls.Add(this.downloaded);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.RADButton);
            this.panel.Controls.Add(this.downloadProgress);
            this.panel.Controls.Add(this.resumeButton);
            this.panel.Controls.Add(this.pauseButton);
            this.panel.Controls.Add(this.cancelButton);
            this.panel.Controls.Add(this.selectDownloadPath);
            this.panel.Controls.Add(this.downloadButton);
            this.panel.Controls.Add(this.fileName);
            this.panel.Controls.Add(this.targetURL);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.FillColor = System.Drawing.Color.DarkSlateGray;
            this.panel.FillColor2 = System.Drawing.Color.SeaGreen;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(557, 374);
            this.panel.TabIndex = 0;
            // 
            // selectDownloadPath
            // 
            this.selectDownloadPath.Animated = true;
            this.selectDownloadPath.AutoRoundedCorners = true;
            this.selectDownloadPath.BackColor = System.Drawing.Color.Transparent;
            this.selectDownloadPath.BorderRadius = 21;
            this.selectDownloadPath.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.selectDownloadPath.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.selectDownloadPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.selectDownloadPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.selectDownloadPath.FillColor = System.Drawing.Color.Transparent;
            this.selectDownloadPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.selectDownloadPath.ForeColor = System.Drawing.Color.White;
            this.selectDownloadPath.IndicateFocus = true;
            this.selectDownloadPath.Location = new System.Drawing.Point(12, 71);
            this.selectDownloadPath.Name = "selectDownloadPath";
            this.selectDownloadPath.Size = new System.Drawing.Size(124, 45);
            this.selectDownloadPath.TabIndex = 4;
            this.selectDownloadPath.Text = "Select Download Path";
            this.selectDownloadPath.UseTransparentBackground = true;
            this.selectDownloadPath.Click += new System.EventHandler(this.selectDownloadPath_Click);
            // 
            // downloadButton
            // 
            this.downloadButton.Animated = true;
            this.downloadButton.AutoRoundedCorners = true;
            this.downloadButton.BackColor = System.Drawing.Color.Transparent;
            this.downloadButton.BorderRadius = 21;
            this.downloadButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.downloadButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.downloadButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.downloadButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.downloadButton.FillColor = System.Drawing.Color.Teal;
            this.downloadButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.downloadButton.ForeColor = System.Drawing.Color.White;
            this.downloadButton.IndicateFocus = true;
            this.downloadButton.Location = new System.Drawing.Point(12, 317);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(125, 45);
            this.downloadButton.TabIndex = 2;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseTransparentBackground = true;
            this.downloadButton.Click += new System.EventHandler(this.addDownload_Click);
            // 
            // fileName
            // 
            this.fileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileName.Animated = true;
            this.fileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fileName.DefaultText = "";
            this.fileName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fileName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fileName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fileName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fileName.FillColor = System.Drawing.Color.DimGray;
            this.fileName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fileName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fileName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fileName.Location = new System.Drawing.Point(12, 42);
            this.fileName.Name = "fileName";
            this.fileName.PasswordChar = '\0';
            this.fileName.PlaceholderText = "File Name (Ex: \"MyFile.exe\")";
            this.fileName.SelectedText = "";
            this.fileName.Size = new System.Drawing.Size(533, 23);
            this.fileName.TabIndex = 1;
            // 
            // targetURL
            // 
            this.targetURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.targetURL.Animated = true;
            this.targetURL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.targetURL.DefaultText = "";
            this.targetURL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.targetURL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.targetURL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.targetURL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.targetURL.FillColor = System.Drawing.Color.DimGray;
            this.targetURL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.targetURL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.targetURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.targetURL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.targetURL.Location = new System.Drawing.Point(12, 12);
            this.targetURL.Name = "targetURL";
            this.targetURL.PasswordChar = '\0';
            this.targetURL.PlaceholderText = "Target URL (Ex: https://github.com/erqewee/vlexrr/download.rar)";
            this.targetURL.SelectedText = "";
            this.targetURL.Size = new System.Drawing.Size(533, 24);
            this.targetURL.TabIndex = 0;
            this.targetURL.TextChanged += new System.EventHandler(this.targetURL_TextChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Animated = true;
            this.cancelButton.AutoRoundedCorners = true;
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.BorderRadius = 21;
            this.cancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelButton.FillColor = System.Drawing.Color.Gray;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.IndicateFocus = true;
            this.cancelButton.Location = new System.Drawing.Point(143, 317);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 45);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseTransparentBackground = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Animated = true;
            this.pauseButton.AutoRoundedCorners = true;
            this.pauseButton.BackColor = System.Drawing.Color.Transparent;
            this.pauseButton.BorderRadius = 21;
            this.pauseButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.pauseButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.pauseButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.pauseButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.pauseButton.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.pauseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pauseButton.ForeColor = System.Drawing.Color.White;
            this.pauseButton.IndicateFocus = true;
            this.pauseButton.Location = new System.Drawing.Point(289, 317);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(125, 45);
            this.pauseButton.TabIndex = 6;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseTransparentBackground = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // resumeButton
            // 
            this.resumeButton.Animated = true;
            this.resumeButton.AutoRoundedCorners = true;
            this.resumeButton.BackColor = System.Drawing.Color.Transparent;
            this.resumeButton.BorderRadius = 21;
            this.resumeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resumeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resumeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resumeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resumeButton.FillColor = System.Drawing.Color.Orange;
            this.resumeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.resumeButton.ForeColor = System.Drawing.Color.White;
            this.resumeButton.IndicateFocus = true;
            this.resumeButton.Location = new System.Drawing.Point(420, 317);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(125, 45);
            this.resumeButton.TabIndex = 7;
            this.resumeButton.Text = "Resume";
            this.resumeButton.UseTransparentBackground = true;
            this.resumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // downloadProgress
            // 
            this.downloadProgress.Location = new System.Drawing.Point(12, 281);
            this.downloadProgress.Name = "downloadProgress";
            this.downloadProgress.ShowText = true;
            this.downloadProgress.Size = new System.Drawing.Size(533, 30);
            this.downloadProgress.TabIndex = 8;
            this.downloadProgress.Text = "%0";
            this.downloadProgress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // RADButton
            // 
            this.RADButton.BackColor = System.Drawing.Color.Transparent;
            this.RADButton.Checked = true;
            this.RADButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RADButton.CheckedState.BorderRadius = 2;
            this.RADButton.CheckedState.BorderThickness = 0;
            this.RADButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RADButton.Location = new System.Drawing.Point(13, 255);
            this.RADButton.Name = "RADButton";
            this.RADButton.Size = new System.Drawing.Size(20, 20);
            this.RADButton.TabIndex = 9;
            this.RADButton.Text = "guna2CustomCheckBox1";
            this.RADButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RADButton.UncheckedState.BorderRadius = 2;
            this.RADButton.UncheckedState.BorderThickness = 0;
            this.RADButton.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RADButton.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Run after Download";
            // 
            // downloaded
            // 
            this.downloaded.AutoSize = true;
            this.downloaded.BackColor = System.Drawing.Color.Transparent;
            this.downloaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.downloaded.Location = new System.Drawing.Point(10, 192);
            this.downloaded.Name = "downloaded";
            this.downloaded.Size = new System.Drawing.Size(145, 18);
            this.downloaded.TabIndex = 11;
            this.downloaded.Text = "Downloaded: 0MB";
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.BackColor = System.Drawing.Color.Transparent;
            this.speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.speed.Location = new System.Drawing.Point(10, 220);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(113, 18);
            this.speed.TabIndex = 12;
            this.speed.Text = "Speed: 0MB/s";
            // 
            // Downloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 374);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Downloader";
            this.Text = "Downloader (v1.1.0)";
            this.Load += new System.EventHandler(this.Downloader_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel panel;
        private Guna.UI2.WinForms.Guna2TextBox targetURL;
        private Guna.UI2.WinForms.Guna2TextBox fileName;
        private Guna.UI2.WinForms.Guna2Button downloadButton;
        private Guna.UI2.WinForms.Guna2Button selectDownloadPath;
        private System.Windows.Forms.FolderBrowserDialog selectDownloadFolder;
        private Guna.UI2.WinForms.Guna2ProgressBar downloadProgress;
        private Guna.UI2.WinForms.Guna2Button resumeButton;
        private Guna.UI2.WinForms.Guna2Button pauseButton;
        private Guna.UI2.WinForms.Guna2Button cancelButton;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CustomCheckBox RADButton;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.Label downloaded;
    }
}

