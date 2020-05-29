using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheExpedition2
{
    class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location)
          : base(game, location, 10) { }

        public override void Move(Random random)
        {
            while (!Dead)
            {
                int myRandom = random.Next(2);
                if (myRandom == 0 || myRandom == 1)
                    Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                if (NearPlayer())
                    game.HitPlayer(4, random);
            }
        }
    }
}
