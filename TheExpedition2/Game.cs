using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TheExpedition2
{
    class Game
    {
        public ICollection<Enemy> Enemies { get; private set; }
        public Weapon WeaponInRoom { get; private set; }
        private Player player;
        public Point PlayerLocation { get { return player.Location; } }
        public int PlayerHitPoints { get { return player.HitPoints; } }
        public IEnumerable<string> PlayerWeapons { get { return player.Weapons; } }
        private int level = 0;
        public bool WantToRepeat = false;
        public int Level { get { return level; } }
        private Rectangle boundaries;
        public Rectangle Boundaries { get { return boundaries; } }

        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            player = new Player(this, new Point(boundaries.Left + 10, boundaries.Top + 70));
        }

        public void Move(Direction direction, Random random)
        {
            player.Move(direction);
            foreach (Enemy enemy in Enemies)
                enemy.Move(random);
        }


        public void Equip(string weaponName)
        {
            player.Equip(weaponName);
        }

        public bool CheckPlayerInventory(string weaponName)
        {
            return player.Weapons.Contains(weaponName);
        }

        public void HitPlayer(int maxDemage, Random random)
        {
            player.Hit(maxDemage, random);
        }

        public void IncreasePlayerHealth(int health, Random random)
        {
            player.IncreaseHealth(health, random);
        }

        public void Attack(Direction direction, Random random)
        {
            player.Attack(direction, random);
            foreach (Enemy enemy in Enemies)
                enemy.Move(random);
        }

        private Point GetRandomLocation(Random random)
        {
            return new Point(boundaries.Left + random.Next(boundaries.Right / 10 - boundaries.Left / 10) * 10,
                boundaries.Top + random.Next(boundaries.Bottom / 10 - boundaries.Top / 10) * 10);
        }

        public void NewLevel(Random random)
        {
            if (!WantToRepeat)
                level++;
            WantToRepeat = false;
            switch (level)
            {
                case 1:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    if (!CheckPlayerInventory("Sword"))
                        WeaponInRoom = new Sword(this, GetRandomLocation(random));
                    break;
                case 2:
                    Enemies.Clear();
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    if (!CheckPlayerInventory("BluePotion"))
                        WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    break;
                case 3:
                    Enemies.Clear();
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    if (!CheckPlayerInventory("Bow"))
                        WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    break;
                case 4:
                    Enemies.Clear();
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    if (!CheckPlayerInventory("Bow"))
                        WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    else if(!CheckPlayerInventory("BluePotion"))
                        WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    break;
                case 5:
                    Enemies.Clear();
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    if (!CheckPlayerInventory("RedPotion"))
                        WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    break;
                case 6:
                    Enemies.Clear();
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    if (!CheckPlayerInventory("Mace"))
                        WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    break;
                case 7:
                    Enemies.Clear();
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    if (!CheckPlayerInventory("Mace"))
                        WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    else if (!CheckPlayerInventory("RedPotion"))
                        WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    break;
                case 8:
                    break;
                default:
                    Application.Exit();
                    break;
            }
        }
    }
}
