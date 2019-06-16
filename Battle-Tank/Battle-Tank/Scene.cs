using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Tank
{
    public class Scene
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }
        public List<Line> Lines { get; set; }

        public Scene(int X, int Y, int Width, int Height)
        {
            Lines = new List<Line>();
            this.X = X;
            this.Y = Y;
            this.Width = Width;
            this.Height = Height;
        }

        public void Draw(Pen pen, Graphics g)
        {
            g.DrawRectangle(pen, X, Y, Width, Height);

            foreach(Line line in Lines)
            {
                line.Draw(pen, g);
            }
        }
    }
}
