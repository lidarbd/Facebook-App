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
    public partial class FormBirthdayInAWeek : Form
    {
        private readonly List<string> r_FriendsNames;

        public FormBirthdayInAWeek(List<string> i_FriendsNamesWhoHaveBirthdayInAWeek)
        {
            r_FriendsNames = i_FriendsNamesWhoHaveBirthdayInAWeek;
            InitializeComponent();
            updateLabelBirthdayInAWeekText();
        }

        private void updateLabelBirthdayInAWeekText()
        {
            if (r_FriendsNames.Count > 0)
            {
               textBoxBirthdayInAWeek.Text = string.Format(
@"Notice! 
{0}Have birthday in a week.
BE PREPARED :)", 
convertNamesListToString());
            }
            else
            {
                textBoxBirthdayInAWeek.Text = "There Are No Celebrations Soon.";
            }
        }

        private string convertNamesListToString()
        {
            string names = string.Empty;

            foreach (string name in r_FriendsNames)
            {
                names += name + Environment.NewLine;
            }

            return names;
        }

        private void linkLabelBuyMe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                visitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void visitLink()
        {
            linkLabelBuyMe.LinkVisited = true;
            System.Diagnostics.Process.Start("https://buyme.co.il/?gclid=CjwKCAjwi8iXBhBeEiwAKbUofU9bRSD6eLDQJu9UHz-kf5NpEQcN_BGI9yR1rXCSPmFD4m2dZVqQ7xoCFegQAvD_BwE");
        }
    }
}
