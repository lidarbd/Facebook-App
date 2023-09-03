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
    public partial class FormFavoriteTeams : Form
    {
        private readonly Page[] r_FavoriteTeams;

        public FormFavoriteTeams(Page[] i_FavoriteTeams)
        {
            r_FavoriteTeams = i_FavoriteTeams;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(fetchFavoriteTeams).Start();
        }

        private void fetchFavoriteTeams()
        {
            try
            {
                if (r_FavoriteTeams == null)
                {
                    MessageBox.Show("No Favorite Teams!");
                }
                else
                {
                    listBoxFavoriteTeams.Invoke(new Action(() => pageBindingSource.DataSource = r_FavoriteTeams));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
