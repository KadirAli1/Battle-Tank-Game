using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Tank
{
    public class Line
    {
        public Point First { get; set; }
        public Point Second { get; set; }

        public Line(Point First, Point Second)
        {
            this.First = First;
            this.Second = Second;
        }

        public void Draw(Pen pen, Graphics g)
        {
            g.DrawLine(pen, First, Second);
        }
    }
}
