using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    // a class to define magic
    public class Magic
    {
        int Damage;
        string Type;
        int Mana;

        public Magic(string type)
        {
            type.ToLower();

            if (type == "fire")
            {
                Damage = 3;
                Mana = 1;
                Type = "fire";
            } else if (type == "ice")
            {
                Damage = 1;
                Mana = 1;
                Type = "ice";
            } else if (type == "lightning")
            {
                Damage = 4;
                Mana = 2;
                Type = "lightning";
            }else if (type == "rock")
            {
                Damage = 10;
                Mana = 5;
                type = "rock";
            }
        }

        public int getDamage()
        {
            return Damage;
        }

        public int getMana()
        {
            return Mana;
        }
        
        public string getType()
        {
            return Type;
        }
    }
}
