using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Battle_Tank_Game.Properties;

namespace Battle_Tank_Game
{
    public partial class KeysForm : Form
    {
        public KeysForm()
        {
            InitializeComponent();
        }

        bool exit = true;
        private void PictureBox6_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }


        //PcitureBox6 = EXit
        //Старт на свук и зумирање на бутонот
        private void PictureBox6_MouseEnter(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Resources.ding);
            soundPlayer.Play();
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.Cursor = Cursors.Hand;
        }
        // намалување на бутонот односно враќање на оргинална состојба.
        private void PictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.Cursor = Cursors.Default;
        }
    }
}
