using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Tank
{
    public class Scenes
    {
        public List<Scene> ScenesList { get; set; }

        public Scenes()
        {
            ScenesList = new List<Scene>();
            Scene scene = new Scene(20, 20, 940, 560);


            // ADDING LINES FIRST COLUMN
            scene.Lines.Add(new Line(new Point(20 + 0, 20 + 5 * 80), new Point(20 + 1 * 94, 20 + 5 * 80)));
            scene.Lines.Add(new Line(new Point(20 + 1 * 94, 20 + 5 * 80), new Point(20 + 1 * 94, 20 + 6 * 80)));

            // ADDING LINES SECOND COLUMN
            scene.Lines.Add(new Line(new Point(20 + 2 * 94, 20 + 0 * 80), new Point(20 + 2 * 94, 20 + 1 * 80)));
            scene.Lines.Add(new Line(new Point(20 + 1 * 94, 20 + 2 * 80), new Point(20 + 2 * 94, 20 + 2 * 80)));
            scene.Lines.Add(new Line(new Point(20 + 1 * 94, 20 + 3 * 80), new Point(20 + 4 * 94, 20 + 3 * 80)));
            scene.Lines.Add(new Line(new Point(20 + 1 * 94, 20 + 4 * 80), new Point(20 + 4 * 94, 20 + 4 * 80)));
            scene.Lines.Add(new Line(new Point(20 + 2 * 94, 20 + 5 * 80), new Point(20 + 4 * 94, 20 + 5 * 80)));
            scene.Lines.Add(new Line(new Point(20 + 2 * 94, 20 + 6 * 80), new Point(20 + 2 * 94, 20 + 7 * 80)));

            // ADDING LINES THIRD COLUMN
            scene.Lines.Add(new Line(new Point(20 + 3 * 94, 20 + 1 * 80), new Point(20 + 3 * 94, 20 + 3 * 80)));
            scene.Lines.Add(new Line(new Point(20 + 3 * 94, 20 + 5 * 80), new Point(20 + 3 * 94, 20 + 6 * 80)));

            // ADDING LINES FOURTH COLUMN
            scene.Lines.Add(new Line(new Point(20 + 4 * 94, 20 + 1 * 80), new Point(20 + 4 * 94, 20 + 2 * 80)));
            scene.Lines.Add(new Line(new Point(20 + 4 * 94, 20 + 3 * 80), new Point(20 + 4 * 94, 20 + 5 * 80)));
            scene.Lines.Add(new Line(new Point(20 + 4 * 94, 20 + 6 * 80), new Point(20 + 4 * 94, 20 + 7 * 80)));
            scene.Lines.Add(new Line(new Point(20 + 3 * 94, 20 + 2 * 80), new Point(20 + 6 * 94, 20 + 2 * 80)));
            scene.Lines.Add(new Line(new Point(20 + 4 * 94, 20 + 6 * 80), new Point(20 + 5 * 94, 20 + 6 * 80)));


            // ADDING LINES FIFTH COLUMN
            //Vertical
            scene.Lines.Add(new Line(new Point(20 + 5 * 94, 20 + 0 * 80), new Point(20 + 5 * 94, 20 + 1 * 80)));
            scene.Lines.Add(new Line(new Point(20 + 5 * 94, 20 + 5 * 80), new Point(20 + 5 * 94, 20 + 6 * 80)));
            scene.Lines.Add(new Line(new Point(20 + 6 * 94, 20 + 1 * 80), new Point(20 + 6 * 94, 20 + 3 * 80)));
            scene.Lines.Add(new Line(new Point(20 + 6 * 94, 20 + 4 * 80), new Point(20 + 6 * 94, 20 + 5 * 80)));
            //Horizontal
            scene.Lines.Add(new Line(new Point(20 + 5 * 94, 20 + 1 * 80), new Point(20 + 6 * 94, 20 + 1 * 80)));
            scene.Lines.Add(new Line(new Point(20 + 5 * 94, 20 + 3 * 80), new Point(20 + 6 * 94, 20 + 3 * 80)));
            scene.Lines.Add(new Line(new Point(20 + 5 * 94, 20 + 4 * 80), new Point(20 + 6 * 94, 20 + 4 * 80)));


            // ADDING LINES SIXTH COLUMN
            // Horizontal
            scene.Lines.Add(new Line(new Point(20 + 6 * 94, 20 + 6 * 80), new Point(20 + 7 * 94, 20 + 6 * 80)));
            // Vertical
            scene.Lines.Add(new Line(new Point(20 + 7 * 94, 20 + 2 * 80), new Point(20 + 7 * 94, 20 + 3 * 80)));

            // ADDING LINES SEVENTH COLUMN
            // Horizontal
            scene.Lines.Add(new Line(new Point(20 + 7 * 94, 20 + 4 * 80), new Point(20 + 8 * 94, 20 + 4 * 80)));
            scene.Lines.Add(new Line(new Point(20 + 7 * 94, 20 + 5 * 80), new Point(20 + 10 * 94, 20 + 5 * 80)));
            //Vertical
            scene.Lines.Add(new Line(new Point(20 + 8 * 94, 20 + 5 * 80), new Point(20 + 8 * 94, 20 + 6 * 80)));

            // ADDING LINES EIGHTH COLUMN
            // Horizontal
            scene.Lines.Add(new Line(new Point(20 + 8 * 94, 20 + 1 * 80), new Point(20 + 9 * 94, 20 + 1 * 80)));
            scene.Lines.Add(new Line(new Point(20 + 8 * 94, 20 + 3 * 80), new Point(20 + 9 * 94, 20 + 3 * 80)));
            //Vertical
            scene.Lines.Add(new Line(new Point(20 + 9 * 94, 20 + 4 * 80), new Point(20 + 9 * 94, 20 + 5 * 80)));


            // ADDING LINES NINTH COLUMN
            // Horizontal
            scene.Lines.Add(new Line(new Point(20 + 9 * 94, 20 + 2 * 80), new Point(20 + 10 * 94, 20 + 2 * 80)));

            ScenesList.Add(scene);
        }

            


        public void Draw(Pen pen, Graphics g)
        {
            foreach(Scene scene in ScenesList)
            {
                scene.Draw(pen, g);
            }
        }
    }
}
