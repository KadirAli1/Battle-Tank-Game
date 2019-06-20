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
        public List<Bullet> Bullets { get; set; }
        public SceneForm()
        {
            InitializeComponent();
            //FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized;
            //label1.Text = this.Width + " " + this.Height;
            this.WindowState = FormWindowState.Maximized;
            NewGame = new NewGame(this.Width, this.Height);
            Bullets = new List<Bullet>();
            DoubleBuffered = true;
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

            //
            // Call Main_Function()
            //
            Movement();

            //
            //
            //
        }

        private void SceneForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Color color = NewGame.ActualScene.BackgroundColor;
            g.Clear(color);
            Pen pen = new Pen(color, 1);

            NewGame.DrawScene(pen, g, this);

            foreach (Bullet bullet in Bullets)
            {
                bullet.Draw(g);
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
                Bullets.Add(NewGame.Player1.Tank.Fire());
            }
            if(e.KeyCode == Keys.Q)
            {
                Bullets.Add(NewGame.Player2.Tank.Fire());
            }
        }

        private void Movement()
        {
            NewGame.Player1.Tank.Move(forwardPlayer1, backwardPlayer1, leftRotatePlayer1, rightRotatePlayer1);
            NewGame.Player2.Tank.Move(forwardPlayer2, backwardPlayer2, leftRotatePlayer2, rightRotatePlayer2);
            foreach (Bullet bullet in Bullets)
            {
                bullet.Move();
            }
            Invalidate();
        }
    }
}
