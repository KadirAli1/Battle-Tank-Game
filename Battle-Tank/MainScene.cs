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
using System.Media;
using System.Configuration;
using System.Data.SqlClient;

namespace Battle_Tank

{

    public partial class MainScene : Form
    {
        private bool clicked = false;
        SqlConnection connection;
        string connectionString;
        public string Player1Name { get; set; }
        public string Player2Name { get; set; }
        public MainScene()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Battle_Tank.Properties.Settings.UsersDatabaseConnectionString"].ConnectionString;
            this.DoubleBuffered = true;
            //this.WindowState = FormWindowState.Maximized;
        } 

            //2Player PictureBox
        //private void PictureBox2_MouseLeave(object sender, EventArgs e)
        //{
        //    if(clicked == false)
        //    {
        //        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        //        pictureBox2.Cursor = Cursors.Default;
        //    }
        //    else
        //    {
        //        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        //        pictureBox2.Cursor = Cursors.Default;
        //    }
          
        //}

        //1Player PictureBox
        //private void PictureBox1_MouseLeave(object sender, EventArgs e)
        //{
        //    if(clicked == false)
        //    {
        //        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        //        pictureBox1.Cursor = Cursors.Default;
        //    }
        //    else
        //    {
        //        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        //        pictureBox2.Cursor = Cursors.Default;
              
        //    }
        //}

        //Play -PcitureBox
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            //SceneForm sceneForm = new SceneForm();
            //if(sceneForm.ShowDialog() == DialogResult.OK)
            //{
            //    sceneForm.AddOwnedForm(sceneForm);
            //}

        }

        //private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        //{
        //    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        //    pictureBox1.Cursor = Cursors.Hand;
        //    clicked = true;
        //    MessageBox.Show("Player 1");
        //}

 
        

        //private void PictureBox2_MouseClick(object sender, MouseEventArgs e)
        //{
        //    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        //    pictureBox2.Cursor = Cursors.Hand;
        //    clicked = true;
        //    MessageBox.Show("Player 2");
        //}

        //private void PictureBox1_MouseEnter(object sender, EventArgs e)
        //{
        //    SoundPlayer soundPlayer = new SoundPlayer(Resources.ding);
        //    soundPlayer.Play();
        //    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        //    pictureBox1.Cursor = Cursors.Hand;
        //}

        //private void PictureBox2_MouseEnter(object sender, EventArgs e)
        //{
        //    SoundPlayer soundPlayer = new SoundPlayer(Resources.ding);
        //    soundPlayer.Play();
        //    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        //    pictureBox2.Cursor = Cursors.Hand;
        //}

 

   
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
        private void PictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            if (soundOn == true)
            {
                pictureBox5.Image = Resources.sound_control_off;
                soundOn = false;
                SoundPlayer sound = new SoundPlayer(Resources.song__online_audio_converter_com_);
                sound.Stop();
            }
            else
            { 
                pictureBox5.Image = Resources.sound_control;
                soundOn = true;
                SoundPlayer sound = new SoundPlayer(Resources.song__online_audio_converter_com_);
                sound.Play();
            }

        }

        private void MainScene_Load(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(Resources.song__online_audio_converter_com_);
            sound.Play();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //string query = "UPDATE Users SET Points = 44444 WHERE UserName = @UserName";
            LoginForm loginForm = new LoginForm();
            //Control userName = null;
            //foreach (Control c in loginForm.Controls)
            //{
            //    if(c.Name == "tbUsername")
            //    {
            //        userName = c;
            //    }
            //}

            DialogResult result = loginForm.ShowDialog();

            //if (result == DialogResult.OK)
            //{
            //    MessageBox.Show(userName.Text);
            //    using (connection = new SqlConnection(connectionString))
            //    using (SqlCommand command1 = new SqlCommand(query, connection))
            //    {
            //        connection.Open();
            //        command1.Parameters.AddWithValue("@UserName", userName.Text);

            //        command1.ExecuteScalar();
            //    }
            //}

            //else
            //{
            //    MessageBox.Show(userName.Text + "ELSE");
            //}
        }

        private void pbScores_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Player1Name = "Player 1";
            Player2Name = "Player 2";
            SceneForm sceneForm = new SceneForm(Player1Name, Player2Name);
            //MessageBox.Show(Player1Name, Player2Name);
            DialogResult result = sceneForm.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
