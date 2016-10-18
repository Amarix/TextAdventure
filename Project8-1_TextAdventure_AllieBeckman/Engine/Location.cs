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

        public Location(int id, string name, string discription)
        {
            ID = id;
            Name = name;
            Discription = discription;
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
    }
}
