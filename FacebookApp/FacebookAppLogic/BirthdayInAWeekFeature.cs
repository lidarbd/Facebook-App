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
    public class BirthdayInAWeekFeature : IEnumerable<User>
    {
        private readonly FacebookObjectCollection<User> r_FriendsList;
        private IFriendsFilter m_FriendsFilter;

        public BirthdayInAWeekFeature(FacebookObjectCollection<User> i_FriendsList, IFriendsFilter i_FriendsFilter)
        {
            r_FriendsList = i_FriendsList;
            m_FriendsFilter = i_FriendsFilter;
        }

        public IEnumerator<User> GetEnumerator()
        {
            foreach (User friend in r_FriendsList)
            {
                if (checkIfFriendsBirthdayInAWeek(friend) && m_FriendsFilter.FilterFriendsByGender(friend))
                {
                   yield return friend;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private bool checkIfFriendsBirthdayInAWeek(User i_Friend)
        {
            return DateTime.Now.AddDays(7).ToShortDateString() == i_Friend.Birthday;
        }
    }
}
