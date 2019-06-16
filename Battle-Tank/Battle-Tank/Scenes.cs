using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Battle_Tank.Properties;

namespace Battle_Tank
{
    public class Scenes
    {
        public List<Scene> ScenesList { get; set; }

        public Scenes(int Width, int Height)
        {
            ScenesList = new List<Scene>();
            CreateScenes(Width, Height);
        }

        private void CreateScenes(int Width, int Height)
        {
            ScenesList.Add(CreateScene1(Width, Height));
        }

        private Scene CreateScene1(int Width, int Height)
        {
            int Rows = 7;
            int Columns = 10;
            int ColumnWidth = 90;
            int RowHeight = 80;

            Scene scene = new Scene(Rows, Columns, RowHeight, ColumnWidth , Width, Height, Color.FromArgb(224, 232, 235));

            
            

            return scene;
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
