using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheExpedition2
{
    class Bat : Enemy
    {
        public Bat(Game game, Point location)
            : base(game, location, 6) { }

        public override void Move(Random random)
        {
            if (!Dead)
            {
                int myRandom = random.Next(2);
                if (myRandom == 1)
                    location = Move((Direction)random.Next(3), game.Boundaries);
                else
                    location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                  
                if (NearPlayer())
                    game.HitPlayer(2, random);
            }
        }
    }
}
