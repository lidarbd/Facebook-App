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
    public partial class FormBirthdayInAWeekFilter : Form
    {
        private readonly FacebookObjectCollection<User> r_Friends;
        private FormBirthdayInAWeek m_FormBirthdayInAWeek;
        private BirthdayInAWeekFeature m_BirthdayInAWeekFeature;
        
        public List<string> MatchFriends { get; set; }

        public FormBirthdayInAWeekFilter(LogicManager i_LogicManager)
        {
            r_Friends = i_LogicManager.LoggedInUser.Friends;
            MatchFriends = new List<string>();
            InitializeComponent();
        }

        private void setFriendsWhoHaveBirthdayInAWeek()
        {
            foreach (User friend in m_BirthdayInAWeekFeature)
            {
                MatchFriends.Add(friend.Name);
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (checkBoxMale.Checked == false && checkBoxFemale.Checked == false && checkBoxFemaleAndMale.Checked == false)
            {
                MessageBox.Show("Please mark your choice!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                filterFriendsByUserChoice();
                initializeFormBirthdayInAWeek();
                this.Close();
            }
        }

        private void initializeFormBirthdayInAWeek()
        {
            m_FormBirthdayInAWeek = new FormBirthdayInAWeek(MatchFriends);
            m_FormBirthdayInAWeek.ShowDialog();
        }

        private void filterFriendsByUserChoice()
        {
            if(checkBoxFemale.Checked)
            {
                m_BirthdayInAWeekFeature = new BirthdayInAWeekFeature(r_Friends, new FemaleFilter());
            }
            else if(checkBoxMale.Checked)
            {
                m_BirthdayInAWeekFeature = new BirthdayInAWeekFeature(r_Friends, new MaleFilter());
            }
            else
            {
                m_BirthdayInAWeekFeature = new BirthdayInAWeekFeature(r_Friends, new FemaleAndMaleFilter());
            }

            setFriendsWhoHaveBirthdayInAWeek();
        }

        private void checkBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxMale.Enabled = checkBoxFemaleAndMale.Enabled = !checkBoxFemale.Checked;
        }

        private void checkBoxMale_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxFemale.Enabled = checkBoxFemaleAndMale.Enabled = !checkBoxMale.Checked;
        }

        private void checkBoxFemaleAndMale_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxFemale.Enabled = checkBoxMale.Enabled = !checkBoxFemaleAndMale.Checked; 
        }
    }
}
