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
        public Point Center { get; set; }
        public double Angle { get; set; }
        public float Dx { get; set; }
        public float Dy { get; set; }
        public int Speed { get; set; }
        public Color Color { get; set; }
        public Matrix Matrix { get; set; }

        public Bullet(float X, float Y, double Angle)
        {
            this.X = X;
            this.Y = Y;
            this.Angle = Angle;
            this.Center = new Point((int)(X + Radius), (int)(Y + Radius));
            Speed = 4;
            Dx = (float)Math.Cos(Angle) * Speed;
            Dy = (float)Math.Sin(Angle) * Speed;

            this.Color = Color.Black;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);

            g.FillEllipse(brush, X + TankDimensions.Width + TankDimensions.Width2, Y + (TankDimensions.Height - TankDimensions.Height2) / 2, 
                TankDimensions.Height2, TankDimensions.Height2);

            brush.Dispose();
        }

        public void Move(Scene scene)
        {
            X += Dx;
            Y += Dy;
            scene.LabelPlayer1Name.Text = "HEYY";
            //SceneForm.Invalidate();
            isColiding(scene);
        }

        public void isColiding(Scene scene)
        {
            List<Wall> walls = scene.Walls;

            scene.LabelPlayer1Name.Text = "HEYY";

            foreach (Wall wall in walls)
            {
                int top = wall.Rectangle.Top;
                int bottom = wall.Rectangle.Bottom;
                int left = wall.Rectangle.Left;
                int right = wall.Rectangle.Right;

                int cX = Center.X;
                int cY = Center.Y;

                if(cY - Radius < bottom && cY - Radius > top && cX < right && cX > left)
                {
                    Dy *= -1;
                }
                else if(cY + Radius < bottom && cY + Radius > top && cX < right && cX > left)
                {
                    Dy *= -1;
                }
            }
        }
        

        
    }
}
