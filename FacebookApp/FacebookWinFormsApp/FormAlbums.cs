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
using FacebookAppLogic;

namespace FacebookWinFormsApp
{
    public partial class FormAlbums : Form
    {
        private readonly User r_LoggedInUser;

        public FormAlbums(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(fetchAlbums).Start();
        }

        private void fetchAlbums()
        {
            try
            {
                listBoxAlbums.Invoke(new Action(() => albumBindingSource.DataSource = r_LoggedInUser.Albums));

                if (r_LoggedInUser.Albums.Count == 0)
                {
                    MessageBox.Show("No Albums to retrieve :(");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
