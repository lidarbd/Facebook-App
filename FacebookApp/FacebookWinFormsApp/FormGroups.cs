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
    public partial class FormGroups : Form
    {
        private readonly FacebookObjectCollection<Group> r_Groups;

        public FormGroups(FacebookObjectCollection<Group> i_Groups)
        {
            r_Groups = i_Groups;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(fetchGroups).Start();
        }

        private void fetchGroups()
        {
            try
            {
                listBoxGroups.Invoke(new Action(() => groupBindingSource.DataSource = r_Groups));
                if (r_Groups.Count == 0)
                {
                    MessageBox.Show("No Groups!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
