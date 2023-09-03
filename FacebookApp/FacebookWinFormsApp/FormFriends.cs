using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookWinFormsApp
{
    public partial class FormFriends : Form
    {
        private readonly FacebookObjectCollection<User> r_Friends;

        public FormFriends(FacebookObjectCollection<User> i_Friends)
        {
            r_Friends = i_Friends;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(fetchFriends).Start();
        }

        private void fetchFriends()
        {
            try
            {
                listBoxFriends.Invoke(new Action(() => userBindingSource.DataSource = r_Friends));
                if (r_Friends.Count == 0)
                {
                    MessageBox.Show("No Friends!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
