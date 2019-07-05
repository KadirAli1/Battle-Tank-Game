using Battle_Tank.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battle_Tank
{
    public class TankDimensions
    {
        public static readonly int Width = 40;
        public static readonly int Height = 30;

        public static readonly int Width2 = 10;
        public static readonly int Height2 = 6;
    }

    public class Tank
    {
        public float X { get; set; }
        public float Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public PointF Center { get; set; }
        public float Angle { get; set; }
        public double Dx { get; set; }
        public double Dy { get; set; }
        public Color Color { get; set; }
        public int SpeedMoving { get; set; }
        public int SpeedRotating { get; set; }
        public Image Image { get; set; }
        public Rectangle TankRectangle { get; set; }
        public float Xmin { get; set; }
        public float Xmax { get; set; }
        public float Ymin { get; set; }
        public float Ymax { get; set; }
        public bool IsTankBurned;
        public enum Position
        {
            LeftToRight,
            RightToLeft
        }

        public Tank(int X, int Y, float Angle, Position Position)
        {
            this.X = X;
            this.Y = Y;
            Width = TankDimensions.Width;
            Height = TankDimensions.Height;
            Center = new PointF(X + Width / 2.0F, Y + Height / 2.0F);
            this.Angle = Angle;
            SpeedMoving = 3;
            SpeedRotating = 3;
            this.Color = Color;

            if (Position == Position.LeftToRight)
            {
                Image = Resources.GreenTank;
            }
            else
            {
                Image = Resources.BrownTank;
            }
            
            
            TankRectangle = new Rectangle(new Point(X, Y), new Size(Width, Height));
            IsTankBurned = false;
            calculateDxDy();
        }

        private void calculateDxDy()
        {
            double radians = Angle * Math.PI / 180;
            Dx =   Math.Cos(radians) * SpeedMoving;
            Dy =   Math.Sin(radians) * SpeedMoving;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color.Black);

            using (Matrix m = new Matrix())
            {
                m.RotateAt(Angle, new PointF(X + (TankDimensions.Width / 2), Y + (TankDimensions.Height / 2)));
                g.Transform = m;
                g.DrawImage(Image, X, Y, TankDimensions.Width, TankDimensions.Height);
                //g.DrawString(string.Format("{0},{1},{3}", X, Y, IsCollidingWithBullet()), new Font("Arial", 10), brush, X - 20, Y - 20);
                g.ResetTransform();
            }
            brush.Dispose();

            IsCollidingWithBullet();
        }

        public void Move(bool forward, bool backward, bool leftRotate, bool rightRotate, List<Wall> Walls)
        {
            
            if (leftRotate)
            {
                Angle -= SpeedRotating;
                if (Angle < 0.0F)
                {
                    Angle = 360.0F;
                }
            }
            if (rightRotate)
            {
                Angle += SpeedRotating;
                if (Angle > 360.0F)
                {
                    Angle = 0.0F;
                }
            }
            calculateDxDy();


            if (forward)
            {
                //////////////////////////////////
                int RADIUS = Width / 2 + 4;
                float nextX = Center.X + (float)Dx;
                float nextY = Center.Y + (float)Dy;
                bool collided = false;
                foreach (Wall wall in Walls)
                {
                    int lft = wall.Rectangle.Left;
                    int rgt = wall.Rectangle.Right;
                    int tp = wall.Rectangle.Top;
                    int btm = wall.Rectangle.Bottom;

                    
                    // FROM THE LEFT
                    if (nextX + RADIUS > lft && nextX + RADIUS < rgt && nextY > tp && nextY < btm)
                    {
                        //collided = true;
                        //break;
                        nextX -= nextX + RADIUS - lft;
                    }
                    // FROM THE RIGHT
                    if (nextX - RADIUS > lft && nextX - RADIUS < rgt && nextY > tp && nextY < btm)
                    {
                        //collided = true;
                        //break;
                        nextX += rgt - (nextX - RADIUS);
                    }
                    // FROM THE TOP
                    if (nextY + RADIUS > tp && nextY + RADIUS < btm && nextX > lft && nextX < rgt)
                    {
                        //collided = true;
                        //break;
                        nextY -= nextY + RADIUS - tp;
                    }
                    // FROM THE BOTTOM
                    if (nextY - RADIUS > tp && nextY - RADIUS < btm && nextX > lft && nextX < rgt)
                    {
                        //collided = true;
                        //break;
                        nextY += btm - (nextY - RADIUS);
                    }
                }
                if (!collided)
                    Center = new PointF(nextX, nextY);
                else
                {
                    Center = new PointF(nextX - (float)Dx, nextY - (float)Dy);
                }
                /////////////////////////////////////////
                X = Center.X - Width / 2;
                Y = Center.Y - Height / 2;
            }
            if (backward)
            {
                int RADIUS = Width / 2 + 4;
                float nextX = Center.X - (float)Dx;
                float nextY = Center.Y - (float)Dy;
                bool collided = false;
                foreach (Wall wall in Walls)
                {
                    int lft = wall.Rectangle.Left;
                    int rgt = wall.Rectangle.Right;
                    int tp = wall.Rectangle.Top;
                    int btm = wall.Rectangle.Bottom;

                    // FROM THE LEFT
                    if (nextX + RADIUS > lft && nextX + RADIUS < rgt && nextY > tp && nextY < btm)
                    {
                        //collided = true;
                        //break;
                        nextX -= nextX + RADIUS - lft;
                    }
                    // FROM THE RIGHT
                    if (nextX - RADIUS > lft && nextX - RADIUS < rgt && nextY > tp && nextY < btm)
                    {
                        //collided = true;
                        //break;
                        nextX += rgt - (nextX - RADIUS);
                    }
                    // FROM THE TOP
                    if (nextY + RADIUS > tp && nextY + RADIUS < btm && nextX > lft && nextX < rgt)
                    {
                        //collided = true;
                        //break;
                        nextY -= nextY + RADIUS - tp;
                    }
                    // FROM THE BOTTOM
                    if (nextY - RADIUS > tp && nextY - RADIUS < btm && nextX > lft && nextX < rgt)
                    {
                        //collided = true;
                        //break;
                        nextY += btm - (nextY - RADIUS);
                    }
                }
                if (!collided)
                    Center = new PointF(nextX, nextY);
                else
                {
                    Center = new PointF(nextX + (float)Dx, nextY + (float)Dy);
                }
                /////////////////////////////////////////
                X = Center.X - Width / 2;
                Y = Center.Y - Height / 2;
            }
        }

        public void IsCollidingWithWalls()
        {

        }

        public Bullet Fire()
        {
            double radians = Angle * Math.PI / 180;

            float xTemp = X + Width / 2;
            float yTemp = Y + Height / 2 - 2;

            Bullet bullet = new Bullet(xTemp, yTemp, radians);
            return bullet;
        }

        public void IsCollidingWithBullet()
        {
            if (!IsTankBurned)
            {
                foreach (Bullet bullet in SceneForm.Bullets)
                {
                    if (bullet.BeginningTime > 5)
                    {
                        if (bullet.Center.X > X && bullet.Center.X < X + Width
                            && bullet.Center.Y > Y && bullet.Center.Y < Y + Height)
                        {
                            Image = Resources.Tank_Burned;
                            IsTankBurned = true;
                        }
                    }
                }
            }
        }
    }
}
