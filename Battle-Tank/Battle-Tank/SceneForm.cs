using Battle_Tank.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battle_Tank
{
    public partial class SceneForm : Form
    {
        Scenes Scenes;
        public SceneForm()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            //label1.Text = this.Width + " " + this.Height;
            Scenes = new Scenes(this.Width, this.Height);
        }

        private void SceneForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            Pen pen = new Pen(Color.Black, 1);

            //label1.Text = this.Width + " " + this.Height + "\n" +
            //    Scenes.ScenesList[0].X + " " + Scenes.ScenesList[0].Y;
            Scenes.Draw(pen, g);


            //for(int i = 0; i < 10; ++i)
            //    g.DrawImage(Resources.MuriHorizontal, i * 94 + 20, 20 - 3);
            //for (int i = 0; i < 10; ++i)
            //    g.DrawImage(Resources.MuriHorizontal, i * 94 + 20, 7 * 80+(20 - 3));

            //for (int i = 0; i < 7; ++i)
            //    g.DrawImage(Resources.MuriVertical, 20-1, i * 80 + (20 - 3));
            //for (int i = 0; i < 7; ++i)
            //    g.DrawImage(Resources.MuriVertical, 10 * 94 + 20 - 1, i * 80 + (20 - 3));

            pen.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
