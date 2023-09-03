using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookAppLogic
{
    public class LogicManager
    {
        private readonly AppSettings r_AppSettings;
        private User m_LoggedInUser;
        private LoginResult m_LoginResult;

        public LogicManager()
        {
            r_AppSettings = AppSettings.LoadFromFile();
        }

        public User LoggedInUser
        {
            get { return m_LoggedInUser; }
            set { m_LoggedInUser = value; }
        }
           
        public LoginResult LoginResult
        {
            get { return m_LoginResult; }
            set { m_LoginResult = value; }
        }

        public AppSettings AppSettings
        {
            get { return r_AppSettings; }
        }

        public void Login()
        {
            m_LoginResult = FacebookService.Login(
                "551756226631380",
                "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos",
                "groups_access_member_info",
                "publish_to_groups",
                "pages_manage_posts");

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                r_AppSettings.LastAccessToken = m_LoginResult.AccessToken;
            }
        }

        private void rememberUserLogin()
        {
            m_LoginResult = FacebookService.Connect(r_AppSettings.LastAccessToken);
            initializeLoggedInUser();
        }

        public void HandelRememberUser()
        {
            if (r_AppSettings.CheckIfRememberUser())
            {
                rememberUserLogin();
            }
        }

        private void initializeLoggedInUser()
        {
            LoggedInUser = LoginResult.LoggedInUser;
        }

        public void SaveDataAfterExit()
        {
            if (m_LoginResult.AccessToken != null)
            {
                if (r_AppSettings.RememberUser)
                {
                    r_AppSettings.LastAccessToken = m_LoginResult.AccessToken;
                }
                else
                {
                    r_AppSettings.LastAccessToken = null;
                }

                r_AppSettings.SaveToFile();
            }
        }

        public Album GetUsersCoverAlbum()
        {
            List<string> possibleCoverAlbumNames = getCoverAlbumPossibleNames();
            Album coverAlbum = m_LoggedInUser.Albums.Find(a => possibleCoverAlbumNames.Contains(a.Name));

            return coverAlbum;
        }

        private List<string> getCoverAlbumPossibleNames()
        {
            List<string> possibleCoverAlbumNames = new List<string>();

            possibleCoverAlbumNames.Add("Cover Photos");
            possibleCoverAlbumNames.Add("תמונות נושא");

            return possibleCoverAlbumNames;
        }

        public Album GetUsersProfilePicturesAlbum()
        {
            List<string> possibleCoverAlbumNames = getProfileAlbumPossibleNames();
            Album profileAlbum = m_LoggedInUser.Albums.Find(a => possibleCoverAlbumNames.Contains(a.Name));

            return profileAlbum;
        }

        private List<string> getProfileAlbumPossibleNames()
        {
            List<string> possibleCoverAlbumNames = new List<string>();

            possibleCoverAlbumNames.Add("Profile Photos");
            possibleCoverAlbumNames.Add("תמונות פרופיל");

            return possibleCoverAlbumNames;
        }
    }
}
