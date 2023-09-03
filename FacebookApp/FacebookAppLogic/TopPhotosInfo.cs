using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookAppLogic
{
    public class TopPhotosInfo
    {
        private const int k_PhotosNumber = 3;
        private Photo[] m_Photos;
        private int[] m_CommentsAmount;

        public TopPhotosInfo()
        {
            m_Photos = new Photo[k_PhotosNumber];
            m_CommentsAmount = new int[k_PhotosNumber];
        }

        public Photo[] Photos
        {
            get { return m_Photos; }
            set { m_Photos = value; }
        }

        public int[] CommentsAmount
        {
            get { return m_CommentsAmount; }
            set { m_CommentsAmount = value; }
        }
    }
}
