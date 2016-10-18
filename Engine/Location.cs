using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    // a class to define location
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public int Item { get; set; }

        public Location(int id, string name, string discription, int item)
        {
            ID = id;
            Name = name;
            Discription = discription;
            Item = item;
        }

        // returns the int ID
        public int getID()
        {
            return ID;
        }

        // returns the string name
        public string getName()
        {
            return Name;
        }

        // returns string discription
        public string getDiscription()
        {
            return Discription;
        }

        // returns item number/type
        public int getItem()
        {
            return Item;
        }

        // leaves an item at this location
        public void setItem(int item)
        {
            Item = item;
        }

        // once an item is picked up it no longer exists in the room
        public void itemObtained()
        {
            Item = 0;
        }
    }
}
