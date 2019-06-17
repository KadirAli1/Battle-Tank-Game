using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Battle_Tank.Properties;

namespace Battle_Tank
{
    public partial class TankMovements : Form
    {
        private bool goright;
        private bool goleft;
        private Image image;
        private Image oldImage;
        private int angle;
        public TankMovements()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            image = new Bitmap(Resources.tank);
            tank.Image = (Bitmap)image.Clone();
            oldImage = tank.Image;
            tank.BackColor = Color.Transparent;
            timer1.Start();
        }

        private void TankMovements_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
        }

        private void TankMovements_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (goright)
            {
                angle += 10;
                tank.Image = Rotate.RotateImage(image, angle);

                if (oldImage != null)
                {
                    oldImage.Dispose();
                }
            }
            if (goleft)
            {

                angle -= 10;
                tank.Image = Rotate.RotateImage(image, angle);
                if (oldImage != null)
                {
                    oldImage.Dispose();
                }

            }
        }
    }
}
