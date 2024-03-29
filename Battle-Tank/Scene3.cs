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
    public class Scene3 : Scene
    {
        public Scene3(int Width, int Height)
            : base(6, 5, 90, 90, Width, Height, Color.FromArgb(232, 240, 240))
        {

            // TOP
            for (int i = 0; i < 5; ++i)
            {
                Walls.Add(new Wall(new Rectangle((i * ColumnWidth) + Scene.LEFT, Scene.TOP, ColumnWidth, 7), Resources.Scene3_InnerWallHorizontal));
            }

            // BOTTOM
            for (int i = 0; i < 5; ++i)
            {
                Walls.Add(new Wall(new Rectangle(i * ColumnWidth + Scene.LEFT, Rows * RowHeight + Scene.TOP, ColumnWidth, 7), Resources.Scene3_InnerWallHorizontal));
            }

            // LEFT
            for (int i = 0; i < 6; ++i)
            {
                Walls.Add(new Wall(new Rectangle(Scene.LEFT, i * RowHeight + Scene.TOP, 7, RowHeight), Resources.Scene3_InnerWallVertical));
            }

            // RIGHT
            for (int i = 0; i < 6; ++i)
            {
                Walls.Add(new Wall(new Rectangle(Scene.LEFT + Columns * ColumnWidth, i * RowHeight + Scene.TOP, 7, RowHeight), Resources.Scene3_InnerWallVertical));
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // OUTER TOP
            for (int i = 0; i < 5; ++i)
            {
                DecorWalls.Add(new Wall(new Rectangle((i * ColumnWidth) + Scene.LEFT, Scene.TOP - 12, ColumnWidth, 12), Resources.Scene2_OuterWallHorizontal));
            }

            // OUTER BOTTOM
            for (int i = 0; i < 5; ++i)
            {
                DecorWalls.Add(new Wall(new Rectangle(i * ColumnWidth + Scene.LEFT, Rows * RowHeight + Scene.TOP + 7, ColumnWidth, 12), Resources.Scene2_OuterWallHorizontal));
            }

            // OUTER LEFT
            for (int i = 0; i < 6; ++i)
            {
                DecorWalls.Add(new Wall(new Rectangle(Scene.LEFT - 12, i * RowHeight + Scene.TOP, 12, RowHeight), Resources.Scene2_OuterWallVertical));
            }

            // OUTER RIGHT
            for (int i = 0; i < 6; ++i)
            {
                DecorWalls.Add(new Wall(new Rectangle(Scene.LEFT + Columns * ColumnWidth + 7, i * RowHeight + Scene.TOP, 12, RowHeight), Resources.Scene2_OuterWallVertical));
            }

            ////////////////////////////////////////////////////////////////////////////////
            // ADDING LINES INSIDE
            // FIRST COLUMN
            // HORIZONTAL
    
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * ColumnWidth, 1 * RowHeight + Scene.TOP, 7, RowHeight), Resources.Scene3_InnerWallVertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * ColumnWidth, 2 * RowHeight + Scene.TOP, 7, RowHeight), Resources.Scene3_InnerWallVertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * ColumnWidth, 4 * RowHeight + Scene.TOP, 7, RowHeight), Resources.Scene3_InnerWallVertical));

            // SECOND COLUMN
            // HORIZONTAL

            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * ColumnWidth, 4 * RowHeight + Scene.TOP, 7, RowHeight), Resources.Scene3_InnerWallVertical));

            // THIRD COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * ColumnWidth, 3 * RowHeight + Scene.TOP, ColumnWidth, 7), Resources.Scene3_InnerWallHorizontal));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 1 * RowHeight + Scene.TOP, 7, RowHeight), Resources.Scene3_InnerWallVertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 2 * RowHeight + Scene.TOP, 7, RowHeight), Resources.Scene3_InnerWallVertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 4 * RowHeight + Scene.TOP, 7, RowHeight), Resources.Scene3_InnerWallVertical));


            // FOURTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 2 * RowHeight + Scene.TOP, ColumnWidth, 7), Resources.Scene3_InnerWallHorizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 3 * RowHeight + Scene.TOP, ColumnWidth, 7), Resources.Scene3_InnerWallHorizontal));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth + 4, 5 * RowHeight + Scene.TOP, ColumnWidth, 7), Resources.Scene3_InnerWallHorizontal));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 4 * ColumnWidth, 3 * RowHeight + Scene.TOP, 7, RowHeight), Resources.Scene3_InnerWallVertical));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 4 * ColumnWidth, 4 * RowHeight + Scene.TOP, 7, RowHeight), Resources.Scene3_InnerWallVertical));


            // FIFTH COLUMN
            // HORIZONTAL

            // VERTICAL



            // ANGLES OF SCENE DECOR
            // TOP-LEFT
            DecorWalls.Add(new Wall(new Rectangle(Scene.LEFT - 12, Scene.TOP - 12, 15, 15), Resources.Scene2_TopLeft));

            // TOP-RIGHT
            DecorWalls.Add(new Wall(new Rectangle(Scene.LEFT + Columns * ColumnWidth + 2, Scene.TOP - 13, 15, 15), Resources.Scene2_TopRight));

            // BOTTOM-LEFT
            DecorWalls.Add(new Wall(new Rectangle(Scene.LEFT - 12, Rows * RowHeight + Scene.TOP + 2, 15, 15), Resources.Scene2_BottomLeft));

            // BOTTOM-RIGHT
            DecorWalls.Add(new Wall(new Rectangle(Scene.LEFT + Columns * ColumnWidth + 2, Rows * RowHeight + Scene.TOP + 2, 15, 15), Resources.Scene2_BottomRight));



        }

        public override void DrawOtherElements(SceneForm sceneForm)
        {
            base.DrawOtherElements(sceneForm);

            int left = 600;
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
