using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookAppLogic
{
    public class TopThreePhotosFeature 
    {
        public const int k_MostPopular = 0;
        public const int k_MiddlePopular = 1;
        public const int k_LessPopular = 2;
        private readonly FacebookObjectCollection<Photo> r_Photos;
        private TopPhotosInfo m_TopPhotosInfo;
        private Dictionary<string, int> m_ResponsiveFemaleFriends;
        private Dictionary<string, int> m_ResponsiveMaleFriends;

        public TopThreePhotosFeature(FacebookObjectCollection<Photo> i_Photos)
        {
            r_Photos = i_Photos;
            m_TopPhotosInfo = new TopPhotosInfo();
            m_ResponsiveMaleFriends = m_ResponsiveFemaleFriends = new Dictionary<string, int>();
            setTopThreePhotos();
            initializeFriendsList();
        }

        public TopPhotosInfo TopPhotosInfo
        {
            get { return m_TopPhotosInfo; }
        }

        private void setTopThreePhotos()
        {
            foreach (Photo photo in r_Photos)
            {
                if (photo.Comments.Count >= m_TopPhotosInfo.CommentsAmount[k_MostPopular])
                {
                    loadPhotosInfo(k_LessPopular, m_TopPhotosInfo.Photos[k_MiddlePopular], m_TopPhotosInfo.CommentsAmount[k_MiddlePopular]);
                    loadPhotosInfo(k_MiddlePopular, m_TopPhotosInfo.Photos[k_MostPopular], m_TopPhotosInfo.CommentsAmount[k_MostPopular]);
                    loadPhotosInfo(k_MostPopular, photo, photo.Comments.Count);
                }
                else if ((photo.Comments.Count < m_TopPhotosInfo.CommentsAmount[k_MostPopular]) && (photo.Comments.Count > m_TopPhotosInfo.CommentsAmount[k_MiddlePopular]))
                {
                    loadPhotosInfo(k_LessPopular, m_TopPhotosInfo.Photos[k_MiddlePopular], m_TopPhotosInfo.CommentsAmount[k_MiddlePopular]);
                    loadPhotosInfo(k_MiddlePopular, photo, photo.Comments.Count);
                }
                else if ((photo.Comments.Count < m_TopPhotosInfo.CommentsAmount[k_MiddlePopular]) && (photo.Comments.Count > m_TopPhotosInfo.CommentsAmount[k_LessPopular]))
                {
                    loadPhotosInfo(k_LessPopular, photo, photo.Comments.Count);
                }
            }
        }

        private void loadPhotosInfo(int i_CurrentPhoto, Photo i_Photo, int i_NumberOfComments)
        {
            m_TopPhotosInfo.Photos[i_CurrentPhoto] = i_Photo;
            m_TopPhotosInfo.CommentsAmount[i_CurrentPhoto] = i_NumberOfComments;
        }

        public string MostResponsiveFemaleFriendName(string i_UserName)
        {
            return getTheMostResponsiveFriendsNames(m_ResponsiveFemaleFriends, i_UserName);
        }

        public string MostResponsiveMaleFriendName(string i_UserName)
        {
            return getTheMostResponsiveFriendsNames(m_ResponsiveMaleFriends, i_UserName);
        }

        private string getTheMostResponsiveFriendsNames(Dictionary<string, int> i_Friends, string i_UserName)
        {
            int maxCommentsNumber = -1;
            string friendName = "No Friend";

            foreach (KeyValuePair<string, int> item in i_Friends)
            {
                if (maxCommentsNumber < item.Value)
                {
                    friendName = item.Key;
                    maxCommentsNumber = item.Value;
                }
            }

            if(friendName == i_UserName)
            {
                friendName = "No Friend";
            }

            return friendName;
        }

        private void initializeFriendsList()
        {
            int count;

            foreach (Photo photo in m_TopPhotosInfo.Photos)
            {
                foreach (Comment comment in photo.Comments)
                {
                    if (comment.From.Gender == User.eGender.female)
                    {
                        m_ResponsiveFemaleFriends.TryGetValue(comment.From.Name, out count);
                        count++;
                        m_ResponsiveFemaleFriends[comment.From.Name] = count;
                    }
                    else
                    {
                        m_ResponsiveMaleFriends.TryGetValue(comment.From.Name, out count);
                        count++;
                        m_ResponsiveMaleFriends[comment.From.Name] = count;
                    }
                }
            }
        }
    }
}
