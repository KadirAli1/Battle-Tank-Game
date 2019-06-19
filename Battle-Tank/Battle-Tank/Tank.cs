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
        public float Angle { get; set; }
        public double Dx { get; set; }
        public double Dy { get; set; }
        public Color Color { get; set; }
        public int SpeedMoving { get; set; }
        public int SpeedRotating { get; set; }
        public Image Image { get; set; }

        public Tank(int X, int Y, float Angle, Color Color)
        {
            this.X = X;
            this.Y = Y;
            Width = TankDimensions.Width;
            Height = TankDimensions.Height;
            this.Angle = Angle;
            SpeedMoving = 3;
            SpeedRotating = 2;
            this.Color = Color;
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
            Brush brush = new SolidBrush(this.Color);

            //g.TranslateTransform(X, Y);
            //g.RotateTransform(Angle);

            using (Matrix m = new Matrix())
            {
                m.RotateAt(Angle, new PointF(X + (TankDimensions.Width / 2),
                                          Y + (TankDimensions.Height / 2)));
                g.Transform = m;
                g.FillRectangle(brush, X, Y, TankDimensions.Width, TankDimensions.Height);
                g.FillRectangle(brush, X + TankDimensions.Width, Y + (TankDimensions.Height - TankDimensions.Height2) / 2, TankDimensions.Width2, TankDimensions.Height2);
                //g.FillEllipse(brush, X + TankDimensions.Width + TankDimensions.Width2, Y + (TankDimensions.Height - TankDimensions.Height2) / 2, TankDimensions.Height2, TankDimensions.Height2);
                g.ResetTransform();
            }
            //g.FillRectangle(brush, X, Y, Width, Height);
            //    g.FillRectangle(brush, X + Width, Y + (Height - 5) / 2, 10, 5);

            brush.Dispose();
        }

        public void Move(bool forward, bool backward, bool leftRotate, bool rightRotate)
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
                X += (float) Dx;
                Y += (float) Dy;
            }
            if (backward)
            {
                X -= (float) Dx;
                Y -= (float) Dy;
            }
        }

        public Bullet Fire(Label label)
        {
            double radians = Angle * Math.PI / 180;
            
            float xTemp = X + (float) Math.Cos(radians) * (TankDimensions.Width + TankDimensions.Width2);
            float yTemp = Y + (float) Math.Sin(radians) * (TankDimensions.Width + TankDimensions.Width2);

            label.Text = X + ", " + Y + "\n" +
                xTemp + ", " + yTemp + "\n"
                ;
            Bullet bullet = new Bullet(xTemp, yTemp, radians);
            return bullet;
        }
    }
}
