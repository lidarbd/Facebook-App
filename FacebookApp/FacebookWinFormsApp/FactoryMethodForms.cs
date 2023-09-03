using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookAppLogic;

namespace FacebookWinFormsApp
{
    public static class FormFactory
    {
        public enum eFormType
        {
            Albums = 1,
            Events,
            BirthdayInAWeekFilter,
            EventDirector,
            FavoriteTeams,
            Friends,
            Groups,
            LikedPages,
            Posts,
            TopThreePhotos,
            Login,
            Main
        }

        public static Form CreateNewObject(eFormType i_FormType, LogicManager i_LogicManager)
        {
            Form form;

            switch (i_FormType)
            {
                case eFormType.Albums:
                    form = new FormAlbums(i_LogicManager.LoggedInUser);
                    break;
                case eFormType.BirthdayInAWeekFilter:
                    form = new FormBirthdayInAWeekFilter(i_LogicManager);
                    break;
                case eFormType.EventDirector:
                    form = new FormEventDirector(i_LogicManager.LoggedInUser.Events);
                    break;
                case eFormType.FavoriteTeams:
                    form = new FormFavoriteTeams(i_LogicManager.LoggedInUser.FavofriteTeams);
                    break;
                case eFormType.Friends:
                    form = new FormFriends(i_LogicManager.LoggedInUser.Friends);
                    break;
                case eFormType.Groups:
                    form = new FormGroups(i_LogicManager.LoggedInUser.Groups);
                    break;
                case eFormType.LikedPages:
                    form = new FormLikedPages(i_LogicManager.LoggedInUser.LikedPages);
                    break;
                case eFormType.Login:
                    form = new FormLogin();
                    break;
                case eFormType.Posts:
                    form = new FormPosts(i_LogicManager.LoggedInUser.Posts);
                    break;
                case eFormType.TopThreePhotos:
                    form = new FormTopThreePhotos(i_LogicManager.GetUsersProfilePicturesAlbum().Photos, i_LogicManager.LoggedInUser.Name);
                    break;
                case eFormType.Main:
                    form = new FormMain();
                    break;
                default:
                    form = new Form();
                    break;
            }

            return form;
        }
    }
}
