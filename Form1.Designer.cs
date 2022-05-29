namespace Downloader
{
    partial class Form1
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
            this.url = new Guna.UI2.WinForms.Guna2TextBox();
            this.downloadButton = new Guna.UI2.WinForms.Guna2Button();
            this.progressLabel = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.resumeButton = new Guna.UI2.WinForms.Guna2Button();
            this.pauseButton = new Guna.UI2.WinForms.Guna2Button();
            this.labelProgress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.downloaded = new System.Windows.Forms.Label();
            this.downloadLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.Label();
            this.fileExtension = new Guna.UI2.WinForms.Guna2TextBox();
            this.downloads = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // url
            // 
            this.url.Animated = true;
            this.url.AutoRoundedCorners = true;
            this.url.BorderRadius = 9;
            this.url.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.url.DefaultText = "";
            this.url.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.url.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.url.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.url.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.url.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.url.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.url.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.url.Location = new System.Drawing.Point(71, 13);
            this.url.Name = "url";
            this.url.PasswordChar = '\0';
            this.url.PlaceholderText = "";
            this.url.SelectedText = "";
            this.url.Size = new System.Drawing.Size(867, 21);
            this.url.TabIndex = 0;
            this.url.TextChanged += new System.EventHandler(this.url_TextChanged);
            // 
            // downloadButton
            // 
            this.downloadButton.Animated = true;
            this.downloadButton.AutoRoundedCorners = true;
            this.downloadButton.BackColor = System.Drawing.Color.Transparent;
            this.downloadButton.BorderRadius = 18;
            this.downloadButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.downloadButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.downloadButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.downloadButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.downloadButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.downloadButton.ForeColor = System.Drawing.Color.White;
            this.downloadButton.IndicateFocus = true;
            this.downloadButton.Location = new System.Drawing.Point(578, 306);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(117, 38);
            this.downloadButton.TabIndex = 1;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseTransparentBackground = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(12, 429);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(0, 13);
            this.progressLabel.TabIndex = 7;
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Location = new System.Drawing.Point(94, 429);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(0, 13);
            this.size.TabIndex = 10;
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(12, 350);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(926, 40);
            this.progress.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "URL:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Sitka Heading", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(12, 148);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(59, 21);
            this.status.TabIndex = 13;
            this.status.Text = "Status:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Sitka Heading", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(77, 147);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(71, 21);
            this.statusLabel.TabIndex = 14;
            this.statusLabel.Text = "Unknown";
            // 
            // resumeButton
            // 
            this.resumeButton.Animated = true;
            this.resumeButton.AutoRoundedCorners = true;
            this.resumeButton.BackColor = System.Drawing.Color.Transparent;
            this.resumeButton.BorderRadius = 18;
            this.resumeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resumeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resumeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resumeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resumeButton.Enabled = false;
            this.resumeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resumeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.resumeButton.ForeColor = System.Drawing.Color.White;
            this.resumeButton.IndicateFocus = true;
            this.resumeButton.Location = new System.Drawing.Point(701, 306);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(117, 38);
            this.resumeButton.TabIndex = 16;
            this.resumeButton.Text = "Resume";
            this.resumeButton.UseTransparentBackground = true;
            this.resumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Animated = true;
            this.pauseButton.AutoRoundedCorners = true;
            this.pauseButton.BackColor = System.Drawing.Color.Transparent;
            this.pauseButton.BorderRadius = 18;
            this.pauseButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.pauseButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.pauseButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.pauseButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.pauseButton.Enabled = false;
            this.pauseButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pauseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pauseButton.ForeColor = System.Drawing.Color.White;
            this.pauseButton.IndicateFocus = true;
            this.pauseButton.Location = new System.Drawing.Point(821, 306);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(117, 38);
            this.pauseButton.TabIndex = 16;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseTransparentBackground = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelProgress.Location = new System.Drawing.Point(8, 327);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(28, 20);
            this.labelProgress.TabIndex = 21;
            this.labelProgress.Text = "0%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "File Name:";
            // 
            // fileName
            // 
            this.fileName.Animated = true;
            this.fileName.AutoRoundedCorners = true;
            this.fileName.BorderRadius = 9;
            this.fileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fileName.DefaultText = "";
            this.fileName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fileName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fileName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fileName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fileName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fileName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fileName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fileName.Location = new System.Drawing.Point(99, 53);
            this.fileName.Name = "fileName";
            this.fileName.PasswordChar = '\0';
            this.fileName.PlaceholderText = "DEFAULT (your_installed_file)";
            this.fileName.SelectedText = "";
            this.fileName.Size = new System.Drawing.Size(312, 21);
            this.fileName.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Heading", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Extension:";
            // 
            // downloaded
            // 
            this.downloaded.AutoSize = true;
            this.downloaded.Font = new System.Drawing.Font("Sitka Heading", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloaded.Location = new System.Drawing.Point(8, 283);
            this.downloaded.Name = "downloaded";
            this.downloaded.Size = new System.Drawing.Size(95, 21);
            this.downloaded.TabIndex = 17;
            this.downloaded.Text = "Downloaded:";
            // 
            // downloadLabel
            // 
            this.downloadLabel.AutoSize = true;
            this.downloadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.downloadLabel.Location = new System.Drawing.Point(109, 285);
            this.downloadLabel.Name = "downloadLabel";
            this.downloadLabel.Size = new System.Drawing.Size(65, 18);
            this.downloadLabel.TabIndex = 18;
            this.downloadLabel.Text = "0.00MB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Heading", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Speed:";
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.speed.Location = new System.Drawing.Point(64, 259);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(84, 18);
            this.speed.TabIndex = 20;
            this.speed.Text = "0.00 MB/s";
            // 
            // fileExtension
            // 
            this.fileExtension.Animated = true;
            this.fileExtension.AutoRoundedCorners = true;
            this.fileExtension.BorderRadius = 9;
            this.fileExtension.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fileExtension.DefaultText = "";
            this.fileExtension.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fileExtension.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fileExtension.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fileExtension.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fileExtension.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fileExtension.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fileExtension.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fileExtension.Location = new System.Drawing.Point(99, 95);
            this.fileExtension.Name = "fileExtension";
            this.fileExtension.PasswordChar = '\0';
            this.fileExtension.PlaceholderText = "DEFAULT (rar)";
            this.fileExtension.SelectedText = "";
            this.fileExtension.Size = new System.Drawing.Size(312, 21);
            this.fileExtension.TabIndex = 25;
            // 
            // downloads
            // 
            this.downloads.Animated = true;
            this.downloads.AutoRoundedCorners = true;
            this.downloads.BackColor = System.Drawing.Color.Transparent;
            this.downloads.BorderRadius = 18;
            this.downloads.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.downloads.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.downloads.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.downloads.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.downloads.FillColor = System.Drawing.Color.SlateGray;
            this.downloads.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.downloads.ForeColor = System.Drawing.Color.White;
            this.downloads.IndicateFocus = true;
            this.downloads.Location = new System.Drawing.Point(836, 40);
            this.downloads.Name = "downloads";
            this.downloads.Size = new System.Drawing.Size(102, 38);
            this.downloads.TabIndex = 26;
            this.downloads.Text = "Downloads";
            this.downloads.UseTransparentBackground = true;
            this.downloads.Click += new System.EventHandler(this.downloads_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 402);
            this.Controls.Add(this.downloads);
            this.Controls.Add(this.fileExtension);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.downloadLabel);
            this.Controls.Add(this.downloaded);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.resumeButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.size);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.url);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Downloader for PC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox url;
        private Guna.UI2.WinForms.Guna2Button downloadButton;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label statusLabel;
        private Guna.UI2.WinForms.Guna2Button resumeButton;
        private Guna.UI2.WinForms.Guna2Button pauseButton;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox fileName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label downloaded;
        private System.Windows.Forms.Label downloadLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label speed;
        private Guna.UI2.WinForms.Guna2TextBox fileExtension;
        private Guna.UI2.WinForms.Guna2Button downloads;
    }
}

