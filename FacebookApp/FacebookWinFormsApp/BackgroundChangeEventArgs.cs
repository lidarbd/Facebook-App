using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FacebookWinFormsApp
{
    public delegate void BackgroundChangeEventHandler(BackgroundChangeEventArgs e);

    public class BackgroundChangeEventArgs : EventArgs
    {
        private Image m_Background;

        public BackgroundChangeEventArgs(Image i_Background)
        {
            m_Background = i_Background;
        }

        public Image Background
        {
            get { return m_Background; }
        }
    }
}
