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
    public partial class FormEventDirector : Form
    {
        private readonly FacebookObjectCollection<Event> r_Events;
        private EventBuilder m_EventBuilder;

        public FormEventDirector(FacebookObjectCollection<Event> i_Events)
        {
            r_Events = i_Events;
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if(comboBoxMaxAttendings.SelectedItem == null)
            {
                MessageBox.Show("Please choose maximum attendings!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                m_EventBuilder = new EventBuilder(dateTimePickerStart.Value, dateTimePickerEnd.Value, int.Parse(comboBoxMaxAttendings.SelectedItem.ToString()), r_Events);
            }

            base.OnClosing(e);
        }
    }
}
