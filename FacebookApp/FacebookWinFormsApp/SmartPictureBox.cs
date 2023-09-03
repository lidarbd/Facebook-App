using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FacebookWinFormsApp
{
    public class SmartPictureBox : PictureBox
    {
        public event Action<Image> BackgroundChanged;

        public Image Background { get; set; }

        public void OnBackgroundChanged()
        {
            if(BackgroundChanged != null)
            {
                BackgroundChanged.Invoke(Background);
            }
        }
    }
}
