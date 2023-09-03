using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookAppLogic;

namespace FacebookWinFormsApp
{ 
    public partial class FormMain : Form
    {
        private readonly FormLogin r_FormLogin;
        private LogicManager m_LogicManager;
        private FormAlbums m_FormAlbums;
        private FormLikedPages m_FormLikedPages;
        private FormGroups m_FormGroups;
        private FormEventDirector m_FormEventDirector;
        private FormPosts m_FormPosts;
        private FormFriends m_FormFriends;
        private FormFavoriteTeams m_FormFavoriteTeams;
        private FormTopThreePhotos m_FormTopThreePhotos;
        private FormBirthdayInAWeekFilter m_FormBirthdayInAWeekFilter;
        private FormBackgrounds m_FormBackgrounds;
        private SmartPictureBox m_SmartPictureBox;

        public FormMain()
        {
            r_FormLogin = FormFactory.CreateNewObject(FormFactory.eFormType.Login, null) as FormLogin;
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            loginIfNotConnected();
            showDialogByUserChoice();
        }

        private void initializeSmartPictureBox()
        {
            m_SmartPictureBox = new SmartPictureBox();
            m_SmartPictureBox.BackgroundChanged += formMain_BackgroundChangeOccured;
        }

        private bool checkIfExitFormLogin()
        {
            return r_FormLogin.GetLastAccessToken() == null;
        }

        private void showDialogByUserChoice()
        {
            if (checkIfExitFormLogin())
            {
                this.Close();
            }
            else
            {
                this.Visible = true;
                initializeForms();
                initializeSmartPictureBox();
                fetchUserInfo();
            }
        }

        private void initializeForms()
        {
            new Thread(() => m_FormAlbums = FormFactory.CreateNewObject(FormFactory.eFormType.Albums, m_LogicManager) as FormAlbums).Start();
            new Thread(() => m_FormLikedPages = FormFactory.CreateNewObject(FormFactory.eFormType.LikedPages, m_LogicManager) as FormLikedPages).Start();
            new Thread(() => m_FormEventDirector = FormFactory.CreateNewObject(FormFactory.eFormType.EventDirector, m_LogicManager) as FormEventDirector).Start();
            new Thread(() => m_FormGroups = FormFactory.CreateNewObject(FormFactory.eFormType.Groups, m_LogicManager) as FormGroups).Start();
            new Thread(() => m_FormFavoriteTeams = FormFactory.CreateNewObject(FormFactory.eFormType.FavoriteTeams, m_LogicManager) as FormFavoriteTeams).Start();
            new Thread(() => m_FormFriends = FormFactory.CreateNewObject(FormFactory.eFormType.Friends, m_LogicManager) as FormFriends).Start();
            new Thread(() => m_FormPosts = FormFactory.CreateNewObject(FormFactory.eFormType.Posts, m_LogicManager) as FormPosts).Start();
            m_FormTopThreePhotos = FormFactory.CreateNewObject(FormFactory.eFormType.TopThreePhotos, m_LogicManager) as FormTopThreePhotos;
        }
      
        private void loginIfNotConnected()
        {
            if (!r_FormLogin.CheckIfRememberUser())
            {
                r_FormLogin.ShowDialog();
            }

            m_LogicManager = r_FormLogin.LogicManager;
        }

        protected override void OnShown(EventArgs e)
        {
            displayFriendsWhoHaveBirthdayInAWeek();
            base.OnShown(e);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            m_LogicManager.SaveDataAfterExit();
        }

        private void displayFriendsWhoHaveBirthdayInAWeek()
        {
            new Thread(() => 
            {
                m_FormBirthdayInAWeekFilter = FormFactory.CreateNewObject(FormFactory.eFormType.BirthdayInAWeekFilter, m_LogicManager) as FormBirthdayInAWeekFilter;
                m_FormBirthdayInAWeekFilter.ShowDialog();
            }).Start();
        }

        private void fetchUserInfo()
        {
            labelLogin.Text = $"Hello {m_LogicManager.LoggedInUser.Name}";
            pictureBoxProfile.LoadAsync(m_LogicManager.LoggedInUser.PictureNormalURL);
            displayCoverPhoto(m_LogicManager.GetUsersCoverAlbum());
        }

        private void displayCoverPhoto(Album i_CoverAlbum)
        {
            if(i_CoverAlbum.Count > 0)
            {
                pictureBoxCover.Image = i_CoverAlbum.Photos[0].ImageNormal;
            }
            else
            {
                pictureBoxCover.Image = BasicFacebookFeatures.Properties.Resources.noImage;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            m_LogicManager.AppSettings.RememberUser = false;
            this.Visible = false;
            m_LogicManager.SaveDataAfterExit();
            FormMain formMain = FormFactory.CreateNewObject(FormFactory.eFormType.Main, null) as FormMain;
        }

        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = m_LogicManager.LoggedInUser.PostStatus(textBoxStatus.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonAlbums_Click(object sender, EventArgs e)
        {
            m_FormAlbums.ShowDialog();
        }

        private void buttonLikedPages_Click(object sender, EventArgs e)
        {
            m_FormLikedPages.ShowDialog();
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            m_FormEventDirector.ShowDialog();
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            m_FormGroups.ShowDialog();
        }

        private void buttonFavoriteTeams_Click(object sender, EventArgs e)
        {
            m_FormFavoriteTeams.ShowDialog();
        }

        private void buttonFriends_Click(object sender, EventArgs e)
        {
            m_FormFriends.ShowDialog();
        }

        private void buttonPosts_Click(object sender, EventArgs e)
        {
            m_FormPosts.ShowDialog();
        }

        private void buttonTopThreePhotos_Click(object sender, EventArgs e)
        {
            m_FormTopThreePhotos.ShowDialog();
        }

        private void buttonBackground_Click(object sender, EventArgs e)
        {
            m_FormBackgrounds = new FormBackgrounds(m_SmartPictureBox);
            m_FormBackgrounds.ShowDialog();
        }

        private void formMain_BackgroundChangeOccured(Image i_Background)
        {
            BackgroundImage = i_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
