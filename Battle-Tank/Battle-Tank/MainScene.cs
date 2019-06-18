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
    
    public partial class MainScene : Form
    {

        Image play = Resources.play_1;
        Image player1 = Resources._1_player_1;
        Image player2 = Resources._2_players_1;
        Image keys = Resources.keys_1;
        Image soundControl = Resources.sound_control;
        public MainScene()
        {
            InitializeComponent();
            pictureBox1.Image = player1;
            pictureBox2.Image = player2;
            pictureBox3.Image = play;
            pictureBox4.Image = keys;
            pictureBox5.Image = soundControl;
        }
        private void PictureBox1_MouseHover(object sender, EventArgs e)
        {
            int singlePlayer_Width = player1.Width + ((player1.Width * 10) / 100);
            int singlePlayer_Height = player1.Height + ((player1.Height * 10) / 100);

            Bitmap SingelPlayer = new Bitmap(singlePlayer_Width, singlePlayer_Height);
            Graphics g = Graphics.FromImage(SingelPlayer);
            g.DrawImage(player1, new Rectangle(Point.Empty, SingelPlayer.Size));
            pictureBox1.Image = SingelPlayer;


        }

        private void PictureBox2_MouseHover(object sender, EventArgs e)
        {
            int Player2_Width = player2.Width + ((player2.Width * 5) / 100);
            int Player2_Height = player2.Height + ((player2.Height * 5) / 100);
            Bitmap Player2_1 = new Bitmap(Player2_Width, Player2_Height);
            Graphics g = Graphics.FromImage(Player2_1);
            g.DrawImage(player2, new Rectangle(Point.Empty, Player2_1.Size));
            pictureBox2.Image = Player2_1;
        }

        private void PictureBox3_MouseHover(object sender, EventArgs e)
        {
            int Play_Width = play.Width + ((play.Width * 5) / 100);
            int Play_Height = play.Height + ((play.Height * 5) / 100);
            Bitmap Play_1 = new Bitmap(Play_Width, Play_Height);
            Graphics g = Graphics.FromImage(Play_1);
            g.DrawImage(play, new Rectangle(Point.Empty, Play_1.Size));
            pictureBox3.Image = Play_1;
        }

        private void PictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = play;
        }

        private void PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = player2;
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = player1;
        }
    }
}
