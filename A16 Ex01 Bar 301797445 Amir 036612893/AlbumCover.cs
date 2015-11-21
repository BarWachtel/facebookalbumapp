using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApp
{
    public class AlbumCover : GroupBox
    {
        private PictureBox m_AlbumPictureBox;
        private CheckBox m_IsSelectedCheckBox;
        private string m_AlbumId;
        private string m_AlbumCoverUrl;

        public AlbumCover(string i_AlbumLabel, string i_AlbumCoverUrl, string i_AlbumId)
        {
            this.m_AlbumPictureBox = new PictureBox();
            this.m_AlbumPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.m_AlbumCoverUrl = i_AlbumCoverUrl;
            this.m_AlbumId = i_AlbumId;

            this.m_AlbumPictureBox.Location = new System.Drawing.Point(6, 19);
            this.m_AlbumPictureBox.Name = "albumPictureBox";
            this.m_AlbumPictureBox.Size = new System.Drawing.Size(119, 111);
            this.m_AlbumPictureBox.TabIndex = 0;
            this.m_AlbumPictureBox.TabStop = false;

            this.m_IsSelectedCheckBox = new CheckBox();
            this.m_IsSelectedCheckBox.AutoSize = true;
            this.m_IsSelectedCheckBox.Location = new System.Drawing.Point(43, 113);
            this.m_IsSelectedCheckBox.Name = "isSelectedCheckBox";
            this.m_IsSelectedCheckBox.Size = new System.Drawing.Size(80, 17);
            this.m_IsSelectedCheckBox.TabIndex = 1;
            this.m_IsSelectedCheckBox.Text = "Selected";
            this.m_IsSelectedCheckBox.UseVisualStyleBackColor = true;
            this.m_IsSelectedCheckBox.Visible = false;
            this.m_IsSelectedCheckBox.Checked = false;

            this.Controls.Add(this.m_AlbumPictureBox);
            this.Controls.Add(this.m_IsSelectedCheckBox);
            this.m_IsSelectedCheckBox.BringToFront();
            this.m_AlbumPictureBox.SendToBack();

            this.Name = i_AlbumLabel;
            this.Size = new System.Drawing.Size(131, 136);
            this.Text = i_AlbumLabel;

            this.Click += new EventHandler(albumCoverSelected);
            this.m_AlbumPictureBox.Click += propagateClick;
        }

        public void LoadImage()
        {
            m_AlbumPictureBox.LoadAsync(m_AlbumCoverUrl);
        }

        public PictureBox AlbumCoverPhoto
        {
            get { return m_AlbumPictureBox; }
        }        

        private void albumCoverSelected(object sender, EventArgs e)
        {
            m_IsSelectedCheckBox.Checked = !m_IsSelectedCheckBox.Checked;
            m_IsSelectedCheckBox.Visible = m_IsSelectedCheckBox.Checked;
        }
               
        private void propagateClick(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        public bool IsSelected()
        {
            return m_IsSelectedCheckBox.Checked;
        }

        public void Deselect()
        {
            m_IsSelectedCheckBox.Checked = false;
            m_IsSelectedCheckBox.Visible = false;
        }

        public string Id
        {
            get { return m_AlbumId; }
            set { m_AlbumId = value; }
        }
    }
}
