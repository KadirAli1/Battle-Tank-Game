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
            Horizontal,
            DecorTop,
            DecorRight,
            DecorBottom,
            DecorLeft
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
            if (Dir == Direction.Vertical)
            {
                g.DrawRectangle(pen, Rectangle);

                g.DrawImage(Resources.Scene1_VerticalWall, Rectangle);

            }
            else if (Dir == Direction.Horizontal)
            {
                g.DrawRectangle(pen, Rectangle);
                
                g.DrawImage(Resources.Scene1_HorizontalWall, Rectangle);
            }
            else if (Dir == Direction.DecorTop)
            {
                g.DrawImage(Resources.Scene1_TopDecor, Rectangle);
            }
            else if (Dir == Direction.DecorRight)
            {
                g.DrawImage(Resources.Scene1_RightDecor, Rectangle);
            }
            else if (Dir == Direction.DecorBottom)
            {
                g.DrawImage(Resources.Scene1_BottomDecor, Rectangle);
            }
            else if (Dir == Direction.DecorLeft) 
            {
                g.DrawImage(Resources.Scene1_LeftDecor, Rectangle);
            }
            
        }
    }
}
