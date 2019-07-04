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
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public NewGame(string firstPlayerName, string secondPlayerName)
        {
            //this.Width = Width;
            //this.Height = Height;
            
            GenerateScene();

            Player1 = new Player(firstPlayerName, Tank.Position.LeftToRight);
            Player2 = new Player(secondPlayerName, Tank.Position.RightToLeft);
        }


        private void GenerateScene()
        {
            Random random = new Random();

            int r = random.Next(0,11);

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
