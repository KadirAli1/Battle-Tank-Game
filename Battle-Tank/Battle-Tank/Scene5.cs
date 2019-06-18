using Battle_Tank.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Tank
{
    class Scene5 : Scene
    {
        public Scene5(int Width, int Height)
            : base(6, 10, 90, 90, Width, Height, Color.FromArgb(232, 240, 240))
        {
            for (int i = 0; i < 10; ++i)
            {
                Walls.Add(new Wall(new Rectangle((i * ColumnWidth) + Scene.LEFT, Scene.TOP, ColumnWidth, 6), Resources.Scene5_HorizontalWall));
            }

            // BOTTOM
            for (int i = 0; i < 10; ++i)
            {
                Walls.Add(new Wall(new Rectangle(i * ColumnWidth + Scene.LEFT, Rows * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene5_HorizontalWall));
            }

            // LEFT
            for (int i = 0; i < 6; ++i)
            {
                Walls.Add(new Wall(new Rectangle(Scene.LEFT, i * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene5_VerticalWall));
            }

            // RIGHT
            for (int i = 0; i < 6; ++i)
            {
                Walls.Add(new Wall(new Rectangle(Scene.LEFT + Columns * ColumnWidth, i * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene5_VerticalWall));
            }


            // ADDING LINES INSIDE
            // FIRST COLUMN
            // HORIZONTAL

            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * ColumnWidth, 2 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene5_VerticalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * ColumnWidth, 5 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene5_VerticalWall));

            // SECOND COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * ColumnWidth, 1 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene5_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * ColumnWidth, 3 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene5_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * ColumnWidth, 4 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene5_HorizontalWall));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * ColumnWidth, 5 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene5_VerticalWall));

            // THIRD COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * ColumnWidth, 1 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene5_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * ColumnWidth, 5 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene5_HorizontalWall));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 0 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene5_VerticalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 1 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene5_VerticalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 4 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene5_VerticalWall));


            // FOURTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 5 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene5_HorizontalWall));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 4 * ColumnWidth, 1 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene5_VerticalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 4 * ColumnWidth, 4 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene5_VerticalWall));

            // FIFTH COLUMN
            // HORIZONTAL
           
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 5 * ColumnWidth, 3 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene5_VerticalWall));

            
            // SIXTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 5 * ColumnWidth, 1 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene5_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 5 * ColumnWidth, 2 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene5_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 5 * ColumnWidth, 4 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene5_HorizontalWall));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 6 * ColumnWidth, 1 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene5_VerticalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 6 * ColumnWidth, 2 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene5_VerticalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 6 * ColumnWidth, 4 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene5_VerticalWall));


            // SEVENTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 6 * ColumnWidth, 5 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene5_HorizontalWall));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 7 * ColumnWidth, 1 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene5_VerticalWall));


            // EIGHTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 7 * ColumnWidth, 2 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene5_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 7 * ColumnWidth, 3 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene5_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 7 * ColumnWidth, 4 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene5_HorizontalWall));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 8 * ColumnWidth, 1 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene5_VerticalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 8 * ColumnWidth, 5 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene5_VerticalWall));


            // NINTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 8 * ColumnWidth, 1 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene5_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 8 * ColumnWidth, 3 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene5_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 8 * ColumnWidth, 4 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene5_HorizontalWall));
            // VERTICAL

            // TENTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 9 * ColumnWidth, 1 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene5_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 9 * ColumnWidth, 3 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene5_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 9 * ColumnWidth, 4 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene5_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 9 * ColumnWidth, 5 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene5_HorizontalWall));
            // VERTICAL
           

            // OUT OF SCENE DECOR
            // TOP
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 0 * 270, Scene.TOP - 17, 270, 17), Resources.Scene1_TopDecor));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * 270, Scene.TOP - 17, 270, 17), Resources.Scene1_TopDecor));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * 270, Scene.TOP - 17, 270, 17), Resources.Scene1_TopDecor));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * 270, Scene.TOP - 17, 90, 17), Resources.Scene1_TopDecor));

            // RIGHT
            int offset = 0;
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + Columns * ColumnWidth + 6, Scene.TOP + offset, 17, 270), Resources.Scene1_RightDecor));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + Columns * ColumnWidth + 6, Scene.TOP + 1 * 270 + offset, 17, 270), Resources.Scene1_RightDecor));

            // BOTTOM
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 0 * 270, Scene.TOP + Rows * RowHeight + 6, 270, 17), Resources.Scene1_BottomDecor));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * 270, Scene.TOP + Rows * RowHeight + 6, 270, 17), Resources.Scene1_BottomDecor));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * 270, Scene.TOP + Rows * RowHeight + 6, 270, 17), Resources.Scene1_BottomDecor));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * 270, Scene.TOP + Rows * RowHeight + 6, 90, 17), Resources.Scene1_BottomDecor));

            // LEFT
            Walls.Add(new Wall(new Rectangle(Scene.LEFT - 17, Scene.TOP + offset, 17, 270), Resources.Scene1_LeftDecor));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT - 17, Scene.TOP + 1 * 270 + offset, 17, 270), Resources.Scene1_LeftDecor));
        }
    }
}
