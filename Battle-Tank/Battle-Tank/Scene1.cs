using Battle_Tank.Properties;
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
                Walls.Add(new Wall(new Rectangle((i * ColumnWidth) + Scene.LEFT, Scene.TOP, ColumnWidth, 6), Resources.Scene1_HorizontalWall));
            }

            // BOTTOM
            for (int i = 0; i < 10; ++i)
            {
                Walls.Add(new Wall(new Rectangle(i * ColumnWidth + Scene.LEFT, Rows * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene1_HorizontalWall));
            }

            // LEFT
            for (int i = 0; i < 7; ++i)
            {
                Walls.Add(new Wall(new Rectangle(Scene.LEFT, i * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene1_VerticalWall));
            }

            // RIGHT
            for (int i = 0; i < 7; ++i)
            {
                Walls.Add(new Wall(new Rectangle(Scene.LEFT + Columns * ColumnWidth, i * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene1_VerticalWall));
            }


            // ADDING LINES INSIDE
            // FIRST COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 0 * ColumnWidth, 5 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene1_HorizontalWall));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * ColumnWidth, 5 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene1_VerticalWall));

            // SECOND COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * ColumnWidth, 2 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene1_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * ColumnWidth, 3 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene1_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * ColumnWidth, 4 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene1_HorizontalWall));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * ColumnWidth, 0 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene1_VerticalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * ColumnWidth, 6 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene1_VerticalWall));

            // THIRD COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * ColumnWidth, 3 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene1_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * ColumnWidth, 4 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene1_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * ColumnWidth, 5 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene1_HorizontalWall));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 1 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene1_VerticalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 2 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene1_VerticalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 5 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene1_VerticalWall));

            // FOURTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 2 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene1_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 3 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene1_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 4 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene1_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 5 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene1_HorizontalWall));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 4 * ColumnWidth, 1 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene1_VerticalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 4 * ColumnWidth, 3 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene1_VerticalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 4 * ColumnWidth, 4 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene1_VerticalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 4 * ColumnWidth, 6 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene1_VerticalWall));

            // FIFTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 4 * ColumnWidth, 2 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene1_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 4 * ColumnWidth, 6 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene1_HorizontalWall));

            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 5 * ColumnWidth, 0 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene1_VerticalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 5 * ColumnWidth, 5 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene1_VerticalWall));

            // SIXTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 5 * ColumnWidth, 1 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene1_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 5 * ColumnWidth, 2 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene1_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 5 * ColumnWidth, 3 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene1_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 5 * ColumnWidth, 4 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene1_HorizontalWall));

            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 6 * ColumnWidth, 1 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene1_VerticalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 6 * ColumnWidth, 2 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene1_VerticalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 6 * ColumnWidth, 4 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene1_VerticalWall));

            // SEVENTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 6 * ColumnWidth, 6 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene1_HorizontalWall));

            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 7 * ColumnWidth, 2 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene1_VerticalWall));

            // EIGHTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 7 * ColumnWidth, 4 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene1_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 7 * ColumnWidth, 5 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene1_HorizontalWall));

            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 8 * ColumnWidth, 5 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene1_VerticalWall));

            // NINTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 8 * ColumnWidth, 1 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene1_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 8 * ColumnWidth, 3 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene1_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 8 * ColumnWidth, 5 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene1_HorizontalWall));

            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 9 * ColumnWidth, 4 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene1_VerticalWall));

            // TENTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 9 * ColumnWidth, 2 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene1_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 9 * ColumnWidth, 5 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene1_HorizontalWall));


            // OUT OF SCENE DECOR
            // TOP
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 0 * 270, Scene.TOP - 17, 270, 17), Resources.Scene1_TopDecor));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * 270, Scene.TOP - 17, 270, 17), Resources.Scene1_TopDecor));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * 270, Scene.TOP - 17, 270, 17), Resources.Scene1_TopDecor));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * 270, Scene.TOP - 17, 90, 17), Resources.Scene1_TopDecor));

            // RIGHT
            int offset = 10;
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 10 * ColumnWidth + 6, Scene.TOP + offset, 17, 270), Resources.Scene1_RightDecor));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 10 * ColumnWidth + 6, Scene.TOP + 1 * 270 + offset, 17, 270), Resources.Scene1_RightDecor));

            // BOTTOM
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 0 * 270, Scene.TOP + 7 * RowHeight + 6, 270, 17), Resources.Scene1_BottomDecor));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * 270, Scene.TOP + 7 * RowHeight + 6, 270, 17), Resources.Scene1_BottomDecor));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * 270, Scene.TOP + 7 * RowHeight + 6, 270, 17), Resources.Scene1_BottomDecor));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * 270, Scene.TOP + 7 * RowHeight + 6, 90, 17), Resources.Scene1_BottomDecor));

            // LEFT
            Walls.Add(new Wall(new Rectangle(Scene.LEFT - 17, Scene.TOP + offset, 17, 270), Resources.Scene1_LeftDecor));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT - 17, Scene.TOP + 1 * 270 + offset, 17, 270), Resources.Scene1_LeftDecor));
        }
    }
}
