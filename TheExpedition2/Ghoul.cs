using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheExpedition2
{
    class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location)
          : base(game, location, 10) { }

        public override void Move(Random random)
        {
            if (!Dead)
            {
                int myRandom = random.Next(3);
                if (myRandom != 1)
                    location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                if (NearPlayer())
                    game.HitPlayer(4, random);
            }
        }
    }
}
