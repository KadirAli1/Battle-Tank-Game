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
    public partial class ResultsScene : Form
    {
        public ResultsScene()
        {
            InitializeComponent();
        }

        private void ResultsScene_Load(object sender, EventArgs e)
        {
            //lblScore1.Font = new Font("PosterBodoni BT", 12,style:FontStyle.Bold);
            
            //lblScore2.Font = new Font("PosterBodoni BT", 12,style:FontStyle.Bold);

            newGamebtn.BackColor = Color.Transparent;
            exitBtn.BackColor = Color.Transparent;

            responsiveFeature();
           
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
    }
}
