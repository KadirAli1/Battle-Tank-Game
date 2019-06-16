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
        public int RowHeight { get; set; }
        public int ColumnWidth{ get; set; }

        public static int TOP;
        public static int LEFT;
        
        public int Columns { get; set; }
        public int Rows { get; set; }
        //public int Width { get; set; }
        //public int Height { get; set; }
        public List<Wall> Walls { get; set; }

        public Color BackgroundColor { get; set; }
        public Scene(int Rows, int Columns, int RowHeight, int ColumnWidth, int Width, int Height, Color Color)
        {
            Walls = new List<Wall>();
            this.Columns = Columns;
            this.Rows = Rows;
            this.RowHeight = RowHeight;
            this.ColumnWidth = ColumnWidth;
            TOP = 30;
            LEFT = (Width - (Columns) * ColumnWidth) /2;
            BackgroundColor = Color;
        }

        public void Draw(Pen pen, Graphics g)
        {
            Brush brush = new SolidBrush(BackgroundColor);
            g.FillRectangle(brush, LEFT, TOP, Columns * ColumnWidth, Rows * RowHeight);

            foreach(Wall line in Walls)
            {
                line.Draw(pen, g);
            }
        }
    }
}
