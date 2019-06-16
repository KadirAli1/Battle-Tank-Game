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
            Scenes = new Scenes();
        }

        private void SceneForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            Pen pen = new Pen(Color.Black, 5);

            Scenes.Draw(pen, g);

            pen.Dispose();
        }
    }
}
