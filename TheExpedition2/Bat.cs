using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheExpedition2
{
    class Bat : Enemy
    {
        public Bat(Game game, Point location)
            : base(game, location, 6) { }

        public override void Move(Random random)
        {
            while (!Dead)
            {
                int myRandom = random.Next(1);
                if (myRandom == 0)
                    Move((Direction)random.Next(3), game.Boundaries);
                else
                    Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                if (NearPlayer())
                    game.HitPlayer(2, random);
            }
        }
    }
}
