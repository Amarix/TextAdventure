using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine;

namespace TextAdventure_AllieBeckman
{
    // sets what to display at each location
    class LocationDisplay
    {
        public System.Drawing.Image Image;
        public int ID;

        public LocationDisplay(Location currentLocatoin)
        {
            // get the ID of the current location
            ID = currentLocatoin.getID() - 1;
        } 

        public int getID()
        {
            return ID;
        }

        // a method to take the ID and use it to select the corrisponding background image
        public System.Drawing.Image getBackgroundImage()
        {
            // an array of images
            System.Drawing.Image[] backgroundImage = new System.Drawing.Image[14];
            backgroundImage[0] = TextAdventure_AllieBeckman.Properties.Resources.livingRoom;
            backgroundImage[1] = TextAdventure_AllieBeckman.Properties.Resources.bedRoom;
            backgroundImage[2] = TextAdventure_AllieBeckman.Properties.Resources.windowRoom;
            backgroundImage[3] = TextAdventure_AllieBeckman.Properties.Resources.field;
            backgroundImage[4] = TextAdventure_AllieBeckman.Properties.Resources.shed;
            backgroundImage[5] = TextAdventure_AllieBeckman.Properties.Resources.well;
            backgroundImage[6] = TextAdventure_AllieBeckman.Properties.Resources.caveEntrance;
            backgroundImage[7] = TextAdventure_AllieBeckman.Properties.Resources.roomOne;
            backgroundImage[8] = TextAdventure_AllieBeckman.Properties.Resources.caveIn;
            backgroundImage[9] = TextAdventure_AllieBeckman.Properties.Resources.lockedDoorTwo;
            backgroundImage[10] = TextAdventure_AllieBeckman.Properties.Resources.roomTwo;
            backgroundImage[11] = TextAdventure_AllieBeckman.Properties.Resources.wall;
            backgroundImage[12] = TextAdventure_AllieBeckman.Properties.Resources.field2;
            backgroundImage[13] = TextAdventure_AllieBeckman.Properties.Resources.field3;
            // return current room image
            Image = backgroundImage[ID];

            return Image;
        } 
    }
}
