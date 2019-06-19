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

            Speed = 1;
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

        public void Move()
        {
            X += Dx;
            Y += Dy;
        }
    }
}
