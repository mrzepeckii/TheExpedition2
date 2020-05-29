using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheExpedition2
{
    public partial class Form1 : Form
    {
        private Game game;
        Dictionary<string, PictureBox> weaponPicture;
        private Random random = new Random();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 402, 155));
            game.NewLevel(random);
            weaponPicture = new Dictionary<string, PictureBox>()
            {
                {"Sword", pictureEqupSword },
                {"Bow", pictureEqupBow },
                {"Mace", pictureEqupMace },
                {"RedPotion", pictureExupRP },
                {"BluePotion", pictureExupBP }
            };
            UpdateCharacters();
        }

        private void UpdateCharacters()
        {
            picturePlayer.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();

            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;
            batHitPoints.Visible = false;
            ghostHitPoints.Visible = false;
            ghoulHitPoints.Visible = false;

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    pictureBat.Location = enemy.Location;
                    batHitPoints.Visible = true;
                    pictureBat.Visible = true;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (!enemy.Dead)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghost)
                {
                    pictureGhost.Location = enemy.Location;
                    ghostHitPoints.Visible = true;
                    pictureGhost.Visible = true;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();
                    if (!enemy.Dead)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghoul)
                {
                    pictureGhul.Location = enemy.Location;
                    ghoulHitPoints.Visible = true;
                    pictureGhul.Visible = true;
                    ghoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (!enemy.Dead)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }
            if (showBat == false)
                pictureBat.Visible = false;
            if (showGhost == false)
                pictureGhost.Visible = false;
            if (showGhoul == false)
                pictureGhul.Visible = false;

            pictureSword.Visible = false;
            pictureBow.Visible = false;
            pictureMace.Visible = false;
            pictureRedPot.Visible = false;
            pictureBluePot.Visible = false;

            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = pictureSword;
                    break;
                case "Bow":
                    weaponControl = pictureBow;
                    break;
                case "Mace":
                    weaponControl = pictureMace;
                    break;
                case "RedPotion":
                    weaponControl = pictureRedPot;
                    break;
                case "BluePotion":
                    weaponControl = pictureBluePot;
                    break;
                default:
                    break;
            }
            weaponControl.Visible = true;
            foreach (string weaponInEquip in weaponPicture.Keys)
            {
                if (game.CheckPlayerInventory(weaponInEquip))
                    weaponPicture[weaponInEquip].Visible = true;
                else
                    weaponPicture[weaponInEquip].Visible = false;
            }

            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
                weaponControl.Visible = false;
            else
                weaponControl.Visible = true;
            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("You are dead! Do you want to repat " + game.Level +" level?", "End game", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.No)
                    Application.Exit();
                else
                {
                    game.WantToRepeat = true;
                    game.IncreasePlayerHealth(10, random);
                    //game = new Game(new Rectangle(78, 57, 402, 155));
                    game.NewLevel(random);
                    UpdateCharacters();
                }
                    
            }
            if (enemiesShown < 1)
            {
                MessageBox.Show("Go to next level!");
                game.NewLevel(random);
                UpdateCharacters();
            }
        }

        private void UpdateWeaponBorder(string weapon)
        {
            foreach (string weaponInEquip in weaponPicture.Keys)
                if (weaponInEquip == weapon)
                    weaponPicture[weaponInEquip].BorderStyle = BorderStyle.Fixed3D;
                else
                    weaponPicture[weaponInEquip].BorderStyle = BorderStyle.None;
        }

        private void EquipWeapon(string weapon)
        {
            string nameOfWeapon = weapon;
            if (!game.CheckPlayerInventory(nameOfWeapon))
                return;
            game.Equip(nameOfWeapon);
            UpdateWeaponBorder(nameOfWeapon);
        }

        private void pictureEqupSword_Click(object sender, EventArgs e)
        {
            EquipWeapon("Sword");
        }

        private void pictureEqupBow_Click(object sender, EventArgs e)
        {
            EquipWeapon("Bow");
        }

        private void pictureEqupMace_Click(object sender, EventArgs e)
        {
            EquipWeapon("Mace");
        }

        private void pictureExupBP_Click(object sender, EventArgs e)
        {
            EquipWeapon("BluePotion");
        }

        private void pictureExupRP_Click(object sender, EventArgs e)
        {
            EquipWeapon("RedPotioin");
        }

        private void buttonMoveUp_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void buttonMoveDown_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void buttonMoveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void buttonMoveRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void buttonAttackUp_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void buttonAttackDown_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

        private void buttonAttackLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }

        private void buttonAttackRight_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }
    }
}
