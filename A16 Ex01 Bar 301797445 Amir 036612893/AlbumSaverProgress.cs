using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesignPatternsEx01
{
    class AlbumSaverProgress : Form
    {
        private int m_NumPhotosInAlbum;
        private int m_NumPhotosDownloaded;

        private Label progressLabel;
        private Button closeButton;

        public AlbumSaverProgress(int i_NumPhotosInAlbum)
        {
            this.m_NumPhotosInAlbum = i_NumPhotosInAlbum;
            m_NumPhotosDownloaded = 0;
            initialize();
        }

        private string getProgressString()
        {
            return String.Format(@"{0} / {1} Images downloaded", m_NumPhotosDownloaded, m_NumPhotosInAlbum);
        }

        public void initialize()
        {
            InitializeComponent();
            closeButton.Enabled = false;
            progressLabel.Text = getProgressString();
        }

        public void IncrementNumPhotosDownloaded()
        {
            m_NumPhotosDownloaded++;
            progressLabel.Invoke(new Action(() =>
                {
                    progressLabel.Text = getProgressString();
                }));

            if (m_NumPhotosDownloaded == m_NumPhotosInAlbum)
            {
                closeButton.Invoke(new Action(() =>
                    {
                        closeButton.Enabled = true;
                    }));
            }
        }

        private void InitializeComponent()
        {
            this.progressLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(25, 18);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(73, 13);
            this.progressLabel.TabIndex = 0;
            this.progressLabel.Text = "progressLabel";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(157, 62);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // AlbumSaverProgress
            // 
            this.ClientSize = new System.Drawing.Size(252, 97);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.progressLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AlbumSaverProgress";
            this.Load += new System.EventHandler(this.AlbumSaverProgress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void AlbumSaverProgress_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
