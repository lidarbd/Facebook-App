using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookAppLogic;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookWinFormsApp
{
    public partial class FormTopThreePhotos : Form
    {
        private readonly TopThreePhotosFeature r_TopThreePhotosFeature;
        private readonly string r_UserName;
        
        public FormTopThreePhotos(FacebookObjectCollection<Photo> i_Photos, string i_UserName)
        {
            r_TopThreePhotosFeature = new TopThreePhotosFeature(i_Photos);
            r_UserName = i_UserName;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            displayPhotosInfo(r_TopThreePhotosFeature.TopPhotosInfo.Photos, r_TopThreePhotosFeature.TopPhotosInfo.CommentsAmount);
            displayMostResponsiveFriendsNames();
        }

        private void displayMostResponsiveFriendsNames()
        {
            labelMaleFriendName.Text = r_TopThreePhotosFeature.MostResponsiveMaleFriendName(r_UserName);
            labelFemaleFriendName.Text = r_TopThreePhotosFeature.MostResponsiveFemaleFriendName(r_UserName);
        }

        private void displayPhotosInfo(Photo[] i_Photos, int[] i_CommentsAmount)
        {
            getPhotosInfo(pictureBoxFirst, labelMostLikesAmount, i_CommentsAmount[TopThreePhotosFeature.k_MostPopular], i_Photos[TopThreePhotosFeature.k_MostPopular].PictureNormalURL);
            getPhotosInfo(pictureBoxSecond, labelMiddleLikesAmount, i_CommentsAmount[TopThreePhotosFeature.k_MiddlePopular], i_Photos[TopThreePhotosFeature.k_MiddlePopular].PictureNormalURL);
            getPhotosInfo(pictureBoxThird, labelLessLikesAmount, i_CommentsAmount[TopThreePhotosFeature.k_LessPopular], i_Photos[TopThreePhotosFeature.k_LessPopular].PictureNormalURL);
        }

        private void getPhotosInfo(PictureBox i_PictureBox, Label i_Label, int i_CommentsAmount, string i_Photo)
        {
            if (i_Photo != null)
            {
                i_PictureBox.LoadAsync(i_Photo);
                i_Label.Text = i_CommentsAmount.ToString() + " Comments";
            }
            else
            {
                i_PictureBox.Image = BasicFacebookFeatures.Properties.Resources.noImage;
                i_Label.Text = "No Comments.";
            }
        }

        private void pictureBoxFirst_Click(object sender, EventArgs e)
        {
            fetchCommentsOnChosenPicture(r_TopThreePhotosFeature.TopPhotosInfo.Photos[0]);
        }

        private void pictureBoxSecond_Click(object sender, EventArgs e)
        {
            fetchCommentsOnChosenPicture(r_TopThreePhotosFeature.TopPhotosInfo.Photos[1]);
        }

        private void pictureBoxThird_Click(object sender, EventArgs e)
        {
            fetchCommentsOnChosenPicture(r_TopThreePhotosFeature.TopPhotosInfo.Photos[2]);
        }

        private void fetchCommentsOnChosenPicture(Photo i_ChosenPicture)
        {
            listBoxComments.Items.Clear();
            listBoxComments.DisplayMember = "Message";
            foreach (Comment comment in i_ChosenPicture.Comments)
            {
                listBoxComments.Items.Add(comment);
            }
        }
    }
}
