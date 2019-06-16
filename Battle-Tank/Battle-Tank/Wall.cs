using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Battle_Tank.Properties;

namespace Battle_Tank
{
    public class Wall
    {
        public enum Direction{
            Vertical,
            Horizontal
        };
        public Rectangle Rectangle { get; set; }
        public Direction Dir { get; set; }
        public Wall(Rectangle Rectangle, Direction Dir)
        {

            this.Rectangle = Rectangle;
            this.Dir = Dir;
        }

        public void Draw(Pen pen, Graphics g)
        {
            if(Dir == Direction.Vertical)
            {
                g.DrawRectangle(pen, Rectangle);

                g.DrawImage(Resources.VerticalWall, Rectangle);
                
            }
            else
            {
                g.DrawRectangle(pen, Rectangle);

                g.DrawImage(Resources.HorizontalWall, Rectangle);
            }
            //g.DrawImage(Resources.Muri, First);
        }
    }
}
