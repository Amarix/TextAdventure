using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace TextAdventure_AllieBeckman
{
    
    // main game adventure class
    public partial class Adventure : Form
    {
        // an array of player options
        private Player[] players = new Player[3];
        // initalize new player
        private Player _player;
        // initalize new location
        private Location currentLocation;
        // array of game locations
        private Location[,] gameMap = new Location[5, 7];
        // ints to navigate through 2D array
        private int x;
        private int y;
        // array of monsters
        private Monster[] monsters = new Monster[3];
        // monster refrence after random monster is chosen from the array
        private Monster monsterOne;
        // a boolean to tell if a monster is present
        bool isMonster;
        // an array of monster images to display when a monster is present
        Image[] monsterImage = new Image[4];
        // magic object
        private Magic magic;
        // an int to determine that monsters in room have been killed and
        // player can move forward
        int monstKilled;
        // directions form
        Directions directions = new Directions();
        // set temp char choice and an index to count through if
        // user presses next
        int selectionIndex;
        // int of item in room
        // 1 = health pot, 2 = mana pot, 3 = key
        int itemNumber;
        //keytruefalse
        bool hasKey;
        bool doorIsOpen;
        // an array of useful items
        Item[] item = new Item[6];
        // to check how many monsters have been killed
        int monsterKillCount;

        // invatory count
        int hpPot;
        int mpPot;
        int key;
        string stone;

        public Adventure()
        {
            InitializeComponent();
            // array of game locations
            gameMap[0, 0] = new Location(2, "Bed", "The bed where you sleep.", 0);
            gameMap[0, 1] = new Location(1, "Home", "This is your home.", 5);
            gameMap[0, 2] = new Location(3, "Window", "You see your field outside.", 6);
            gameMap[1, 0] = new Location(6, "Well", "The well water is refreshing.", 1);
            gameMap[1, 1] = new Location(4, "Field", "A field in front of your house.", 4);
            gameMap[1, 2] = new Location(5, "Shed", "A place to keep your weapons.", 0);
            gameMap[2, 0] = new Location(13, "Field", "Nothing this way.", 0);
            gameMap[2, 1] = new Location(7, "Dungeon Entrance", "You can hear something coming from the cave.", 0);
            gameMap[2, 2] = new Location(14, "Field", "Nothing this way.", 0);
            gameMap[3, 0] = new Location(9, "Blocked Path", "There has been a cave in here.", 0);
            gameMap[3, 1] = new Location(8, "Dungeon Room", "You can see the exit from here.", 0);
            gameMap[3, 2] = new Location(10, "Locked Door", "A locked door", 0);
            gameMap[3, 3] = new Location(15, "Dungeon Stairs", "Go down the stairs?", 0);
            gameMap[3, 4] = new Location(16, "Basement", "It's dark and cold here", 0);
            gameMap[3, 5] = new Location(17, "Basement Hall", "Theres a small light ahead,", 2);
            gameMap[3, 6] = new Location(18, "Dungeon Center", "There are so many hallways connecting here!", 0);
            gameMap[4, 0] = new Location(12, "Wall", "Nothing this way.", 0);
            gameMap[4, 1] = new Location(11, "Treasure Room", "There is a treasure box here.", 0);
            gameMap[4, 2] = new Location(12, "Wall", "Nothing this way.", 3);

            // set current location for game start
            currentLocation = gameMap[0, 1];

            // an array of monster images to display when monsters appear
            monsterImage[0] = TextAdventure_AllieBeckman.Properties.Resources.imp;
            monsterImage[1] = TextAdventure_AllieBeckman.Properties.Resources.goblin;
            monsterImage[2] = TextAdventure_AllieBeckman.Properties.Resources.troll;
            monsterImage[3] = TextAdventure_AllieBeckman.Properties.Resources.demon;

            // set currentLocation array index ints
            x = 0;
            y = 1;
            selectionIndex = 0;

            // an array of items for this game
            item[0] = new Item(1, "Health Potion", "A potion to restore health.");
            item[1] = new Item(2, "Mana Potion", "A potion to restore mana.");
            item[2] = new Item(3, "Key", "A metal object used to unlock doors.");
            item[3] = new Item(4, "Stone of Strength", "A small stone in the shape of a sword. You feel stronger when you hold it.");
            item[4] = new Item(5, "Stone of Magic", "A small blue stone. You feel magical energy flowing from it.");
            item[5] = new Item(6, "Stone of Protection", "A small stone with a shield carved into it. You feel more alive holding it.");

            // display current location to screen
            gameDisplay(currentLocation);

            // monster is not present right away
            isMonster = false;
            // monster isn't killed yet
            monstKilled = 0;
            //number of monsters killed
            monsterKillCount = 0;

            // set players auto magic and weapon choice
            magic = new Magic("fire");

            // show directions
            directions.Show();

            // make the enter button on the keyboard click the enter button on my screen
            this.AcceptButton = enterButton;

            // first choice of char
            characterChoice();

            // starting out you do not have a key
            hasKey = false;
            doorIsOpen = false;
        }


        private void enterButton_Click(object sender, EventArgs e)
        {
            // get current command to lower case
            string cmd = commandTextBox.Text.ToLower();

            // if player tries to use sleep command use sleep method to
            // make sure player is in bedroom
            if (cmd == "sleep")
            {
                sleep();
            }

            if (cmd == "north"|| cmd == "south"|| cmd == "east"|| cmd == "west")
            {
                // call the navigate method
                navigate();
            }

            if (cmd == "look")
            {
                // call the method to search for an item
                lookAround();
            }

            if (cmd == "inventory" || cmd == "inv")
            {
                invHP.Text = hpPot.ToString();
                invMP.Text = mpPot.ToString();
                invKeys.Text = key.ToString();
                stoneHolding.Text = stone;
                inventory();
            }

            if (cmd == "take")
            {
                take();
            }

            if (cmd == "drop")
            {
                drop();
            }

            if (cmd == "open")
            {
                openDoor();
            }

            if (cmd == "score")
            {
                killScore();
            }

            if (cmd == "quit")
            {
                this.Close();
            }

            commandTextBox.SelectAll();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // close form
            this.Close();
        }

        private void backgroundPicture_Click(object sender, EventArgs e)
        {
            // not used
        }

        private void magicButton_Click(object sender, EventArgs e)
        {
            playerMagicAttack();
        }



// if any of the spell buttons are selected in the shed ---- >
        private void fireSpellBtn_Click(object sender, EventArgs e)
        {
            // set magic stats for fire spell
            magic = new Magic("fire");
            // set spell icon to fire icon
            spellIcon.BackgroundImage = TextAdventure_AllieBeckman.Properties.Resources.fire;
        }

        private void iceSpellBtn_Click(object sender, EventArgs e)
        {
            // set magic stats for ice spell
            magic = new Magic("ice");
            // set spell icon to ice icon
            spellIcon.BackgroundImage = TextAdventure_AllieBeckman.Properties.Resources.ice;
        }

        private void lightningSpellBtn_Click(object sender, EventArgs e)
        {
            // set magic stats for lightning spell
            magic = new Magic("lightning");
            // set spell icon to lightning icon
            spellIcon.BackgroundImage = TextAdventure_AllieBeckman.Properties.Resources.lightning;
        }

        private void rockSpellBtn_Click(object sender, EventArgs e)
        {
            // set magic stats for rock spell
            magic = new Magic("rock");
            // set spell icon to rock icon
            spellIcon.BackgroundImage = TextAdventure_AllieBeckman.Properties.Resources.rock;
        }
// end of spell options/ buttons <-----------



// use potions buttons ---->
        private void healthPotBtn_Click(object sender, EventArgs e)
        {
            useHealthPot();
        }

        private void manaPotBtn_Click(object sender, EventArgs e)
        {
            useManaPot();
        }
// end of use potions buttons <-----



// start of buy potions buttons --->
        private void buyManaBtn_Click(object sender, EventArgs e)
        {
            // first find out if you can afford it with exp
            int exp = _player.ExperiencePts;

            // find out how many pts you already have
            int currentPots = int.Parse(manaPotCnt.Text.ToString());

            // if you can afford it buy one.
            if(exp >= 2)
            {
                // add a new potion to your potions
                mpPot = mpPot + 1;
                manaPotCnt.Text = mpPot.ToString();

                // subtract the exp cost from players exp
                _player.ExperiencePts = _player.ExperiencePts - 2;

                // run the level system to re determine level
                levelSystem();
            }
        }

        private void buyHealthBtn_Click(object sender, EventArgs e)
        {
            // first find out if you can afford it with exp
            int exp = _player.ExperiencePts;

            // find out how many pts you already have
            int currentPots = int.Parse(healthPotCnt.Text.ToString());

            // if you can afford it buy one.
            if (exp >= 2)
            {
                // add a new potion to your potions
                hpPot = hpPot + 1;
                healthPotCnt.Text = hpPot.ToString();

                // subtract the exp cost from players exp
                _player.ExperiencePts = _player.ExperiencePts - 2;

                // run the level system to re determine level
                levelSystem();
            }
        }
//End of potion purchases ---------->>>>>>>



// to re-Open directions
        private void directionsBtn_Click(object sender, EventArgs e)
        {
            Directions directions = new Directions();
            directions.Show();
            directions.BringToFront();
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            // call att method
            playerAttack();
        }

        private void swordBtn_Click(object sender, EventArgs e)
        {
            if (lblWeapon.Text != "Wood Sword")
            {
                // add sword damage to player damage
                _player.Damage = 2;

                // update weapon label
                lblWeapon.Text = "Wood Sword";
            }
            else
            {
                _player.Damage = _player.BaseDamage;
                // update weapon label
                lblWeapon.Text = "None";
            }
        }

        private void axeBtn_Click(object sender, EventArgs e)
        {
            if (lblWeapon.Text != "Axe")
            {
                // add sword damage to player damage
                _player.Damage = 3;

                // update weapon label
                lblWeapon.Text = "Axe";
            }
            else
            {
                _player.Damage = _player.BaseDamage;
                // update weapon label
                lblWeapon.Text = "None";
            }
        }

        private void steelSwordBtn_Click(object sender, EventArgs e)
        {
            if (lblWeapon.Text != "Steel Sword")
            {
                // add sword damage to player damage
                _player.Damage = 5;

                // update weapon label
                lblWeapon.Text = "Steel Sword";
            }else
            {
                _player.Damage = _player.BaseDamage;
                // update weapon label
                lblWeapon.Text = "None";
            }
            
        }


        //PLAYER STATS DISPLAY
        // a method to display the players stats
        public void playerStats(Player player)
        {
            // display stats on window
            lblHealth.Text = _player.CurrentHealth.ToString();
            lblMana.Text = _player.Mana.ToString();
            lblExp.Text = _player.ExperiencePts.ToString();
            lblLevel.Text = _player.Level.ToString();
            lblCrntExp.Text = _player.ExperiencePts.ToString();
        }

        //ATTACK METHODS ---->>>>
        // magic attack
        public void playerMagicAttack()
        {
            // check for mana to use spell
            int currentMana = _player.getMana();

            // get type of spell being used
            string spellType = magic.getType();

            // get mana cost of type
            int spellCost = magic.getMana();

            // get spell types damage
            int spellDamage = magic.getDamage();

            // get current monsters health
            int monstHealth = monsterOne.getHealth();

            // if player can afford the spell
            if (currentMana > spellCost)
            {
                // spell does damange
                monsterOne.CurrentHealth = (monsterOne.CurrentHealth) - spellDamage;

                // player loses mana
                _player.Mana = (_player.Mana) - spellCost;
                // display new ammount of mana
                lblMana.Text = _player.Mana.ToString();

                // display the damage done on the monster
                warningLabel.Text = "A monster appears!"
                    + "\n Name: " + monsterOne.getName()
                    + "\n Health: " + monsterOne.CurrentHealth;

                // if monster dies
                if (monsterOne.CurrentHealth <= 0)
                {
                    // monster kill count up
                    monsterKillCount++;
                    // make monster image dissapear
                    monsterPictureBox.Visible = false;
                    // get exp points for monster
                    _player.ExperiencePts = _player.ExperiencePts + monsterOne.getReward();
                    // attack buttons disable
                    battlePanel.Enabled = false;
                    // monster is no longer present
                    isMonster = false;
                    // make monster stats dissappear
                    warningLabel.Text = "Congrats the monster is dead." +
                        "\n You recieve " + monsterOne.getReward() + " exp points.";
                    monstKilled = 1;

                    // can move monster is dead
                    enterButton.Enabled = true;

                    // add the exp and lvl up if possible using this method
                    levelSystem();
                }
                else
                {
                    // if monster does not die it attacks using attack method
                    monsterAttack();
                }
            }
        }

        // melee attack
        public void playerAttack()
        {
            // clear the monsters previous attack
            monstAttlbl.Text = "";

            // get monster health
            int monstHealth = monsterOne.getHealth();

            // get player att damage
            int plrAtt = _player.getDamage();

            // deal damage and calculate monsters new health
            monstHealth = monstHealth - plrAtt;
            monsterOne.CurrentHealth = monstHealth;

            // check if monster died
            if (monstHealth <= 0)
            {
                // monster kill count up
                monsterKillCount++;
                // make monster image dissapear
                monsterPictureBox.Visible = false;
                // get exp points for monster
                _player.ExperiencePts = _player.ExperiencePts + monsterOne.getReward();
                // attack buttons disable
                battlePanel.Enabled = false;
                // monster is no longer present
                isMonster = false;
                // make monster stats dissappear
                warningLabel.Text = "Congrats the monster is dead." +
                    "\n You recieve " + monsterOne.getReward() + " exp points.";
                monstKilled = 1;

                // can move monster is dead
                enterButton.Enabled = true;

                // add the exp and lvl up if possible using this method
                levelSystem();
            }
            else
            {
                // show monsters new health
                warningLabel.Text = "A monster appears!"
                        + "\n Name: " + monsterOne.getName()
                        + "\n Health: " + monsterOne.CurrentHealth;

                // if monster does not die it attacks
                monsterAttack();
            }
        }

        // monster attack method this can only be called after a monster
        // has been assigned to monsterOne
        public void monsterAttack()
        {
            // get the monsters attack
            int attack = monsterOne.getAttack();

            if (attack <= 0)
            {
                // the monster did no damage so it missed
                string missed = monsterOne.missed();
                monstAttlbl.Text = missed;
            }
            else
            {
                // get players health
                int plrHealth = _player.CurrentHealth;

                // take damage
                plrHealth = plrHealth - attack;

                // display amount of damage
                monstAttlbl.Text = monsterOne.getName() + " attacked and did " + attack + " damage.";

                // make sure player isn't out of health
                if (plrHealth <= 0)
                {
                    // call game over
                    gameOver();
                }
                else
                {
                    // if player has remaining health return new current health
                    _player.CurrentHealth = plrHealth;
                    // display new health to stat bar
                    lblHealth.Text = _player.CurrentHealth.ToString();
                }
            }
        }
        //ATTACK METHODS END ------>>>>>>>


        //EQUIPMENT / SHOP ITEM SELECTION METHOD
        public void equipmentShed()
        {
            // check if you're in the right location
            if (x == 1 && y == 2)
            {
                equipsPanel.Visible = true;
                equipsPanel.Enabled = true;

                // check char level for equip options
                if (_player.Level < 2)
                {
                    // only some equips available base options
                    // are pre set in design

                }
                else if (_player.Level < 5)
                {
                    // open next available weapons and spells
                    lightningSpellBtn.Enabled = true;
                    axeBtn.Enabled = true;
                }
                else
                {
                    // open next available weapons and spells
                    lightningSpellBtn.Enabled = true;
                    rockSpellBtn.Enabled = true;
                    axeBtn.Enabled = true;
                    steelSwordBtn.Enabled = true;

                }
            }
            else
            {
                equipsPanel.Visible = false;
                equipsPanel.Enabled = false;
            }
        }

        //LEVEL AND EXP SYSTEM METHOD
        // a method to calculate level and exp when exp is earned
        public void levelSystem()
        {
            //calculate how much exp it will take to level up
            int expForNxtLvl = _player.Level * 10;

            // how much exp do you need to reach the next level
            int expToNxtLvl = expForNxtLvl - _player.ExperiencePts;
            lblExp.Text = expToNxtLvl.ToString();
            lblCrntExp.Text = _player.ExperiencePts.ToString();

            if (expForNxtLvl <= _player.ExperiencePts)
            {
                // take exp to lvl up and add a lvl
                _player.ExperiencePts = _player.ExperiencePts - expForNxtLvl;
                _player.Level = _player.Level + 1;

                //re-calculate how much exp it will take to level up
                expForNxtLvl = _player.Level * 10;

                // re-calculate how much exp do you need to reach the next level
                expToNxtLvl = expForNxtLvl - _player.ExperiencePts;

                // display new exp current/expToNxtLvl/ and new lvl
                lblExp.Text = expToNxtLvl.ToString();
                lblLevel.Text = _player.Level.ToString();
                lblCrntExp.Text = _player.ExperiencePts.ToString();

                // refill players health and mana and add 5 health and 5 mana to the total
                _player.TotalHealth = _player.TotalHealth + 5;
                _player.TotalMana = _player.TotalMana + 5;

                _player.Mana = _player.TotalMana;
                _player.CurrentHealth = _player.TotalHealth;

                // display refreshed health and mana stats
                lblHealth.Text = _player.CurrentHealth.ToString();
                lblMana.Text = _player.Mana.ToString();
            }

        }

        public void killScore()
        {
            warningLabel.Text = "You have killed a total of " + monsterKillCount + " monsters!";
        }

        public void inventory()
        {
            inventoryPanel.Visible = true;
        }

        //ROOMS WHERE MONSTER APPEARS METHOD
        // if monster appears
        public void monsterRoom()
        {
            // get room ID to decide if room is a room with
            // a monster in it
            int i = currentLocation.getID();

            // current rooms where random monsters spawn are first room
            // room with cave in
            // and treasure room.
            if (i == 8 && monstKilled == 0 ||
                i == 9 && monstKilled == 0||
                i == 11 && monstKilled == 0||
                i == 17 && monstKilled == 0||
                i == 16 && monstKilled == 0)
            {
                // array of monsters
                monsters[0] = new Monster(5, 5, 2, "Imp", 2, 2);
                monsters[1] = new Monster(10, 10, 1, "Goblin", 3, 3);
                monsters[2] = new Monster(15, 15, 3, "Troll", 5, 5);

                // use a random int to choos a random monster
                // using the random int as the index in the monster array.
                Random r = new Random();
                int monsterIndex = r.Next(0, 3);

                // define new monster
                monsterOne = monsters[monsterIndex];

                // monster is present
                isMonster = true;

                // cant leave until the monster is dead
                enterButton.Enabled = false;

                // display monster stats
                warningLabel.Text = "A monster appears!"
                    + "\n Name: " + monsterOne.getName()
                    + "\n Health: " + monsterOne.CurrentHealth;

                // display monster image
                monsterPictureBox.BackgroundImage = monsterImage[monsterIndex];
                monsterPictureBox.Visible = true;

                // battle panel with attack button etc. active
                battlePanel.Enabled = true;
            }
            else if (i == 18 && monstKilled == 0)
            {
                Monster boss = new Monster(100, 100, 4, "Demon", 10, 50);
                // define new monster
                monsterOne = boss;

                // monster is present
                isMonster = true;

                // cant leave until the monster is dead
                enterButton.Enabled = false;

                // display monster stats
                warningLabel.Text = "This one is HUGE!"
                    + "\n Name: " + monsterOne.getName()
                    + "\n Health: " + monsterOne.CurrentHealth;
                // display monster image
                monsterPictureBox.BackgroundImage = monsterImage[3];
                monsterPictureBox.Visible = true;

                // battle panel with attack button etc. active
                battlePanel.Enabled = true;
            }
            else
            {
                warningLabel.Text = "";
            }
        }

        //SCREEN LOCATION DISPLAY METHOD
        // a method to change the location image name and discription
        public void gameDisplay(Location currentLocation)
        {
            LocationDisplay displayCurrent = new LocationDisplay(currentLocation);

            // display location image name and discription
            backgroundPicture.BackgroundImage = displayCurrent.getBackgroundImage();
            discriptionLabel.Text = currentLocation.getDiscription();
            nameLabel.Text = currentLocation.getName();
        }

        //NAVIGATION METHOD (USES OTHER METHODS)
        // a method to hold all directional methods
        public void navigate()
        {
            // take the command string add it to lowercase
            string command = commandTextBox.Text.ToLower();

            // check for monsters
            monsterRoom();

            // can't change rooms if monster is present
            if (isMonster == false)
            {
                monstAttlbl.Text = "";
                // if user types in north
                if (command == "north")
                {
                    // call move north method
                    moveNorth();

                    // display the new location
                    gameDisplay(currentLocation);
                }
                // if user types in south
                else if (command == "south")
                {
                    // call move south method
                    moveSouth();

                    // display the new location
                    gameDisplay(currentLocation);
                }
                // if user types east
                else if (command == "east")
                {
                    // call move east method
                    moveEast();

                    // display new location
                    gameDisplay(currentLocation);
                }
                // if user types west
                else if (command == "west")
                {
                    // call move west method
                    moveWest();

                    // display new location
                    gameDisplay(currentLocation);
                }
            }

            // is this the shed room?
            equipmentShed();

            // once you leave room with monsters if you come back to this room
            // monsters will respawn
            monstKilled = 0;

            // if player is in the bedroom
            int roomID = currentLocation.getID();
            if(roomID == 2)
            {
                warningLabel.Text = "Maybe you should rest for a while.";
            }
        }

        //NORTH METHOD
        public Location moveNorth()
        {
            // if statement to make sure you don't go further than
            // the array limits
            if (x < 4 && y == 1)
            {
                // x was set to the first original location
                // add to it
                x++;
                // make the current location the new location
                // with the new x value as the first index
                Location newLocation = gameMap[x, y];
                currentLocation = newLocation;

                // take away the warning if it's there
                warningLabel.Text = "";
            }
            else
            {
                // cannot go further/ map ends
                warningLabel.Text = "cannot move any further";
            }

            // return new location
            return currentLocation;
        }

        //SOUTH METHOD
        public Location moveSouth()
        {
            // if statement to make sure you don't go further than
            // the array limits
            if (x > 0 && y == 1)
            {
                // x was set to the first original location
                // add to it
                x--;
                // make the current location the new location
                // with the new x value as the first index
                Location newLocation = gameMap[x, y];
                currentLocation = newLocation;
                // take away the warning if it's there
                warningLabel.Text = "";
            }
            else
            {
                // cannot go further/ map ends
                warningLabel.Text = "cannot move any further";
            }

            // return new location
            return currentLocation;
        }

        //EAST METHOD
        public Location moveEast()
        {
            // if statement to make sure you don't go further than
            // the array limits
            if (y > 0)
            {
                // y was set to the first original location
                // add to it
                y--;
                // make the current location the new location
                // with the new y value as the first index
                Location newLocation = gameMap[x, y];
                currentLocation = newLocation;
                // take away the warning if it's there
                warningLabel.Text = "";
            }
            else
            {
                // cannot go further/ map ends
                warningLabel.Text = "cannot move any further";
            }

            // return new location
            return currentLocation;
        }

        //WEST METHOD
        public Location moveWest()
        {
            // if statement to make sure you don't go further than
            // the array limits the dungeon is longer at row 3
            if (x == 3 && hasKey && doorIsOpen)
            {
                if (y < 6)
                {
                    // y was set to the first original location
                    // add to it
                    y++;
                    // make the current location the new location
                    // with the new y value as the first index
                    Location newLocation = gameMap[x, y];
                    currentLocation = newLocation;
                    // take away the warning if it's there
                    warningLabel.Text = "";
                }
                else
                {
                    // cannot go further/ map ends
                    warningLabel.Text = "cannot move any further";
                }
            }
            else
            {

                if (y < 2)
                {
                    // y was set to the first original location
                    // add to it
                    y++;
                    // make the current location the new location
                    // with the new y value as the first index
                    Location newLocation = gameMap[x, y];
                    currentLocation = newLocation;
                    // take away the warning if it's there
                    warningLabel.Text = "";
                }
                else
                {
                    if (x == 3)
                    {
                        warningLabel.Text = "The door is locked";
                    }
                    else
                    {
                        // cannot go further/ map ends
                        warningLabel.Text = "cannot move any further";
                    }
                }
            }
            // return new location
            return currentLocation;
        }

        public void openDoor()
        {
            if (x == 3 && y == 2 && hasKey)
            {
                warningLabel.Text = "You unlocked the door";
                doorIsOpen = true;
            }
        }

        //SLEEP OPTION METHOD
        public void sleep()
        {
            // get current locations ID to find out if it's the bedroom
            int roomID = currentLocation.getID();

            if (roomID == 2)
            {
                // refill players health and mana and display the refills
                _player.CurrentHealth = _player.TotalHealth;
                _player.Mana = _player.TotalMana;

                lblHealth.Text = _player.CurrentHealth.ToString();
                lblMana.Text = _player.Mana.ToString();

                // let player know they slept in warning box
                warningLabel.Text = "You feel well rested.";
            }
        }

        public void useManaPot()
        {

            // if potion available
            if (mpPot >= 1)
            {
                // add to players mana
                _player.Mana = _player.Mana + 3;
                // remove the potion that was used
                mpPot = mpPot - 1;
                manaPotCnt.Text = mpPot.ToString();

                // display players new mana
                lblMana.Text = _player.Mana.ToString();
            }
        }

        public void useHealthPot()
        {
            // if potion available
            if (hpPot >= 1)
            {
                // increase players health
                _player.CurrentHealth = _player.CurrentHealth + 3;
                // remove the potion that was used
                hpPot = hpPot - 1;
                healthPotCnt.Text = hpPot.ToString();

                // display players new mana
                lblHealth.Text = _player.CurrentHealth.ToString();
            }
        }

        // look method used to find items such as potions and or a key in each location
        public void lookAround()
        {
            itemNumber = currentLocation.getItem();

            if (itemNumber == 1)
            {
                warningLabel.Text = "You have found a health potion!";
                hpPot++;
                currentLocation.itemObtained();
            }
            else if (itemNumber == 2)
            {
                warningLabel.Text = "You have found a mana potion!";
                mpPot++;
                currentLocation.itemObtained();
            }
            else if (itemNumber == 3)
            {
                warningLabel.Text = "You spotted a key and put it in your pocket.";
                hasKey = true;
                key++;
                currentLocation.itemObtained();
            }
            else if (itemNumber == 4)
            {
                //thisItem = item[3];
                warningLabel.Text = "Theres an odd stone on the ground.";
            }
            else if (itemNumber == 5)
            {
                //thisItem = item[4];
                warningLabel.Text = "Theres an odd stone on the ground.";
            }
            else if (itemNumber == 6)
            {
                //thisItem = item[5];
                warningLabel.Text = "Theres an odd stone on the ground.";
            }
            else
            {
                warningLabel.Text = "Doesn't look like there's anything around here.";
            }

            healthPotCnt.Text = hpPot.ToString();
            manaPotCnt.Text = mpPot.ToString();
        }

        // take method to pick up an item spotted on the ground. (potions and keys are automatically picked up)
        // stones are not because you can only hold one at a time.
        public void take()
        {
            // if the item on the floor is the stone of strength
            if (currentLocation.getItem() == 4)
            {
                if (stone == "Stone of Strength")
                {
                    warningLabel.Text = "You already have this item.";
                }
                else if (stone == "Stone of Magic")
                {
                    // drop any item you already have
                    swap();

                    // add the stats that the strength stone offers
                    _player.Damage = _player.Damage + 5;
                    stone = "Stone of Strength";
                    warningLabel.Text = item[3].Description;

                }
                else if (stone == "Stone of Protection")
                {
                    swap();

                    _player.Damage = _player.Damage + 5;
                    stone = "Stone of Strength";
                    warningLabel.Text = item[3].Description;

                }
                else
                {
                    _player.Damage = _player.Damage + 5;
                    stone = "Stone of Strength";
                    warningLabel.Text = item[3].Description;

                    currentLocation.setItem(0);
                }
            }
            // if the stone on the ground is a magic stone
            else if (currentLocation.getItem() == 5)
            {
                if (stone == "Stone of Strength")
                {
                    swap();

                    // add the stats that the magic stone offers
                    _player.Mana = _player.Mana + 5;
                    stone = "Stone of Magic";
                    warningLabel.Text = item[4].Description;

                }
                else if (stone == "Stone of Magic")
                {
                    warningLabel.Text = "You already have this item.";
                }
                else if (stone == "Stone of Protection")
                {
                    swap();

                    _player.Mana = _player.Mana + 5;
                    stone = "Stone of Magic";
                    warningLabel.Text = item[4].Description;

                }
                else
                {
                    _player.Mana = _player.Mana + 5;
                    stone = "Stone of Magic";
                    warningLabel.Text = item[4].Description;

                    currentLocation.setItem(0);
                }
            }
            // if the stone on the ground is protection stone
            else if (currentLocation.getItem() == 6)
            {
                // if you already have the stone of strength
                if (stone == "Stone of Strength")
                {
                    swap();

                    // add stats the stone offers
                    _player.CurrentHealth = _player.CurrentHealth + 10;
                    _player.TotalHealth = _player.TotalHealth + 10;
                    stone = "Stone of Protection";
                    warningLabel.Text = item[5].Description;

                }
                // if you already have the stone of magic
                else if (stone == "Stone of Magic")
                {
                    swap();

                    _player.CurrentHealth = _player.CurrentHealth + 10;
                    _player.TotalHealth = _player.TotalHealth + 10;
                    stone = "Stone of Protection";
                    warningLabel.Text = item[5].Description;

                }
                // if you already have the stone of protection
                else if (stone == "Stone of Protection")
                {
                    warningLabel.Text = "You already have this item.";
                }
                // if you don't currently have any stones
                else
                {
                    _player.CurrentHealth = _player.CurrentHealth + 10;
                    _player.TotalHealth = _player.TotalHealth + 10;
                    stone = "Stone of Protection";
                    warningLabel.Text = item[5].Description;

                    currentLocation.setItem(0);
                }
            }
            else
            {
                warningLabel.Text = "There is nothing here to take.";
            }

            lblMana.Text = _player.Mana.ToString();
            lblHealth.Text = _player.CurrentHealth.ToString();
        }

        // drop method is used only if there isn't already something on the floor
        public void drop()
        {
            if (currentLocation.getItem() == 0)
            {
                if (stone == "Stone of Strength")
                {
                    // the stone no longer provides bonus
                    _player.Damage = _player.Damage - 5;
                    // the item is now left at this location
                    currentLocation.setItem(4);
                }
                else if (stone == "Stone of Magic")
                {
                    // the stone no longer provides bonus
                    _player.Mana = _player.Mana - 5;
                    // the item is now left at this location
                    currentLocation.setItem(5);
                }
                else if (stone == "Stone of Protection")
                {
                    // the stone no longer provides bonus
                    _player.CurrentHealth = _player.CurrentHealth - 10;
                    _player.TotalHealth = _player.TotalHealth - 10;
                    // the item is now left at this location
                    currentLocation.setItem(6);
                }
                else
                {
                    warningLabel.Text = "You don't have an item to drop";
                }

                lblMana.Text = _player.Mana.ToString();
                lblHealth.Text = _player.CurrentHealth.ToString();
                warningLabel.Text = "You have dropped the stone here";
                stone = "Nothing";
            }
            else
            {
                warningLabel.Text = "Theres already something on the floor.";
            }
        }

        // this is the same as the drop method without checking if something is already on the floor
        // because it is only called in the take method meaning the user is picking up that item first
        // then dropping the old item.
        public void swap()
        {

            if (stone == "Stone of Strength")
            {
                // the stone no longer provides bonus
                _player.Damage = _player.Damage - 5;
                // the item is now left at this location
                currentLocation.setItem(4);
            }
            else if (stone == "Stone of Magic")
            {
                // the stone no longer provides bonus
                _player.Mana = _player.Mana - 5;
                // the item is now left at this location
                currentLocation.setItem(5);
            }
            else if (stone == "Stone of Protection")
            {
                // the stone no longer provides bonus
                _player.CurrentHealth = _player.CurrentHealth - 10;
                // the item is now left at this location
                currentLocation.setItem(6);
            }
            else
            {
                warningLabel.Text = "You don't have an item to drop";
            }

            lblMana.Text = _player.Mana.ToString();
            lblHealth.Text = _player.CurrentHealth.ToString();
            warningLabel.Text = "You have dropped the stone here";
            stone = "Nothing";

        }

        //GAME OVER METHOD
        public void gameOver()
        {
            // game over message
            warningLabel.Text = "Oh no... "+ "\n You have perished." + "\n Play again?";

            // everything becomes disabled
            battlePanel.Enabled = false;
            enterButton.Enabled = false;
            directionsBtn.Enabled = false;
            exitButton.Enabled = false;
            commandTextBox.Enabled = false;
            statsPanel.Enabled = false;

            // replay or exit button options available
            yesBtn.Visible = true;
            yesBtn.Enabled = true;

            noBtn.Visible = true;
            noBtn.Enabled = true;
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            // restart game
            Application.Restart();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            // close program
            this.Close();
        }

        private void commandTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
        // to select all text without having to use mouse
        private void commandTextBox_Enter(object sender, EventArgs e)
        {
            commandTextBox.SelectAll();
        }

        private void commandTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            commandTextBox.SelectAll();
        }


        // char choice before game starts
        public Player temp;
        public Image tempImage;

        private void characterChoice()
        {
            // initalize the array of options
            PlayerOptions newOptions = new PlayerOptions(selectionIndex);

            // set current player choice stats to screen.
            temp = newOptions.getPlayerChoice();
            tempImage = newOptions.getPlayerImage();
            choicePicBox.BackgroundImage = tempImage;
            lblNameChose.Text = temp.getName();
            lblChoseHealth.Text = temp.getTotalHealth().ToString();
            lblChoseMana.Text = temp.getTotalMana().ToString();
            lblChoseStr.Text = temp.getDamage().ToString();

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            characterChoice();
            if (selectionIndex < 2)
            {
                selectionIndex++;
            }
            else
            {
                selectionIndex = 0;
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            _player = temp;

            // display stats on window using method
            playerStats(_player);
            playerPictureBox.BackgroundImage = tempImage;

            playerSelectionPanel.Enabled = false;
            playerSelectionPanel.Visible = false;
        }

        private void closeInvBtn_Click(object sender, EventArgs e)
        {
            inventoryPanel.Visible = false;
        }
    }
}
