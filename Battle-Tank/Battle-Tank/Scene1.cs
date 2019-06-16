using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Tank
{
    public class Scene1 : Scene
    {
        //int Rows = 7;
        //int Columns = 10;
        //int ColumnWidth = 90;
        //int RowHeight = 80;

        public Scene1(int Width, int Height) 
            : base(7, 10, 80, 90, Width, Height, Color.FromArgb(232, 240, 240))
        {
            for (int i = 0; i < 10; ++i)
            {
                Walls.Add(new Wall(new Rectangle((i * ColumnWidth) + Scene.LEFT, Scene.TOP, ColumnWidth, 6), Wall.Direction.Horizontal));
            }

            // BOTTOM
            for (int i = 0; i < 10; ++i)
            {
                Walls.Add(new Wall(new Rectangle(i * ColumnWidth + Scene.LEFT, Rows * RowHeight + Scene.TOP, ColumnWidth, 6), Wall.Direction.Horizontal));
            }

            // LEFT
            for (int i = 0; i < 7; ++i)
            {
                Walls.Add(new Wall(new Rectangle(Scene.LEFT, i * RowHeight + Scene.TOP, 6, RowHeight), Wall.Direction.Vertical));
            }

            // RIGHT
            for (int i = 0; i < 7; ++i)
            {
                Walls.Add(new Wall(new Rectangle(Scene.LEFT + Columns * ColumnWidth, i * RowHeight + Scene.TOP, 6, RowHeight), Wall.Direction.Vertical));
            }


            // ADDING LINES INSIDE
            // FIRST COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 0 * ColumnWidth, 5 * RowHeight + Scene.TOP, ColumnWidth, 6), Wall.Direction.Horizontal));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * ColumnWidth, 5 * RowHeight + Scene.TOP, 6, RowHeight), Wall.Direction.Vertical));

            // SECOND COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * ColumnWidth, 2 * RowHeight + Scene.TOP, ColumnWidth, 6), Wall.Direction.Horizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * ColumnWidth, 3 * RowHeight + Scene.TOP, ColumnWidth, 6), Wall.Direction.Horizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * ColumnWidth, 4 * RowHeight + Scene.TOP, ColumnWidth, 6), Wall.Direction.Horizontal));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * ColumnWidth, 0 * RowHeight + Scene.TOP, 6, RowHeight), Wall.Direction.Vertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * ColumnWidth, 6 * RowHeight + Scene.TOP, 6, RowHeight), Wall.Direction.Vertical));

            // THIRD COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * ColumnWidth, 3 * RowHeight + Scene.TOP, ColumnWidth, 6), Wall.Direction.Horizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * ColumnWidth, 4 * RowHeight + Scene.TOP, ColumnWidth, 6), Wall.Direction.Horizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * ColumnWidth, 5 * RowHeight + Scene.TOP, ColumnWidth, 6), Wall.Direction.Horizontal));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 1 * RowHeight + Scene.TOP, 6, RowHeight), Wall.Direction.Vertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 2 * RowHeight + Scene.TOP, 6, RowHeight), Wall.Direction.Vertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 5 * RowHeight + Scene.TOP, 6, RowHeight), Wall.Direction.Vertical));

            // FOURTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 2 * RowHeight + Scene.TOP, ColumnWidth, 6), Wall.Direction.Horizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 3 * RowHeight + Scene.TOP, ColumnWidth, 6), Wall.Direction.Horizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 4 * RowHeight + Scene.TOP, ColumnWidth, 6), Wall.Direction.Horizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 5 * RowHeight + Scene.TOP, ColumnWidth, 6), Wall.Direction.Horizontal));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 4 * ColumnWidth, 1 * RowHeight + Scene.TOP, 6, RowHeight), Wall.Direction.Vertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 4 * ColumnWidth, 3 * RowHeight + Scene.TOP, 6, RowHeight), Wall.Direction.Vertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 4 * ColumnWidth, 4 * RowHeight + Scene.TOP, 6, RowHeight), Wall.Direction.Vertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 4 * ColumnWidth, 6 * RowHeight + Scene.TOP, 6, RowHeight), Wall.Direction.Vertical));

            // FIFTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 4 * ColumnWidth, 2 * RowHeight + Scene.TOP, ColumnWidth, 6), Wall.Direction.Horizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 4 * ColumnWidth, 6 * RowHeight + Scene.TOP, ColumnWidth, 6), Wall.Direction.Horizontal));

            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 5 * ColumnWidth, 0 * RowHeight + Scene.TOP, 6, RowHeight), Wall.Direction.Vertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 5 * ColumnWidth, 5 * RowHeight + Scene.TOP, 6, RowHeight), Wall.Direction.Vertical));

            // SIXTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 5 * ColumnWidth, 1 * RowHeight + Scene.TOP, ColumnWidth, 6), Wall.Direction.Horizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 5 * ColumnWidth, 2 * RowHeight + Scene.TOP, ColumnWidth, 6), Wall.Direction.Horizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 5 * ColumnWidth, 3 * RowHeight + Scene.TOP, ColumnWidth, 6), Wall.Direction.Horizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 5 * ColumnWidth, 4 * RowHeight + Scene.TOP, ColumnWidth, 6), Wall.Direction.Horizontal));

            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 6 * ColumnWidth, 1 * RowHeight + Scene.TOP, 6, RowHeight), Wall.Direction.Vertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 6 * ColumnWidth, 2 * RowHeight + Scene.TOP, 6, RowHeight), Wall.Direction.Vertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 6 * ColumnWidth, 4 * RowHeight + Scene.TOP, 6, RowHeight), Wall.Direction.Vertical));

            // SEVENTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 6 * ColumnWidth, 6 * RowHeight + Scene.TOP, ColumnWidth, 6), Wall.Direction.Horizontal));

            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 7 * ColumnWidth, 2 * RowHeight + Scene.TOP, 6, RowHeight), Wall.Direction.Vertical));

            // EIGHTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 7 * ColumnWidth, 4 * RowHeight + Scene.TOP, ColumnWidth, 6), Wall.Direction.Horizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 7 * ColumnWidth, 5 * RowHeight + Scene.TOP, ColumnWidth, 6), Wall.Direction.Horizontal));

            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 8 * ColumnWidth, 5 * RowHeight + Scene.TOP, 6, RowHeight), Wall.Direction.Vertical));

            // NINTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 8 * ColumnWidth, 1 * RowHeight + Scene.TOP, ColumnWidth, 6), Wall.Direction.Horizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 8 * ColumnWidth, 3 * RowHeight + Scene.TOP, ColumnWidth, 6), Wall.Direction.Horizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 8 * ColumnWidth, 5 * RowHeight + Scene.TOP, ColumnWidth, 6), Wall.Direction.Horizontal));

            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 9 * ColumnWidth, 4 * RowHeight + Scene.TOP, 6, RowHeight), Wall.Direction.Vertical));

            // TENTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 9 * ColumnWidth, 2 * RowHeight + Scene.TOP, ColumnWidth, 6), Wall.Direction.Horizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 9 * ColumnWidth, 5 * RowHeight + Scene.TOP, ColumnWidth, 6), Wall.Direction.Horizontal));


            // OUT OF SCENE DECOR
            // TOP
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 0 * 270, Scene.TOP - 17, 270, 17), Wall.Direction.DecorTop));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * 270, Scene.TOP - 17, 270, 17), Wall.Direction.DecorTop));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * 270, Scene.TOP - 17, 270, 17), Wall.Direction.DecorTop));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * 270, Scene.TOP - 17, 90, 17), Wall.Direction.DecorTop));

            // RIGHT
            int offset = 10;
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 10 * ColumnWidth + 6, Scene.TOP + offset, 17, 270), Wall.Direction.DecorRight));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 10 * ColumnWidth + 6, Scene.TOP + 1 * 270 + offset, 17, 270), Wall.Direction.DecorRight));

            // BOTTOM
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 0 * 270, Scene.TOP + 7 * RowHeight, 270, 17), Wall.Direction.DecorBottom));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * 270, Scene.TOP + 7 * RowHeight, 270, 17), Wall.Direction.DecorBottom));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * 270, Scene.TOP + 7 * RowHeight, 270, 17), Wall.Direction.DecorBottom));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * 270, Scene.TOP + 7 * RowHeight, 90, 17), Wall.Direction.DecorBottom));

            // LEFT
            Walls.Add(new Wall(new Rectangle(Scene.LEFT - 17, Scene.TOP + offset, 17, 270), Wall.Direction.DecorLeft));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT - 17, Scene.TOP + 1 * 270 + offset, 17, 270), Wall.Direction.DecorLeft));
        }
    }
}
