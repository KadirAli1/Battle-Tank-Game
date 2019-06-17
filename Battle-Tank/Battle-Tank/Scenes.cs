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
            ScenesList.Add(new Scene3(Width, Height));
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
