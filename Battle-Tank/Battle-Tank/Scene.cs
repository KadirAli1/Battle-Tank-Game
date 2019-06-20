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
    public class Scene
    {
        public int RowHeight { get; set; }
        public int ColumnWidth{ get; set; }

        public static int TOP;
        public static int LEFT;
        public static int BOTTOM;
        public static int RIGHT;

        public int Columns { get; set; }
        public int Rows { get; set; }
        //public int Width { get; set; }
        //public int Height { get; set; }
        public List<Wall> Walls { get; set; }

        public Color BackgroundColor { get; set; }
        public PictureBox PictureBoxPlayer1 { get; set; }
        public PictureBox PictureBoxPlayer2 { get; set; }

        public Label LabelPlayer1Name { get; set; }
        public Label LabelPlayer2Name { get; set; }
        public Label LabelPlayer1Result { get; set; }
        public Label LabelPlayer2Result { get; set; }
        public Label Label { get; set; }
        public Scene(int Rows, int Columns, int RowHeight, int ColumnWidth, int Width, int Height, Color Color)
        {
            Walls = new List<Wall>();
            this.Columns = Columns;
            this.Rows = Rows;
            this.RowHeight = RowHeight;
            this.ColumnWidth = ColumnWidth;

            TOP = 30;
            LEFT = 50;
            BOTTOM = TOP + Rows * RowHeight;
            RIGHT = LEFT + Columns * ColumnWidth;

            BackgroundColor = Color;

            PictureBoxPlayer1 = new PictureBox();
            PictureBoxPlayer2 = new PictureBox();
            LabelPlayer1Name = new Label();
            LabelPlayer2Name = new Label();
            LabelPlayer1Result = new Label();
            LabelPlayer2Result = new Label();
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

        public virtual void DrawOtherElements(SceneForm sceneForm)
        {
            string FontFamily = "Bradley Hand ITC";
            float FontSize = 20F;

            PictureBoxPlayer1.Image = Resources.Reslts_Panel263x76;
            PictureBoxPlayer1.Size = new Size(263, 76);

            // MAX NUMBER OF CHARACTERS: 10
            LabelPlayer1Name.Text = "FISNIK";
            LabelPlayer1Name.Size = new Size(165, 40);
            LabelPlayer1Name.TextAlign = ContentAlignment.MiddleCenter;
            LabelPlayer1Name.BackColor = Color.FromArgb(0, 80, 126);
            LabelPlayer1Name.Font = new Font(FontFamily, FontSize, FontStyle.Bold);
            LabelPlayer1Name.ForeColor = Color.FromArgb(128, 255, 0);

            PictureBoxPlayer2.Image = Resources.Reslts_Panel263x76;
            PictureBoxPlayer2.Size = new Size(263, 76);

            // MAX NUMBER OF CHARACTERS: 10
            LabelPlayer2Name.Text = "KADIR";
            LabelPlayer2Name.Size = new Size(165, 40);
            LabelPlayer2Name.TextAlign = ContentAlignment.MiddleCenter;
            LabelPlayer2Name.BackColor = Color.FromArgb(0, 80, 126);
            LabelPlayer2Name.Font = new Font(FontFamily, FontSize, FontStyle.Bold);
            LabelPlayer2Name.ForeColor = Color.FromArgb(255, 0, 255);


            LabelPlayer1Result.Text = string.Format("{0:D2}", 0);
            LabelPlayer1Result.BorderStyle = BorderStyle.None;
            LabelPlayer1Result.Size = new Size(60, 40);
            LabelPlayer1Result.TextAlign = ContentAlignment.MiddleCenter;
            LabelPlayer1Result.BackColor = Color.FromArgb(0, 53, 90);
            LabelPlayer1Result.Font = new Font(FontFamily, FontSize, FontStyle.Bold);
            LabelPlayer1Result.ForeColor = Color.FromArgb(128, 255, 0);


            // MAX NUMBER OF CHARACTERS: 10
            LabelPlayer2Result.Text = string.Format("{0:D2}", 0);
            LabelPlayer2Result.BorderStyle = BorderStyle.None;
            LabelPlayer2Result.Size = new Size(60, 40);
            LabelPlayer2Result.TextAlign = ContentAlignment.MiddleCenter;
            LabelPlayer2Result.BackColor = Color.FromArgb(0, 53, 90);
            LabelPlayer2Result.Font = new Font(FontFamily, FontSize, FontStyle.Bold);
            LabelPlayer2Result.ForeColor = Color.FromArgb(255, 0, 255);
        }
    }
}
