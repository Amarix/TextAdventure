using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    // a class to define items
    public class Item
    {
        public int ID;
        public string Name;
        public string Description;

        public Item(int id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
        }

        public int getID()
        {
            return ID;
        }

        public string getName()
        {
            return Name;
        }

        public string getDescription()
        {
            return Description;
        }
    }
}
