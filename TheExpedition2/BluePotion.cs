using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheExpedition2
{
    class BluePotion : Weapon, IPotion
    {

        public override string Name { get { return "BluePotion"; } }

        public bool Used { get; private set; }

        public BluePotion(Game game, Point point)
            :base (game, point) { Used = false; }

        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(5, random);
            Used = true;
        }
    }
}
