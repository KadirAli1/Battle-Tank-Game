using Battle_Tank.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Tank
{
    public class Bullet
    {
        public readonly float Radius = TankDimensions.Height2/2.0F;
        public float X { get; set; }
        public float Y { get; set; }
        public PointF Center { get; set; }
        public double Angle { get; set; }
        public float Dx { get; set; }
        public float Dy { get; set; }
        public int Speed { get; set; }
        public Color Color { get; set; }
        public Matrix Matrix { get; set; }
        public int BulletTime { get; set; }
        public int BeginningTime { get; set; }
        public Bullet(float X, float Y, double Angle)
        {
            this.X = X;
            this.Y = Y;
            this.Angle = Angle;
            this.Center = new PointF(X + Radius, Y + Radius);
            Speed = 5;
            Dx = (float)Math.Cos(Angle) * Speed;
            Dy = (float)Math.Sin(Angle) * Speed;
            BulletTime = 0;
            BeginningTime = 0;
            this.Color = Color.Black;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, X, Y,
                TankDimensions.Height2, TankDimensions.Height2);
            //g.DrawString(string.Format("{0},{1}", Center.X, Center.Y), new Font("Arial", 12), brush, X, Y+20);
            
            brush.Dispose();
        }

        public void Move(Scene scene)
        {
            X += Dx;
            Y += Dy;
            Center = new PointF(X + Radius, Y + Radius);
            //scene.LabelPlayer1Name.Text = "HEYY";
            //SceneForm.Invalidate();
            isColidingWithWalls(scene);
            BulletTime += 15;
            BeginningTime++;
        }

        public void isColidingWithWalls(Scene scene)
        {
            List<Wall> walls = scene.Walls;

            foreach (Wall wall in walls)
            {
                int top = wall.Rectangle.Top;
                int bottom = wall.Rectangle.Bottom;
                int left = wall.Rectangle.Left;
                int right = wall.Rectangle.Right;

                float cX = Center.X;
                float cY = Center.Y;

                if (cY - Radius < bottom && cY - Radius > top && cX < right && cX > left)
                {
                    BeginningTime += 10;
                    Dy *= -1;
                  
                }
                if (cY + Radius < bottom && cY + Radius > top && cX < right && cX > left)
                {
                    BeginningTime += 10;
                    Dy *= -1;
                   
                }
                if(cX - Radius < right && cX - Radius > left && cY > top && cY < bottom)
                {
                    BeginningTime += 10;
                    Dx *= -1;
                  
                }
                if (cX + Radius > left && cX + Radius < right && cY > top && cY < bottom)
                {
                    BeginningTime += 10;
                    Dx *= -1;
                }

            }
        }

        public void isColidingWithTank()
        {
            
        }
    }
}
