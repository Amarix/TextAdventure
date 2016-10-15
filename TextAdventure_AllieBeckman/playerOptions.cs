using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine;
using System.Drawing;

namespace TextAdventure_AllieBeckman
{
    class PlayerOptions
    {
        public Player[] playerOptions = new Player[3];
        public Image[] playerImage = new Image[3];
        public Player Player;
        public Image Image;

        public PlayerOptions(int i)
        {
            playerOptions[0] = new Player("Knight", 15, 15, 5, 5, 0, 1, 5);
            playerOptions[1] = new Player("archer", 10, 10, 3, 3, 0, 1, 10);
            playerOptions[2] = new Player("Wizard", 8, 8, 15, 15, 0, 1, 1);

            playerImage[0] = TextAdventure_AllieBeckman.Properties.Resources.knight;
            playerImage[1] = TextAdventure_AllieBeckman.Properties.Resources.archer;
            playerImage[2] = TextAdventure_AllieBeckman.Properties.Resources.wizard;

            Image = playerImage[i];
            Player = playerOptions[i];
        }

        public Player getPlayerChoice()
        {
            return Player;
        }

        public Image getPlayerImage()
        {
            return Image;
        }

    }
}
