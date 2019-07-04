using Battle_Tank.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            DecorWalls.Add(new Wall(new Rectangle(Scene.LEFT + 0 * 270, Scene.TOP - 17, 270, 17), Resources.Scene1_TopDecor));
            DecorWalls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * 270, Scene.TOP - 17, 270, 17), Resources.Scene1_TopDecor));
            DecorWalls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * 270, Scene.TOP - 17, 270, 17), Resources.Scene1_TopDecor));
            DecorWalls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * 270, Scene.TOP - 17, 90, 17), Resources.Scene1_TopDecor));

            // RIGHT
            int offset = 10;
            DecorWalls.Add(new Wall(new Rectangle(Scene.LEFT + Columns * ColumnWidth + 6, Scene.TOP + offset, 17, 270), Resources.Scene1_RightDecor));
            DecorWalls.Add(new Wall(new Rectangle(Scene.LEFT + Columns * ColumnWidth + 6, Scene.TOP + 1 * 270 + offset, 17, 270), Resources.Scene1_RightDecor));

            // BOTTOM
            DecorWalls.Add(new Wall(new Rectangle(Scene.LEFT + 0 * 270, Scene.TOP + Rows * RowHeight + 6, 270, 17), Resources.Scene1_BottomDecor));
            DecorWalls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * 270, Scene.TOP + Rows * RowHeight + 6, 270, 17), Resources.Scene1_BottomDecor));
            DecorWalls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * 270, Scene.TOP + Rows * RowHeight + 6, 270, 17), Resources.Scene1_BottomDecor));
            DecorWalls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * 270, Scene.TOP + Rows * RowHeight + 6, 90, 17), Resources.Scene1_BottomDecor));

            // LEFT
            DecorWalls.Add(new Wall(new Rectangle(Scene.LEFT - 17, Scene.TOP + offset, 17, 270), Resources.Scene1_LeftDecor));
            DecorWalls.Add(new Wall(new Rectangle(Scene.LEFT - 17, Scene.TOP + 1 * 270 + offset, 17, 270), Resources.Scene1_LeftDecor));

            // Other Things
        }

        public override void DrawOtherElements(SceneForm sceneForm)
        {
            base.DrawOtherElements(sceneForm);

            int left = 1000;
            int top = 300;
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
