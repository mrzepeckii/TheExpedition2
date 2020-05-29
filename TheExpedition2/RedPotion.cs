using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TheExpedition2
{
    class RedPotion : Weapon, IPotion
    {
        public override string Name { get { return "RedPotion"; } }
        public bool Used { get; private set; }
        public RedPotion(Game game, Point point)
            : base(game, point) { Used = false; }

        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(10, random);
            Used = true;
        }

    }
}
