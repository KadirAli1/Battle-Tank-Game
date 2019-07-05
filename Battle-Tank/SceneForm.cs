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
        public NewGame NewGame { get; set; }
        Timer Clock;
        const int Interval = 15;
        bool forwardPlayer1 = false;
        bool backwardPlayer1 = false;
        bool leftRotatePlayer1 = false;
        bool rightRotatePlayer1 = false;

        bool forwardPlayer2 = false;
        bool backwardPlayer2 = false;
        bool leftRotatePlayer2 = false;
        bool rightRotatePlayer2 = false;

        public Tank Tank { get; set; }
        public static List<Bullet> Bullets { get; set; }

        private bool MClicked;
        private bool QClicked;
        private int MTime;
        private int QTime;

        private bool nextGame;
        private int nextGameTime;

        private int SceneNumber;

        private bool gameOver;
        private int totalGamesPlayed;



        // LAST SCENE
        PictureBox background;
        PictureBox newGamebtn;
        PictureBox exitGamebtn;
        Label score1;
        Label score2;
        Label scoreFirstPlayer;
        Label scoreSecondPlayer;
        Timer Clock2;
        int backgroundWidth;
        int backgroundHeight;
        int fixedLocationX;
        int fixedLocationY;
        int locationX;
        int locationY;
        bool clock2Started;

        public SceneForm(string Player1Name, string Player2Name)
        {
            InitializeComponent();
            DoubleBuffered = true;
            StartTheGame(Player1Name, Player2Name);
        }

        private void StartTheGame(string Player1Name, string Player2Name)
        {
            //FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized;
            //label1.Text = this.Width + " " + this.Height;
            Controls.Clear();
            this.WindowState = FormWindowState.Maximized;
            NewGame = new NewGame(this.Width, this.Height, Player1Name, Player2Name);
            Bullets = new List<Bullet>();
        
            MClicked = false;
            QClicked = false;
            MTime = 0;
            QTime = 0;

            nextGame = false;
            nextGameTime = 0;

            SceneNumber = 0;

            gameOver = false;
            totalGamesPlayed = 1;
            clock2Started = false;
            Initialize_Timer();
        }

        void Initialize_Timer()
        {
            // Create new timer
            Clock = new Timer();

            // Set timer tick interval in milliseconds
            //
            // By changing value of interval,
            // we control how often the timer tick event handler is raised
            // and eventually the call frequency of Main_Function()
            //
            Clock.Interval = Interval;

            //
            // Add timer tick event handler
            //
            // This event handler is raised
            // every time timer make tick
            //
            // The smaller value for timer interval,
            // more often the event handler is raised
            //
            Clock.Tick += new System.EventHandler(this.ClockTick);

            //
            // Start timer
            //
            Clock.Start();
        }

        void ClockTick(object sender, EventArgs e)
        {
            //
            // Timer tick event handler
            //
            if (nextGame)
            {
                nextGameTime += 15;
                if(nextGameTime > 3000)
                {
                    if(NewGame.Player1.Points == totalGamesPlayed || NewGame.Player2.Points == totalGamesPlayed)
                    {
                        gameOver = true;
                        Invalidate();
                        //Clock2.Start();
                    }
                    else
                    {
                        this.Controls.Clear();
                        nextGameTime = 0;
                        NewGame.Player1.Tank.IsTankBurned = false;
                        NewGame.Player1.Tank.IsTankBurned = false;
                        NewGame.Player1.Tank.Image = Resources.BrownTank;
                        NewGame.Player2.Tank.Image = Resources.BrownTank;
                        SceneNumber++;
                        NewGame.GenerateScene(SceneNumber);
                        NewGame.Player1.RefreshTanks(Tank.Position.LeftToRight);
                        NewGame.Player2.RefreshTanks(Tank.Position.RightToLeft);
                        nextGame = false;
                    }
                    
                }
            }
            else
            {
                if (MClicked)
                {
                    MTime += 15;
                    if (MTime > 200)
                    {
                        MClicked = false;
                        MTime = 0;
                    }
                }

                if (QClicked)
                {
                    QTime += 15;
                    if (QTime > 200)
                    {
                        QClicked = false;
                        QTime = 0;
                    }
                }

                Movement(NewGame.ActualScene);
            }
        }

        private void SceneForm_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            Color color = NewGame.ActualScene.BackgroundColor;
            g.Clear(color);
            Pen pen = new Pen(color, 1);

            

            if (gameOver)
            {
                Clock.Stop();
                //string message = NewGame.Player1.Name + "\t" + NewGame.Player2.Name + "\n" +
                //    "Score: " + NewGame.Player1.Points + "\tScore: " + NewGame.Player2.Points + "\n\n\n" +
                //    "Winner is: " + (NewGame.Player1.Points > NewGame.Player2.Points ? NewGame.Player1.Name : NewGame.Player2.Name);

                

                //MessageBox.Show(message);

                //this.Hide();
                //ResultsScene rs = new ResultsScene();

                //rs.ShowDialog();
                //this.Close();



                //BACKGROUND

                background.Size = new Size(backgroundWidth, backgroundHeight);

                background.Location = new Point(locationX, locationY);
                //background.Image = Resources.BrownTankWinner;
                background.SizeMode = PictureBoxSizeMode.StretchImage;
                background.BorderStyle = BorderStyle.Fixed3D;


                int newExitGameWidth = 130;
                int newExitGameHeight = 60;

                // NEW GAME
                int left = 180;
                int top = 393;

                newGamebtn.Size = new Size(newExitGameWidth, newExitGameHeight);
                newGamebtn.Location = new Point(left, top + 3);
                newGamebtn.Image = Resources.newGameBtn;
                newGamebtn.SizeMode = PictureBoxSizeMode.StretchImage;
                background.Controls.Add(newGamebtn);
                newGamebtn.BackColor = Color.Transparent;
                newGamebtn.Click += new EventHandler(newGamebtn_Click);
                newGamebtn.MouseEnter += new EventHandler(newGamebtn_MouseEnter);
                newGamebtn.MouseLeave += new EventHandler(newGamebtn_MouseLeave);

                //EXIT GAME

                exitGamebtn.Size = new Size(newExitGameWidth, newExitGameHeight - 3);
                exitGamebtn.Location = new Point(left + 200, top);
                exitGamebtn.Image = Resources.ExitBtn;
                exitGamebtn.SizeMode = PictureBoxSizeMode.StretchImage;
                background.Controls.Add(exitGamebtn);
                exitGamebtn.BackColor = Color.Transparent;
                exitGamebtn.Click += new EventHandler(exitGamebtn_Click);
                exitGamebtn.MouseEnter += new EventHandler(exitGamebtn_MouseEnter);
                exitGamebtn.MouseLeave += new EventHandler(exitGamebtn_MouseLeave);



                int ScoreX = left + 60;
                int ScoreY = top - 60;
                // LABEL SCORE

                score1.Text = "SCORE:";
                score1.BackColor = Color.Transparent;
                score1.Font = new Font("Microsoft Sans Serif", 12);
                score1.ForeColor = Color.White;
                score1.Location = new Point(ScoreX, ScoreY);
                score1.Size = new Size(70, 20);
                background.Controls.Add(score1);



                score2.Text = "SCORE:";
                score2.BackColor = Color.Transparent;
                score2.Font = new Font("Microsoft Sans Serif", 12);
                score2.ForeColor = Color.White;
                score2.Location = new Point(ScoreX + 110, ScoreY);
                score2.Size = new Size(70, 20);
                background.Controls.Add(score2);



                scoreFirstPlayer.Text = NewGame.Player1.Points.ToString();
                scoreFirstPlayer.BackColor = Color.Transparent;
                scoreFirstPlayer.Font = new Font("Microsoft Sans Serif", 12);
                scoreFirstPlayer.ForeColor = Color.White;
                background.Controls.Add(scoreFirstPlayer);
                scoreFirstPlayer.Location = new Point(ScoreX + 70, ScoreY);


                scoreSecondPlayer.Text = "Pts";
                scoreSecondPlayer.BackColor = Color.Transparent;
                scoreSecondPlayer.Font = new Font("Microsoft Sans Serif", 12);
                scoreSecondPlayer.ForeColor = Color.White;
                background.Controls.Add(scoreSecondPlayer);
                scoreSecondPlayer.Location = new Point(ScoreX + 110 + 70, ScoreY);

                if (NewGame.Player1.Points > NewGame.Player2.Points)
                {
                    //this.BackgroundImage = Resources.GreenTankWinner;
                    background.Image = Resources.GreenTankWinner;
                    scoreFirstPlayer.Text = NewGame.Player2.Points.ToString();
                    scoreSecondPlayer.Text = NewGame.Player1.Points.ToString();
                }
                else
                {
                    //this.BackgroundImage = Resources.BrownTankWinner;
                    background.Image = Resources.BrownTankWinner;
                    scoreSecondPlayer.Text = NewGame.Player2.Points.ToString();
                    scoreFirstPlayer.Text = NewGame.Player1.Points.ToString();
                }

                Controls.Add(background);
                //MainScene.updateScores(NewGame.Player1.Name, NewGame.Player2.Name, NewGame.Player1.Points, NewGame.Player2.Points);
            }

            //g.DrawEllipse(pen, new Rectangle(new Point(100, 100), new Size(200, 300)));
            NewGame.DrawScene(pen, g, this);

            foreach (Bullet bullet in Bullets)
            {
                bullet.Draw(g);
            }

            for (int i = Bullets.Count - 1; i >= 0; --i)
            {
                if (Bullets[i].BulletTime > 5000)
                {
                    Bullets.RemoveAt(i);
                }
            }
 
            pen.Dispose();
            
        }


        protected override bool IsInputKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Right:
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                    return true;
                case Keys.Shift | Keys.Right:
                case Keys.Shift | Keys.Left:
                case Keys.Shift | Keys.Up:
                case Keys.Shift | Keys.Down:
                    return true;
            }
            return base.IsInputKey(keyData);
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            switch (e.KeyCode)
            {
                case Keys.Left:
                case Keys.Right:
                case Keys.Up:
                case Keys.Down:
                    if (e.Shift)
                    {

                    }
                    else
                    {
                    }
                    break;
            }

            if (e.KeyCode == Keys.Up)
                forwardPlayer1 = true;
            if (e.KeyCode == Keys.Right)
                rightRotatePlayer1 = true;
            if (e.KeyCode == Keys.Down)
                backwardPlayer1 = true;
            if (e.KeyCode == Keys.Left)
                leftRotatePlayer1 = true;
            if (e.KeyCode == Keys.E)
                forwardPlayer2 = true;
            if (e.KeyCode == Keys.D)
                backwardPlayer2 = true;
            if (e.KeyCode == Keys.S)
                leftRotatePlayer2 = true;
            if (e.KeyCode == Keys.F)
                rightRotatePlayer2 = true;

        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            //
            // This event handler is raised every time
            // some key on the keyboard is released
            //

            base.OnKeyUp(e);

            //
            // Set corresponding key down flag state to false
            //

            if (e.KeyCode == Keys.Up)
                forwardPlayer1 = false;
            if (e.KeyCode == Keys.Right)
                rightRotatePlayer1 = false;
            if (e.KeyCode == Keys.Down)
                backwardPlayer1 = false;
            if (e.KeyCode == Keys.Left)
                leftRotatePlayer1 = false;
            if (e.KeyCode == Keys.E)
                forwardPlayer2 = false;
            if (e.KeyCode == Keys.D)
                backwardPlayer2 = false;
            if (e.KeyCode == Keys.S)
                leftRotatePlayer2 = false;
            if (e.KeyCode == Keys.F)
                rightRotatePlayer2 = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SceneForm_Load(object sender, EventArgs e)
        {

        }

        private void SceneForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)
            {
                if (!MClicked)
                {
                    Bullets.Add(NewGame.Player1.Tank.Fire());
                    MClicked = true;
                }
            }
            if (e.KeyCode == Keys.Q)
            {
                if (!QClicked)
                {
                    Bullets.Add(NewGame.Player2.Tank.Fire());
                    QClicked = true;
                }
            }
        }

        private void Movement(Scene scene)
        {
            // label1.Text = !NewGame.Player1.IsPlayerBurned + " " + !NewGame.Player2.IsPlayerBurned;
            if (!NewGame.Player1.IsPlayerBurned)
            {
                NewGame.Player1.Tank.Move(forwardPlayer1, backwardPlayer1, leftRotatePlayer1, rightRotatePlayer1, NewGame.ActualScene.Walls);
            }
            else
            {
                if (!nextGame)
                {
                    NewGame.Player2.Points++;
                    Bullets.Clear();
                    nextGame = true;
                }
            }
            if (!NewGame.Player2.IsPlayerBurned)
            {
                NewGame.Player2.Tank.Move(forwardPlayer2, backwardPlayer2, leftRotatePlayer2, rightRotatePlayer2, NewGame.ActualScene.Walls);
            }
            else
            {
                if (!nextGame)
                {
                    NewGame.Player1.Points++;
                    Bullets.Clear();
                    nextGame = true;
                }
            }
            
            foreach (Bullet bullet in Bullets)
            {
                bullet.Move(scene);
            }
            Invalidate();
        }

        private void SceneForm_Load_1(object sender, EventArgs e)
        {
            backgroundWidth = 700;
            backgroundHeight = 500;



            fixedLocationX = (this.Width - backgroundWidth) / 2;
            fixedLocationY = (this.Height - backgroundHeight) / 2;

            locationX = fixedLocationX;
            locationY = fixedLocationY;

            background = new PictureBox();
            newGamebtn = new PictureBox();
            exitGamebtn = new PictureBox();
            score1 = new Label();
            score2 = new Label();
            scoreFirstPlayer = new Label();
            scoreSecondPlayer = new Label();

            //label1.Text = Width + " " + Height + "\n" +
            //    locationX + " " + locationY + "\n" +
            //    fixedLocationX + " " + fixedLocationX + "\n";

            Clock2 = new Timer();
            Clock2.Interval = 1;
            Clock2.Tick += new EventHandler(Clock2_Tick);
            //Clock2.Start();
        }

        private void Clock2_Tick(object sender, EventArgs e)
        {
            if (locationY < fixedLocationY)
            {
                Clock2.Stop();
            }
            else
            {
                locationY -= 20;
            }
            Invalidate(true);
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

        private void exitGamebtn_MouseEnter(object sender, EventArgs e)
        {
            exitGamebtn.SizeMode = PictureBoxSizeMode.StretchImage;
            exitGamebtn.Cursor = Cursors.Hand;
        }

        private void exitGamebtn_MouseLeave(object sender, EventArgs e)
        {
            exitGamebtn.SizeMode = PictureBoxSizeMode.Zoom;
            exitGamebtn.Cursor = Cursors.Default;
        }

        public void checkWinner()
        {
            
        }

        private void newGamebtn_Click(object sender, EventArgs e)
        {
            StartTheGame(NewGame.Player1.Name, NewGame.Player2.Name);
            Invalidate();
        }

        private void exitGamebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
