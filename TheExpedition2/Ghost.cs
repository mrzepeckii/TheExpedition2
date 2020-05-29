using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheExpedition2
{
    class Ghost : Enemy
    {
        public Ghost(Game game, Point location)
           : base(game, location, 8) { }

        public override void Move(Random random)
        {
            while (!Dead)
            {
                int myRandom = random.Next(2);
                if (myRandom == 0)
                    Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                if (NearPlayer())
                    game.HitPlayer(3, random);
            }
        }
    }
}
