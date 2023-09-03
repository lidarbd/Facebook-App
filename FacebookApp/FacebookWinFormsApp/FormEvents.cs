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
    public partial class FormEvents : Form
    {
        private readonly FacebookObjectCollection<Event> r_Events;

        public FormEvents(FacebookObjectCollection<Event> i_Events)
        {
            r_Events = i_Events;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(fetchEvents).Start();
        }

        private void fetchEvents()
        {
            try
            {
                listBoxEvents.Invoke(new Action(() => eventBindingSource.DataSource = r_Events));
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
