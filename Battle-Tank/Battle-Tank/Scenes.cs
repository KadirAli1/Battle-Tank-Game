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
        public Scene ActualScene { get; set; }

        public Scenes(int Width, int Height)
        {
            GenerateScene(Width, Height);
        }

        public void GenerateScene(int Width, int Height)
        {
            Random random = new Random();

            int r = 1;
                //random.Next(5, 6);

            switch (r)
            {
                case 1:
                    ActualScene = new Scene1(Width, Height);
                    break;
                case 2:
                    ActualScene = new Scene2(Width, Height);
                    break;
                case 3:
                    ActualScene = new Scene3(Width, Height);
                    break;
                case 4:
                    ActualScene = new Scene4(Width, Height);
                    break;
                case 5:
                    ActualScene = new Scene5(Width, Height);
                    break;
                case 6:
                    ActualScene = new Scene6(Width, Height);
                    break;
                case 7:
                    ActualScene = new Scene7(Width, Height);
                    break;
                case 8:
                    ActualScene = new Scene8(Width, Height);
                    break;
                case 9:
                    ActualScene = new Scene9(Width, Height);
                    break;
                case 10:
                    ActualScene = new Scene10(Width, Height);
                    break;
                default:
                    ActualScene = new Scene1(Width, Height);
                    break;
            }
        }
            
        public void Draw(Pen pen, Graphics g, SceneForm sceneForm)
        {
            ActualScene.Draw(pen, g);
            ActualScene.DrawOtherElements(sceneForm);
        }
    }
}
