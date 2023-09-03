using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookWinFormsApp
{
    public class EventBuilder
    {
        private readonly FormEvents r_FormEvents;
        private readonly DateTime r_StartTime;
        private readonly DateTime r_EndTime;
        private readonly int r_MaximumAttendings;
        private readonly FacebookObjectCollection<Event> r_Events;
        private FacebookObjectCollection<Event> m_ChosenEvents;

        public EventBuilder(DateTime i_StartTime, DateTime i_EndTime, int i_MaximumAttendings, FacebookObjectCollection<Event> i_Events)
        {
            r_StartTime = i_StartTime;
            r_EndTime = i_EndTime;
            r_MaximumAttendings = i_MaximumAttendings;
            r_Events = i_Events;
            m_ChosenEvents = new FacebookObjectCollection<Event>();
            fetchEvents();
            r_FormEvents = new FormEvents(m_ChosenEvents);
            displayFormChosenEvents();
        }

        private void displayFormChosenEvents()
        {
            if(m_ChosenEvents.Count > 0)
            {
                r_FormEvents.ShowDialog();
            }
        }

        private void fetchEvents()
        {
            try
            {
                foreach (Event fbEvent in r_Events)
                {
                    if (checkIfDesiredEvent(fbEvent))
                    {
                        m_ChosenEvents.Add(fbEvent);
                    }
                }

                if (m_ChosenEvents.Count == 0)
                {
                    MessageBox.Show("No Events!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        private bool checkIfDesiredEvent(Event i_Event)
        {
            return i_Event.StartTime >= r_StartTime && i_Event.EndTime <= r_EndTime 
                && i_Event.AttendingCount <= r_MaximumAttendings;
        }
    }
}
