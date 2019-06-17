using Battle_Tank.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Tank
{
    public class Scene2 : Scene
    {
        public Scene2(int Width, int Height)
            : base(5, 6, 90, 90, Width, Height, Color.FromArgb(232, 240, 240))
        {

            // TOP
            for (int i = 0; i < 6; ++i)
            {
                Walls.Add(new Wall(new Rectangle((i * ColumnWidth) + Scene.LEFT, Scene.TOP, ColumnWidth, 6), Resources.Scene2_InnerWallHorizontal));
            }

            // BOTTOM
            for (int i = 0; i < 6; ++i)
            {
                Walls.Add(new Wall(new Rectangle(i * ColumnWidth + Scene.LEFT, Rows * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene2_InnerWallHorizontal));
            }

            // LEFT
            for (int i = 0; i < 5; ++i)
            {
                Walls.Add(new Wall(new Rectangle(Scene.LEFT, i * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene2_InnerWallVertical));
            }

            // RIGHT
            for (int i = 0; i < 5; ++i)
            {
                Walls.Add(new Wall(new Rectangle(Scene.LEFT + Columns * ColumnWidth, i * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene2_InnerWallVertical));
            }


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // OUTER TOP
            for (int i = 0; i < 6; ++i)
            {
                Walls.Add(new Wall(new Rectangle((i * ColumnWidth) + Scene.LEFT, Scene.TOP - 12, ColumnWidth, 12), Resources.Scene2_OuterWallHorizontal));
            }

            // OUTER BOTTOM
            for (int i = 0; i < 6; ++i)
            {
                Walls.Add(new Wall(new Rectangle(i * ColumnWidth + Scene.LEFT, Rows * RowHeight + Scene.TOP + 6, ColumnWidth, 12), Resources.Scene2_OuterWallHorizontal));
            }

            // OUTER LEFT
            for (int i = 0; i < 5; ++i)
            {
                Walls.Add(new Wall(new Rectangle(Scene.LEFT - 12, i * RowHeight + Scene.TOP, 12, RowHeight), Resources.Scene2_OuterWallVertical));
            }

            // OUTER RIGHT
            for (int i = 0; i < 5; ++i)
            {
                Walls.Add(new Wall(new Rectangle(Scene.LEFT + Columns * ColumnWidth + 6, i * RowHeight + Scene.TOP, 12, RowHeight), Resources.Scene2_OuterWallVertical));
            }

            ////////////////////////////////////////////////////////////////////////////////
            // ADDING LINES INSIDE
            // FIRST COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 0 * ColumnWidth, 2 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene2_InnerWallHorizontal));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * ColumnWidth, 2 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene2_InnerWallVertical));

            // SECOND COLUMN
            // HORIZONTAL
         
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * ColumnWidth, 1 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene2_InnerWallVertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * ColumnWidth, 2 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene2_InnerWallVertical));

            // THIRD COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * ColumnWidth, 3 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene2_InnerWallHorizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * ColumnWidth, 4 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene2_InnerWallHorizontal));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 2 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene2_InnerWallVertical));


            // FOURTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 1 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene2_InnerWallHorizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 2 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene2_InnerWallHorizontal));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 4 * ColumnWidth, 0 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene2_InnerWallVertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 4 * ColumnWidth, 1 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene2_InnerWallVertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 4 * ColumnWidth, 2 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene2_InnerWallVertical));


            // FIFTH COLUMN
            // HORIZONTAL
            
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 5 * ColumnWidth, 1 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene2_InnerWallVertical));


            // SIXTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 5 * ColumnWidth, 1 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene2_InnerWallHorizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 5 * ColumnWidth, 3 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene2_InnerWallHorizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 5 * ColumnWidth, 4 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene2_InnerWallHorizontal));
            // VERTICAL



            // ANGLES OF SCENE DECOR
            // TOP-LEFT
            Walls.Add(new Wall(new Rectangle(Scene.LEFT - 12, Scene.TOP - 12, 15, 15), Resources.Scene2_TopLeft));

            // TOP-RIGHT
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + Columns * ColumnWidth + 2, Scene.TOP - 13, 15, 15), Resources.Scene2_TopRight));

            // BOTTOM-LEFT
            Walls.Add(new Wall(new Rectangle(Scene.LEFT - 12, Rows * RowHeight + Scene.TOP + 2, 15, 15), Resources.Scene2_BottomLeft));

            // BOTTOM-RIGHT
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + Columns * ColumnWidth + 2, Rows * RowHeight + Scene.TOP + 2, 15, 15), Resources.Scene2_BottomRight));

        }
    }
}
