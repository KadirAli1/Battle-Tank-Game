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
    public class Player
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public Tank Tank { get; set; }
        public bool IsPlayerBurned {get;set;}
        // public static int Points { get; set; }
        public Player(string Name, Tank.Position Position)
        {
            this.Name = Name;
            RefreshTanks(Position);
            //Points = 0;
            IsPlayerBurned = false;
            Points = 0;
        }

        public void RefreshTanks(Tank.Position Position)
        {
            if (Position == Tank.Position.LeftToRight)
            {
                Tank = new Tank(Scene.LEFT + 20, Scene.TOP + 20, 0, Position);
            }
            else if (Position == Tank.Position.RightToLeft)
            {
                Tank = new Tank(Scene.RIGHT - 50, Scene.BOTTOM - 50, 180, Position);
            }

        }

        public void Draw(Graphics g)
        {
             Tank.Draw(g);
             IsPlayerBurned = Tank.IsTankBurned;
        }
    }
}
