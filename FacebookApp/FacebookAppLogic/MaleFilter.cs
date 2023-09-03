using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookAppLogic
{
    public class MaleFilter : IFriendsFilter
    {
        public bool FilterFriendsByGender(User i_Friend)
        {
            return i_Friend.Gender == User.eGender.male;
        }
    }
}
