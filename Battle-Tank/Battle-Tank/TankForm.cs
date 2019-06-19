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
    public partial class TankForm : Form
    {
        Timer Clock;
        const int Interval = 15;
        bool forward = false;
        bool backward = false;
        bool leftRotate = false;
        bool rightRotate = false;
        public Tank Tank { get; set; }
        public List<Bullet> Bullets { get; set; }
        public TankForm()
        {
            InitializeComponent();
            Tank = new Tank(20, 20, 0, Color.Red);
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

        private void TankForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            
            Tank.Draw(g);
            foreach(Bullet bullet in Bullets)
            {
                bullet.Draw(g);
            }

            label1.Text = "Angle = " + Tank.Angle + "\n" +
                "Dx = " + Tank.Dx + "Dy = " + Tank.Dy;
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
                forward = true;
            if (e.KeyCode == Keys.Right)
                rightRotate = true;
            if (e.KeyCode == Keys.Down)
                backward = true;
            if (e.KeyCode == Keys.Left)
                leftRotate = true;
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
                forward = false;
            if (e.KeyCode == Keys.Right)
                rightRotate = false;
            if (e.KeyCode == Keys.Down)
                backward = false;
            if (e.KeyCode == Keys.Left)
                leftRotate = false;
        }

        private void TankForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.M)
            {
                
                Bullets.Add(Tank.Fire(label2));
            }
        }

        private void Movement()
        {
            Tank.Move(forward, backward, leftRotate, rightRotate);
            foreach(Bullet bullet in Bullets)
            {
                bullet.Move();
            }
            Invalidate();
        }
    }
}
