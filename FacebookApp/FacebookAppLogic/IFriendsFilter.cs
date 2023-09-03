using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookAppLogic
{
    public interface IFriendsFilter
    {
        bool FilterFriendsByGender(User i_Friend);
    }
}
