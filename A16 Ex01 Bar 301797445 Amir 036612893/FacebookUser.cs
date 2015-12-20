using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DesignPatternsEx01
{
    class FacebookUser
    {
        private User m_LoggedInUser;
        private static FacebookUser m_Instance;
        private static object m_InstanceCreationLock = new Object();

        private FacebookUser()
        {
            FacebookService.s_CollectionLimit = 1000;
        }

        public static FacebookUser GetInstance()
        {
            if (m_Instance == null)
            {
                lock (m_InstanceCreationLock)
                {
                    if (m_Instance == null)
                    {
                        m_Instance = new FacebookUser();
                    }
                }
            }

            return m_Instance;
        }

        public void Login(Action<bool> i_ActionSuccess)
        {
            if (m_LoggedInUser == null)
            {
                Thread thread = new Thread(() =>
                {
                    LoginResult result = FacebookService.Login("419917864886078", "user_about_me", "user_friends", "user_posts", "user_photos");
                    bool success = false;
                    if (!string.IsNullOrEmpty(result.AccessToken))
                    {
                        m_LoggedInUser = result.LoggedInUser;
                        success = true;
                    }

                    i_ActionSuccess(success);
                });
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                i_ActionSuccess(true);
            }
        }

        internal Status PostStatus(string i_PostText)
        {
            return m_LoggedInUser.PostStatus(i_PostText);
        }


        public FacebookObjectCollection<User> Friends
        {
            get
            {
                return m_LoggedInUser.Friends;
            }
        }


        public string PictureLargeURL
        {
            get
            {
                return m_LoggedInUser.PictureLargeURL;
            }
        }

        public FacebookObjectCollection<Album> Albums
        {
            get
            {
                return m_LoggedInUser.Albums;
            }
        }

        public string FirstName
        {
            get
            {
                return m_LoggedInUser.FirstName;
            }
        }

        public String LastName
        {
            get
            {
                return m_LoggedInUser.LastName;
            }

        }

        public FacebookObjectCollection<Event> Events
        {
            get { return m_LoggedInUser.Events; }
        }

        public FacebookObjectCollection<Post> Posts
        {
            get { return m_LoggedInUser.Posts; }
        }
    }
}
