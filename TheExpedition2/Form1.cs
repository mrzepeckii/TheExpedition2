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
