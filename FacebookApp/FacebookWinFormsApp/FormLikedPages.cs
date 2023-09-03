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
    public partial class FormLikedPages : Form
    {
        private readonly FacebookObjectCollection<Page> r_LikedPages;
        
        public FormLikedPages(FacebookObjectCollection<Page> i_LikedPages)
        {
            r_LikedPages = i_LikedPages;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(fetchLikedPages).Start();
        }

        private void fetchLikedPages()
        {
            try
            {
                listBoxPages.Invoke(new Action(() => pageBindingSource.DataSource = r_LikedPages));
                if (r_LikedPages.Count == 0)
                {
                    MessageBox.Show("No Liked Pages!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
