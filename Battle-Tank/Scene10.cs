﻿using Battle_Tank.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battle_Tank
{
    public class Scene10 : Scene
    {
        public Scene10(int Width, int Height)
            : base(7, 11, 90, 90, Width, Height, Color.FromArgb(232, 240, 240))
        {

            // TOP
            for (int i = 0; i < 11; ++i)
            {
                Walls.Add(new Wall(new Rectangle((i * ColumnWidth) + Scene.LEFT, Scene.TOP, ColumnWidth, 6), Resources.Scene10_InnerWallHorizontal));
            }

            // BOTTOM
            for (int i = 0; i < 11; ++i)
            {
                Walls.Add(new Wall(new Rectangle(i * ColumnWidth + Scene.LEFT, Rows * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene10_InnerWallHorizontal));
            }

            // LEFT
            for (int i = 0; i < 7; ++i)
            {
                Walls.Add(new Wall(new Rectangle(Scene.LEFT, i * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene10_InnerWallVertical));
            }

            // RIGHT
            for (int i = 0; i < 7; ++i)
            {
                Walls.Add(new Wall(new Rectangle(Scene.LEFT + Columns * ColumnWidth, i * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene10_InnerWallVertical));
            }


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // OUTER TOP
            for (int i = 0; i < 11; ++i)
            {
                DecorWalls.Add(new Wall(new Rectangle((i * ColumnWidth) + Scene.LEFT, Scene.TOP - 16, ColumnWidth, 16), Resources.Scene7_OuterWallTop));
            }

            // OUTER BOTTOM
            for (int i = 0; i < 11; ++i)
            {
                DecorWalls.Add(new Wall(new Rectangle(i * ColumnWidth + Scene.LEFT, Rows * RowHeight + Scene.TOP + 6, ColumnWidth, 16), Resources.Scene7_OuterWallBottom));
            }

            // OUTER LEFT
            for (int i = 0; i < 7; ++i)
            {
                DecorWalls.Add(new Wall(new Rectangle(Scene.LEFT - 16, i * RowHeight + Scene.TOP, 16, RowHeight), Resources.Scene7_OuterWallLeft));
            }

            // OUTER RIGHT
            for (int i = 0; i < 7; ++i)
            {
                DecorWalls.Add(new Wall(new Rectangle(Scene.LEFT + Columns * ColumnWidth + 6, i * RowHeight + Scene.TOP, 16, RowHeight), Resources.Scene7_OuterWallRight));
            }



            ////////////////////////////////////////////////////////////////////////////////
            // ADDING LINES INSIDE
            // FIRST COLUMN
            // HORIZONTAL
            
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * ColumnWidth, 0 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene10_InnerWallVertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * ColumnWidth, 3 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene10_InnerWallVertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * ColumnWidth, 6 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene10_InnerWallVertical));

            // SECOND COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * ColumnWidth, 1 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene10_InnerWallHorizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * ColumnWidth, 3 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene10_InnerWallHorizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * ColumnWidth, 4 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene10_InnerWallHorizontal));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * ColumnWidth, 2 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene10_InnerWallVertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * ColumnWidth, 4 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene10_InnerWallVertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * ColumnWidth, 5 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene10_InnerWallVertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * ColumnWidth, 6 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene10_InnerWallVertical));

            // THIRD COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * ColumnWidth, 6 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene10_InnerWallHorizontal));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 1 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene10_InnerWallVertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 2 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene10_InnerWallVertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 3 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene10_InnerWallVertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 5 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene10_InnerWallVertical));


            // FOURTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 3 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene10_InnerWallHorizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 4 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene10_InnerWallHorizontal));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 4 * ColumnWidth, 1 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene10_InnerWallVertical));


            // FIFTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 4 * ColumnWidth, 2 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene10_InnerWallHorizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 4 * ColumnWidth, 4 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene10_InnerWallHorizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 4 * ColumnWidth, 6 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene10_InnerWallHorizontal));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 5 * ColumnWidth, 1 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene10_InnerWallVertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 5 * ColumnWidth, 2 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene10_InnerWallVertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 5 * ColumnWidth, 4 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene10_InnerWallVertical));


            // SIXTH COLUMN
            // HORIZONTAL

            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 6 * ColumnWidth, 0 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene10_InnerWallVertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 6 * ColumnWidth, 1 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene10_InnerWallVertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 6 * ColumnWidth, 4 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene10_InnerWallVertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 6 * ColumnWidth, 6 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene10_InnerWallVertical));

            // SEVENTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 6 * ColumnWidth, 2 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene10_InnerWallHorizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 6 * ColumnWidth, 4 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene10_InnerWallHorizontal));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 7 * ColumnWidth, 2 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene10_InnerWallVertical));


            // EIGHTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 7 * ColumnWidth, 4 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene10_InnerWallHorizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 7 * ColumnWidth, 5 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene10_InnerWallHorizontal));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 8 * ColumnWidth, 0 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene10_InnerWallVertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 8 * ColumnWidth, 2 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene10_InnerWallVertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 8 * ColumnWidth, 6 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene10_InnerWallVertical));


            // NINETH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 8 * ColumnWidth, 3 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene10_InnerWallHorizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 8 * ColumnWidth, 5 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene10_InnerWallHorizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 8 * ColumnWidth, 6 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene10_InnerWallHorizontal));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 9 * ColumnWidth, 1 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene10_InnerWallVertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 9 * ColumnWidth, 2 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene10_InnerWallVertical));

            // TENTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 9 * ColumnWidth, 4 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene10_InnerWallHorizontal));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 10 * ColumnWidth, 0 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene10_InnerWallVertical));

            // ELEVENTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 10 * ColumnWidth, 4 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene10_InnerWallHorizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 10 * ColumnWidth, 6 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene10_InnerWallHorizontal));
            // VERTICAL



            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // ANGLES OF SCENE DECOR
            // TOP-LEFT
            DecorWalls.Add(new Wall(new Rectangle(Scene.LEFT - 16, Scene.TOP - 16, 19, 19), Resources.Scene7_TopLeft));

            // TOP-RIGHT
            DecorWalls.Add(new Wall(new Rectangle(Scene.LEFT + Columns * ColumnWidth + 2, Scene.TOP - 17, 19, 19), Resources.Scene7_TopRight));

            // BOTTOM-LEFT
            DecorWalls.Add(new Wall(new Rectangle(Scene.LEFT - 16, Rows * RowHeight + Scene.TOP + 2, 19, 19), Resources.Scene7_BottomLeft));

            // BOTTOM-RIGHT
            DecorWalls.Add(new Wall(new Rectangle(Scene.LEFT + Columns * ColumnWidth + 3, Rows * RowHeight + Scene.TOP + 3, 19, 19), Resources.Scene7_BottomRight));

        }

        public override void DrawOtherElements(SceneForm sceneForm)
        {
            base.DrawOtherElements(sceneForm);

            int left = 1075;
            int top = 200;
            int distanceBetweenPictureBoxes = 200;

            PictureBoxPlayer1.Location = new Point(left, top);
            LabelPlayer1Name.Location = new Point(left + 10, top + 20);
            LabelPlayer1Result.Location = new Point(left + 10 + 165 + 10, top + 20);

            PictureBoxPlayer2.Location = new Point(left, top + distanceBetweenPictureBoxes);
            LabelPlayer2Name.Location = new Point(left + 10, top + 20 + distanceBetweenPictureBoxes);
            LabelPlayer2Result.Location = new Point(left + 10 + 165 + 10, top + 20 + distanceBetweenPictureBoxes);


            // ADD CONTROLS
            sceneForm.Controls.Add(LabelPlayer1Name);
            sceneForm.Controls.Add(LabelPlayer1Result);
            sceneForm.Controls.Add(PictureBoxPlayer1);
            sceneForm.Controls.Add(LabelPlayer2Name);
            sceneForm.Controls.Add(LabelPlayer2Result);
            sceneForm.Controls.Add(PictureBoxPlayer2);
        }
    }
}