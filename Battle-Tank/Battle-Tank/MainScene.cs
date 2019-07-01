﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Battle_Tank_Game.Properties;
using System.Media;

namespace Battle_Tank_Game

{

    public partial class MainScene : Form
    {
        KeysForm keys;
        private bool clicked = false;
        public MainScene()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        
        } 

            //2Player PictureBox
        private void PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            if(clicked == false)
            {
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.Cursor = Cursors.Default;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Cursor = Cursors.Default;
            }
          
        }

        //1Player PictureBox
        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if(clicked == false)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Cursor = Cursors.Default;
            }
            else
            {
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.Cursor = Cursors.Default;
              
            }


        }

        //Play -PcitureBox
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
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Cursor = Cursors.Hand;
            clicked = true;
            MessageBox.Show("Player 1");
        }

 
        

        private void PictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Cursor = Cursors.Hand;
            clicked = true;
            MessageBox.Show("Player 2");
        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Resources.ding);
            soundPlayer.Play();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Cursor = Cursors.Hand;
        }

        private void PictureBox2_MouseEnter(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Resources.ding);
            soundPlayer.Play();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Cursor = Cursors.Hand;
        }

 

   
        private void PictureBox3_MouseEnter(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Resources.ding);
            soundPlayer.Play();
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Cursor = Cursors.Hand;
        }

        private void PictureBox3_MouseLeave(object sender, EventArgs e)
        {

            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.Cursor = Cursors.Default;
        }

        private void PictureBox4_MouseEnter(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Resources.ding);
            soundPlayer.Play();
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Cursor = Cursors.Hand;
        }

        private void PictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.Cursor = Cursors.Default;
        }

        private void PictureBox5_MouseEnter(object sender, EventArgs e)
        {
            if(soundOn == clicked)
            {
                  SoundPlayer soundPlayer = new SoundPlayer(Resources.ding);
                 soundPlayer.Play();
            }

            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Cursor = Cursors.Hand;
        }

        private void PictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.Cursor = Cursors.Default;
        }

        private void PictureBox8_MouseEnter(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Resources.ding);
            soundPlayer.Play();
            pbScores.SizeMode = PictureBoxSizeMode.StretchImage;
            pbScores.Cursor = Cursors.Hand;
        }

        private void PictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pbScores.SizeMode = PictureBoxSizeMode.Zoom;
            pbScores.Cursor = Cursors.Default;
        }

        private void PictureBox6_MouseEnter(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Resources.ding);
            soundPlayer.Play();
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.Cursor = Cursors.Hand;
        }

        private void PictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.Cursor = Cursors.Default;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        bool soundOn = true;
        //PictureBox5 = Sound_on Sound_off
         //Changing
        private void PictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            if (soundOn == true)
            {
                pictureBox5.Image = Properties.Resources.sound_control_off;
                soundOn = false;
                SoundPlayer sound = new SoundPlayer(Resources.song__online_audio_converter_com_);
                sound.Stop();
            }
            else
            { 
                pictureBox5.Image = Properties.Resources.sound_control;
                soundOn = true;
                SoundPlayer sound = new SoundPlayer(Resources.song__online_audio_converter_com_);
                sound.Play();
            }

        }
        //Музика која шѕо се активизира при отворање на скената MainScene
        //Кериаремо Објект од  класта system.Media.SoundPlayer и во Resourc folderот се наје мелодиѕата и се старува како Wav format.
        private void MainScene_Load(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(Resources.song__online_audio_converter_com_);
            sound.Play();

        }

        //PictureBox4  = Keys
        //После кликнање на PictureBox4(Keys) се отвара нова форма која што се вика КeysForm
        private void PictureBox4_Click(object sender, EventArgs e)
        {
            KeysForm keysForm = new KeysForm();
            if(keysForm.ShowDialog() == DialogResult.OK)
            {
                keysForm.AddOwnedForm(keysForm);
            }
        }
    }
}
