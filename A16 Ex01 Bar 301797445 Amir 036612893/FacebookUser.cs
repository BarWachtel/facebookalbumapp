using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DesignPatternsEx01
{
    public delegate void UserLoggedInObserver(bool i_Success);
    public class FacebookUser
    {
        private User m_LoggedInUser;
        private static FacebookUser m_Instance;
        private static object m_InstanceCreationLock = new Object();
        private UserLoggedInObserver m_UserLoggedInObservers;

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

        public void Login()
        {
            if (m_LoggedInUser == null)
            {
                Thread thread = new Thread(() =>
                {
                    LoginResult result = FacebookService.Login("419917864886078", "user_about_me", "user_friends", "user_posts", "user_photos", "email", "user_birthday");
                    bool success = false;
                    if (!string.IsNullOrEmpty(result.AccessToken))
                    {
                        m_LoggedInUser = result.LoggedInUser;
                        success = true;
                    }

                    userLoggedInSuccessfully(success);
                });
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                userLoggedInSuccessfully(true);
            }
        }

        internal Status PostStatus(string i_PostText)
        {
            return m_LoggedInUser.PostStatus(i_PostText);
        }

        public Album GetAlbumById(string i_Id)
        {
            Album theAlbum = null;
            foreach (Album album in m_LoggedInUser.Albums)
            {
                if (album.Id == i_Id)
                {
                    theAlbum = album;
                    break;
                }
            }

            return theAlbum;
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

        public IEnumerator<Album> Albums
        {
            get
            {
                return m_LoggedInUser.Albums.GetEnumerator();
            }
        }

        public IOrderedEnumerable<Album> GetSortedAlbums(Func<Album, long> i_CompareStrategy)
        {
            return m_LoggedInUser.Albums.OrderBy(i_CompareStrategy);
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

        public void AddLoginObserver(UserLoggedInObserver i_UserLoggedInObserver)
        {
            m_UserLoggedInObservers += i_UserLoggedInObserver;
        }

        public void RemoveLoginObserver(UserLoggedInObserver i_UserLoggedInObserver)
        {
            m_UserLoggedInObservers -= i_UserLoggedInObserver;
        }

        private void userLoggedInSuccessfully(bool i_Success)
        {
            if (m_UserLoggedInObservers != null)
            {
                m_UserLoggedInObservers.Invoke(i_Success);
            }
        }
    }
}
