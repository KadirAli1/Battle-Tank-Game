using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Tank
{
    public class NewGame
    {
        public Scene Scene { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Scene ActualScene { get; set; }
        public static Player Player1 { get; set; }
        public static Player Player2 { get; set; }
        //public static int Player1Points { get; set; }
        //public static int Player2Points { get; set; }
        public NewGame(int Width, int Height, string Player1Name, string Player2Name)
        {
            this.Width = Width;
            this.Height = Height;

            GenerateScene(0);
            Player1 = new Player(Player1Name, Tank.Position.LeftToRight);
            Player2 = new Player(Player2Name, Tank.Position.RightToLeft);
            //Player1Points = 0;
            //Player2Points = 0;
        }


        public void GenerateScene(int r)
        {
            if (r == 0)
            {
                Random random = new Random();
                r = random.Next(1, 11);
            }

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

        public void DrawScene(Pen pen, Graphics g, SceneForm sceneForm)
        {
            ActualScene.Draw(pen, g);
            ActualScene.DrawOtherElements(sceneForm);
            Player1.Draw(g);
            Player2.Draw(g);
        }
    }
}
