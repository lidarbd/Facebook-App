using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookWinFormsApp
{
    public partial class FormBackgrounds : Form
    {
        private SmartPictureBox m_ChosenBackground;

        public FormBackgrounds(SmartPictureBox i_ChosenBackground)
        {
            m_ChosenBackground = i_ChosenBackground;
            InitializeComponent();
            initializeSmartPictureBox();
        }

        private void initializeSmartPictureBox()
        {
            int top = 3;

            foreach (Image currentImage in imageList.Images)
            {
                SmartPictureBox background = new SmartPictureBox();
                background.SizeMode = PictureBoxSizeMode.StretchImage;
                background.Size = new System.Drawing.Size(100, 50);
                background.Image = currentImage;
                background.Left = 3;
                background.Top = top;
                top = background.Bottom + 2;
                background.Click += smartPictureBox_Click;
                this.Controls.Add(background);
            }
        }

        private void smartPictureBox_Click(object sender, EventArgs e)
        {
            m_ChosenBackground.Background = (sender as SmartPictureBox).Image;
            m_ChosenBackground.OnBackgroundChanged();
        }
    }
}
