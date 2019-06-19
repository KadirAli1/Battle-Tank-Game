using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Battle_Tank_Game.Properties;

namespace Battle_Tank_Game

{

    public partial class MainScene : Form
    { 
        public MainScene()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

        } 

    
        private void PictureBox2_MouseLeave(object sender, EventArgs e)
        {

            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Cursor = Cursors.Default;
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Cursor = Cursors.Default;
        
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            //SceneForm sceneForm = new SceneForm();
            //if(sceneForm.ShowDialog() == DialogResult.OK)
            //{
            //    sceneForm.AddOwnedForm(sceneForm);
            //}

        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Player 1");
        }

        private void PictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Player 2");
        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Cursor = Cursors.Hand;
        }

        private void PictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Cursor = Cursors.Hand;
        }

 

   
        private void PictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Cursor = Cursors.Hand;
        }

        private void PictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.Cursor = Cursors.Default;
        }

    
    }
}
