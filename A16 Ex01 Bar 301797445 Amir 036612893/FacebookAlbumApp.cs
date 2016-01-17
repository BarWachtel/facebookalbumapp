using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using DesignPatternsEx01;

namespace FacebookApp
{
    public partial class FacebookAlbumApp : Form
    {
        private FacebookUser m_FacebookUser;
        private AlbumCover m_SelectedAlbumCover;

        public FacebookAlbumApp()
        {
            InitializeComponent();
            button_login.Enabled = true;
            button_login.Visible = true;
            button_logout.Enabled = true;
            button_logout.Visible = true;
            enableSaveAlbumButton(false);
            resetAlbumInfoValues();

            m_FacebookUser = FacebookUser.GetInstance();
        }

        private void enableSaveAlbumButton(bool i_Value = true)
        {
            button_saveAlbums.Enabled = i_Value;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            initAndLogin();
        }

        private void initAndLogin()
        {
            m_FacebookUser.Login((success) =>
            {
                if (success)
                {
                    displayInitialLoggedInUserScreen();
                }
                else
                {
                    MessageBox.Show("Error logging in");
                }
            });
        }

        private void displayInitialLoggedInUserScreen()
        {
            //pictureBox_profilePicture.LoadAsync(m_FacebookUser.PictureLargeURL);
            pictureBox_profilePicture.Invoke(new Action(() =>
            {
                    pictureBox_profilePicture.LoadAsync(m_FacebookUser.PictureLargeURL);
                })
                );
            pictureBox_profilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            label_userName.Invoke(new Action(() =>
            {
                label_userName.Text = getUserFullName();
            })
            );

            foreach (Album album in m_FacebookUser.Albums)
            {
                AlbumCover albumCover = new AlbumCover(album.Name, album.PictureAlbumURL, album.Id);
                flowLayout_albumPhotos.Invoke(new Action(() =>
                    {
                        flowLayout_albumPhotos.Controls.Add(albumCover);
                        albumCover.LoadImage();
                    }));
                albumCover.Click += new EventHandler(albumCoverSelected);
            }

            enableLoginButton(false);
        }

        private void albumCoverSelected(object sender, EventArgs e)
        {
            AlbumCover albumCover = sender as AlbumCover;

            if (m_SelectedAlbumCover != null)
            {
                if (m_SelectedAlbumCover != albumCover)
                {
                    m_SelectedAlbumCover.Deselect();
                }
            }

            m_SelectedAlbumCover = albumCover;
            if (m_SelectedAlbumCover.IsSelected())
            {
                albumIsSelected(true);
            }
            else
            {
                albumIsSelected(false);
            }
        }

        private void albumIsSelected(bool i_AlbumIsSelected)
        {
            if (i_AlbumIsSelected)
            {
                setAlbumInfoValues();
                enableSaveAlbumButton();
            }
            else
            {
                resetAlbumInfoValues();
                enableSaveAlbumButton(false);
            }
        }

        private void setAlbumInfoValues()
        {
            Album album = m_FacebookUser.GetAlbumById(m_SelectedAlbumCover.Id);
            if (album != null)
            {
                label_albumName.Text = album.Name;
                label_description.Text = album.Description;
                label_lastUpdated.Text = album.UpdateTime.ToString();
                label_numPhotos.Text = album.Count.ToString();
                label_privacySettings.Text = album.PrivcaySettings;
                pictureBox_albumCoverPhoto.LoadAsync(album.PictureAlbumURL);
                pictureBox_albumCoverPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void displayInitialLoggedOutUserScreen()
        {
            pictureBox_profilePicture.Image = null;
            label_userName.Text = string.Empty;
            enableLoginButton();
        }

        private string getUserFullName()
        {
            return string.Format("{0} {1}", m_FacebookUser.FirstName, m_FacebookUser.LastName);
        }

        private void enableLoginButton(bool enable = true)
        {
            button_login.Invoke(new Action(() =>
                {
                    button_login.Enabled = enable;
                    button_login.Visible = enable;
                }));

            button_logout.Invoke(new Action(() =>
                {
                    button_logout.Enabled = !enable;
                    button_logout.Visible = !enable;
                }));
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            performUserLogout();
        }

        private void performUserLogout()
        {
            FacebookService.Logout(logoutCallback);
        }

        private void logoutCallback()
        {
            m_FacebookUser = null;
            displayInitialLoggedOutUserScreen();
        }

        private void saveAlbums_Button_Click(object sender, EventArgs e)
        {
            performSaveAlbum();
        }

        private void performSaveAlbum()
        {
            AlbumSaver.SaveAlbum(m_SelectedAlbumCover.Id);
        }

        private void resetAlbumInfoValues()
        {
            label_albumName.Text = string.Empty;
            label_description.Text = string.Empty;
            label_lastUpdated.Text = string.Empty;
            label_privacySettings.Text = string.Empty;
            label_numPhotos.Text = string.Empty;
            pictureBox_albumCoverPhoto.Image = null;
        }

        private void linkLabelFriends_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchFriendsList();
        }

        private void fetchFriendsList()
        {
            //listBoxFriends.Items.Clear();
            //listBoxFriends.DisplayMember = "Name";
            //foreach (User friend in m_FacebookUser.Friends)
            //{
            //    listBoxFriends.Items.Add(friend);
            //    friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            //}
            userBindingSource.DataSource = m_FacebookUser.Friends;
            if (m_FacebookUser.Friends.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
        }

        private void textBoxPost_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPost.Text))
            {
                buttonPostStatus.Enabled = false;
            }
            else
            {
                buttonPostStatus.Enabled = true;
            }
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            Status postedStatus = m_FacebookUser.PostStatus(textBoxPost.Text);
            MessageBox.Show("Status Posted!");
            textBoxPost.Text = string.Empty;
        }       

        //private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    displaySelectedFriend();
        //}

        //private void displaySelectedFriend()
        //{
        //    if (listBoxFriends.SelectedItems.Count == 1)
        //    {
        //        User selectedFriend = listBoxFriends.SelectedItem as User;
        //        if (selectedFriend.PictureNormalURL != null)
        //        {
        //            pictureBoxFriend.LoadAsync(selectedFriend.PictureNormalURL);
        //        }
        //        else
        //        {
        //            pictureBox_profilePicture.Image = pictureBox_profilePicture.ErrorImage;
        //        }
        //    }
        //}

        private void linkLabelEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchEvents();
        }

        private void fetchEvents()
        {
            listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = "Name";
            foreach (Event fbEvent in m_FacebookUser.Events)
            {
                listBoxEvents.Items.Add(fbEvent);
            }

            if (m_FacebookUser.Events.Count == 0)
            {
                MessageBox.Show("No Events to retrieve");
            }
        }

        private void linkLabelPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchPosts();
        }

        private void fetchPosts()
        {
            foreach (Post post in m_FacebookUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (m_FacebookUser.Posts.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }
    }
}
