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
    public class Scene4 : Scene
    {
        public Scene4(int Width, int Height)
            : base(5, 11, 90, 90, Width, Height, Color.FromArgb(232, 240, 240))
        {
            for (int i = 0; i < 11; ++i)
            {
                Walls.Add(new Wall(new Rectangle((i * ColumnWidth) + Scene.LEFT, Scene.TOP, ColumnWidth, 6), Resources.Scene4_HorizontalWall));
            }

            // BOTTOM
            for (int i = 0; i < 11; ++i)
            {
                Walls.Add(new Wall(new Rectangle(i * ColumnWidth + Scene.LEFT, Rows * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene4_HorizontalWall));
            }

            // LEFT
            for (int i = 0; i < 5; ++i)
            {
                Walls.Add(new Wall(new Rectangle(Scene.LEFT, i * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene4_VerticalWall));
            }

            // RIGHT
            for (int i = 0; i < 5; ++i)
            {
                Walls.Add(new Wall(new Rectangle(Scene.LEFT + Columns * ColumnWidth, i * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene4_VerticalWall));
            }


            // ADDING LINES INSIDE
            // FIRST COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 0 * ColumnWidth, 2 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene4_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 0 * ColumnWidth, 3 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene4_HorizontalWall));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * ColumnWidth, 0 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene4_VerticalWall));

            // SECOND COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * ColumnWidth, 4 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene4_HorizontalWall));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * ColumnWidth, 1 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene4_VerticalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * ColumnWidth, 3 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene4_VerticalWall));

            // THIRD COLUMN
            // HORIZONTAL

            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 1 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene4_VerticalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 2 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene4_VerticalWall));


            // FOURTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 1 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene4_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * ColumnWidth, 3 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene4_HorizontalWall));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 4 * ColumnWidth, 1 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene4_VerticalWall));

            // FIFTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 4 * ColumnWidth, 3 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene4_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 4 * ColumnWidth, 4 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene4_HorizontalWall));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 5 * ColumnWidth, 0 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene4_VerticalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 5 * ColumnWidth, 4 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene4_VerticalWall));

            // SIXTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 5 * ColumnWidth, 2 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene4_HorizontalWall));
            // VERTICAL


            // SEVENTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 6 * ColumnWidth, 2 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene4_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 6 * ColumnWidth, 3 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene4_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 6 * ColumnWidth, 4 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene4_HorizontalWall));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 7 * ColumnWidth, 1 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene4_VerticalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 7 * ColumnWidth, 3 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene4_VerticalWall));


            // EIGHTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 7 * ColumnWidth, 1 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene4_HorizontalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 7 * ColumnWidth, 4 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene4_HorizontalWall));
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 8 * ColumnWidth, 1 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene4_VerticalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 8 * ColumnWidth, 2 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene4_VerticalWall));


            // NINTH COLUMN
            // HORIZONTAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 8 * ColumnWidth, 3 * RowHeight + Scene.TOP, ColumnWidth, 6), Resources.Scene4_HorizontalWall));
            // VERTICAL

            // TENTH COLUMN
            // HORIZONTAL
            // VERTICAL
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 10 * ColumnWidth, 1 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene4_VerticalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 10 * ColumnWidth, 2 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene4_VerticalWall));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 10 * ColumnWidth, 4 * RowHeight + Scene.TOP, 6, RowHeight), Resources.Scene4_VerticalWall));





            // OUT OF SCENE DECOR
            // TOP
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 0 * 270, Scene.TOP - 17, 270, 17), Resources.Scene1_TopDecor));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * 270, Scene.TOP - 17, 270, 17), Resources.Scene1_TopDecor));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * 270, Scene.TOP - 17, 270, 17), Resources.Scene1_TopDecor));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * 270, Scene.TOP - 17, 180, 17), Resources.Scene1_TopDecor));

            // RIGHT
            int offset = 0;
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + Columns * ColumnWidth + 6, Scene.TOP + offset, 17, 270), Resources.Scene1_RightDecor));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + Columns * ColumnWidth + 6, Scene.TOP + 1 * 270 + offset, 17, 180), Resources.Scene1_RightDecor));

            // BOTTOM
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 0 * 270, Scene.TOP + Rows * RowHeight + 6, 270, 17), Resources.Scene1_BottomDecor));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 1 * 270, Scene.TOP + Rows * RowHeight + 6, 270, 17), Resources.Scene1_BottomDecor));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 2 * 270, Scene.TOP + Rows * RowHeight + 6, 270, 17), Resources.Scene1_BottomDecor));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT + 3 * 270, Scene.TOP + Rows * RowHeight + 6, 180, 17), Resources.Scene1_BottomDecor));

            // LEFT
            Walls.Add(new Wall(new Rectangle(Scene.LEFT - 17, Scene.TOP + offset, 17, 270), Resources.Scene1_LeftDecor));
            Walls.Add(new Wall(new Rectangle(Scene.LEFT - 17, Scene.TOP + 1 * 270 + offset, 17, 180), Resources.Scene1_LeftDecor));
        }

        public override void DrawOtherElements(SceneForm sceneForm)
        {
            base.DrawOtherElements(sceneForm);

            int left = 200;
            int top = 550;

            PictureBoxPlayer1.Location = new Point(left, top);

            LabelPlayer1Name.Location = new Point(left + 10, top + 20);

            PictureBoxPlayer2.Location = new Point(left + 400, top);

            LabelPlayer2Name.Location = new Point(left + 400 + 10, top + 20);

            LabelPlayer1Result.Location = new Point(left + 10 + 165 + 10, top + 20);

            LabelPlayer2Result.Location = new Point(left + 10 + 165 + 10 + 400, top + 20);


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
