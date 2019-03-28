using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragonSlayer
{
    public partial class Form1 : Form
    {
        public bool ElixirUsed = false;
        public bool SunderedArmour = false;
        public bool OnFire = false;
        public int SunderedArmourCount = 0;

        Dragon dragon = new Dragon(1000, 100, 200);
        Player player = new Player(500, 100, 250);


        public Form1()
        {
            MessageBox.Show("github test");
            MessageBox.Show("github test2");
            MessageBox.Show("Github test 3");
            MessageBox.Show("Github test 4");
            InitializeComponent();
        }

        public bool getOnFire()
        {
            return OnFire;
        }

        public int getSunderedArmourCount() {

            return SunderedArmourCount;
        }

        public void setOnFire(bool onFire)
        {
            OnFire = onFire;
        }

        public void MainAttack()
        {
            int damageDone = 300 - dragon.getDef();
            dragon.setHP(dragon.getHP() - damageDone);
            MessageBox.Show("You attack the dragon dealing " + damageDone + " damage to the dragon");
            UpdateDragonHP();
            DragonRandomAttack();
        }

        public void Roll()
        {

            MessageBox.Show("You roll in a nearby puddle of mud dousing the flames, you are no longer on fire");
            setOnFire(false);
            TailLash();
        }

        public void checkViolentFlurry()
        {
            if (dragon.getHP() <= 400)
            {
                btnViolentFlurry.Enabled = true;
            }
        }

        public void ViolentFlurry()
        {
            int damageDone = 300;
            dragon.setHP(dragon.getHP() - damageDone);
            MessageBox.Show("You attack the dragon dealing " + damageDone + " damage to the dragon");
            UpdateDragonHP();
            DragonRandomAttack();
        }

        public void UseElixir()
        {
            if (ElixirUsed == false)
            {
                player.setHP(player.getHP() + 200);
                player.setDef(100);
                MessageBox.Show("You use your elixir restoring 200 health and restoring your defence to its default value");
                ElixirUsed = true;
                btnUseElixir.Enabled = false;
                UpdatePlayerHP();
                lblArmor.Text = player.getDef().ToString();
                SunderedArmour = false;

            }
        }

        public void DragonRandomAttack()
        {
            int randomNumber;

            Random rand = new Random();
            randomNumber = rand.Next(1, 10);

            switch (randomNumber)
            {
                case 1:
                    StandardAttack();
                    break;
                case 2:
                    StandardAttack();
                    break;
                case 3:
                    StandardAttack();
                    break;
                case 4:
                    DragonBreath();
                    break;
                case 5:
                    DragonBreath();
                    break;
                case 6:
                    DragonBreath();
                    break;
                case 7:
                    TailLash();
                    break;
                case 8:
                    TailLash();
                    break;
                case 9:
                    CannabalizeWhelpling();
                    break;
                case 10:
                    CannabalizeWhelpling();
                    break;
            }
        }


        public void StandardAttack()
        {
            int damageDone = dragon.getAtk() - player.getDef();
            MessageBox.Show("The dragon attacks you with its claws dealing " + damageDone + " damage");
            player.setHP(player.getHP() - damageDone);
            SunderArmor();
            UpdatePlayerHP();
        }

        public void SunderArmor()
        {

            if (SunderedArmour == false)
            {
                MessageBox.Show("Your armour has been sundered by 25, sunder armour can stack up to three times, pay attention to the" +
                    " armour display below");
                SunderedArmour = true;
                player.setDef(player.getDef() - 25);
                lblArmor.Text = player.getDef().ToString();
                SunderedArmourCount += 1;
            }
            else if (SunderedArmourCount >= 1 && SunderedArmourCount < 3)
            {
                player.setDef(player.getDef() - 25);
                lblArmor.Text = player.getDef().ToString();
                SunderedArmourCount += 1;
            }

        }

        public void TailLash()
        {
            int damageDone = dragon.getAtk() - player.getDef() - 50;
            player.setHP(player.getHP() - damageDone);
            MessageBox.Show("The dragon sweeps you with its tail dealing " + damageDone + " ");
            SunderArmor();
            FireDamageTick();
            UpdatePlayerHP();
        }

        public void DragonBreath()
        {
            int damageDone = 100;

            if (OnFire == false)
            {
                OnFire = true;
                player.setHP(player.getHP() - damageDone);
                MessageBox.Show("The dragon spews a great torrent of flame at you dealing 100 damage and setting you on fire");
                MessageBox.Show("Each action you take while you are on fire will deal 50 damage to you, you can put the fire out" +
                    "by using the roll ability");
                UpdatePlayerHP();

            }
            else
            {
                OnFire = true;
                player.setHP(player.getHP() - damageDone);
                MessageBox.Show("The dragon spews a great torrent of flame at you dealing 100 damage and setting you on fire");
                FireDamageTick();
                UpdatePlayerHP();
            }
        }

        public void FireDamageTick()
        {
            if (OnFire == true)
            {
                player.setHP(player.getHP() - 50);
                MessageBox.Show("You have taken 50 additional fire damage as you are on fire");
            }
        }

        public void CannabalizeWhelpling()
        {
            dragon.setHP(dragon.getHP() + 200);
            MessageBox.Show("The dragon eats a nearby whelpling and recovers 200 health");
            UpdateDragonHP();
        }

        public void UpdatePlayerHP()
        {
            checkGameStatus();
            double hpAsDouble = Convert.ToDouble(player.getHP());
            double percentage = hpAsDouble / 500 * 100;
            pnlPlayerHealth.Width = Convert.ToInt32(percentage * 4);
        }

        public void UpdateDragonHP()
        {
            checkGameStatus();
            checkViolentFlurry();
            double hpAsDouble = Convert.ToDouble(dragon.getHP());
            double percentage = hpAsDouble / 1000 * 100;
            pnlDragonHealth.Width = Convert.ToInt32(percentage * 4);


        }

        public void checkGameStatus()
        {
            if(player.getHP() <= 0)
            {
                MessageBox.Show("You have been defeated, game over");
                Application.Exit();
            }
            else if(dragon.getHP() <= 0)
            {
                MessageBox.Show("The dragon has been defeated");
                Application.Exit();

            }
        }

        public void btnAttack_Click(object sender, EventArgs e)
        {
            MainAttack();
        }

        public void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void btnStart_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            pnlGame.Visible = true;
        }

        public void btnRoll_Click(object sender, EventArgs e)
        {
            Roll();
        }

        public void btnUseElixir_Click(object sender, EventArgs e)
        {
            UseElixir();
        }

        public void btnViolentFlurry_Click(object sender, EventArgs e)
        {
            ViolentFlurry();
        }
    }
}
