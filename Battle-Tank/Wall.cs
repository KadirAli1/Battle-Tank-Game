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
        public Rectangle Rectangle { get; set; }
        public Image Image { get; set; }
        public Wall(Rectangle Rectangle, Image Image)
        {

            this.Rectangle = Rectangle;
            this.Image = Image;
        }

        public void Draw(Pen pen, Graphics g)
        {
            g.DrawRectangle(pen, Rectangle);
            g.DrawImage(Image, Rectangle);
        }
    }
}
