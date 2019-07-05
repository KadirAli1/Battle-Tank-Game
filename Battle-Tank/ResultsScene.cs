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
    public partial class ResultsScene : Form
    {
        public NewGame NewGame { get; set; }
        public string Player1Name { get; set; }
        public string Player2Name { get; set; }
        public ResultsScene()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
        }

        private void ResultsScene_Load(object sender, EventArgs e)
        {
            //lblScore1.Font = new Font("PosterBodoni BT", 12,style:FontStyle.Bold);
            
            //lblScore2.Font = new Font("PosterBodoni BT", 12,style:FontStyle.Bold);

            newGamebtn.BackColor = Color.Transparent;
            exitBtn.BackColor = Color.Transparent;

            responsiveFeature();
            checkWinner();
           
        }

        public void responsiveFeature()
        {
            newGamebtn.SizeMode = PictureBoxSizeMode.StretchImage;
            newGamebtn.Dock = DockStyle.Top;
            newGamebtn.Anchor = AnchorStyles.Top;

            exitBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            exitBtn.Dock = DockStyle.Top;
            exitBtn.Anchor = AnchorStyles.Top;

            lblScore1.Dock = DockStyle.Top;
            lblScore1.Anchor = AnchorStyles.Top;

            lblScore2.Dock = DockStyle.Top;
            lblScore2.Anchor = AnchorStyles.Top;

            looserScore.Dock = DockStyle.Top;
            looserScore.Anchor = AnchorStyles.Top;

            winnerScore.Dock = DockStyle.Top;
            winnerScore.Anchor = AnchorStyles.Top;
        }

        private void newGamebtn_MouseEnter(object sender, EventArgs e)
        {
            newGamebtn.SizeMode = PictureBoxSizeMode.StretchImage;
            newGamebtn.Cursor = Cursors.Hand;
        }

        private void newGamebtn_MouseLeave(object sender, EventArgs e)
        {
            newGamebtn.SizeMode = PictureBoxSizeMode.Zoom;
            newGamebtn.Cursor = Cursors.Default;
        }

        private void exitBtn_MouseEnter(object sender, EventArgs e)
        {
            exitBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            exitBtn.Cursor = Cursors.Hand;
        }

        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.SizeMode = PictureBoxSizeMode.Zoom;
            exitBtn.Cursor = Cursors.Default;
        }

        public void checkWinner()
        {
            if (NewGame.Player1.Points > NewGame.Player2.Points)
            {
                this.BackgroundImage = Resources.GreenTankWinner;
                winnerScore.Text = NewGame.Player1.Points.ToString();
                looserScore.Text = NewGame.Player2.Points.ToString();
            }
            else
            {
                this.BackgroundImage = Resources.BrownTankWinner;
                winnerScore.Text = NewGame.Player2.Points.ToString();
                looserScore.Text = NewGame.Player1.Points.ToString();
            }
        }

        private void newGamebtn_Click(object sender, EventArgs e)
        {
            MainScene ms = new MainScene();
            ms.Show();
            this.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
