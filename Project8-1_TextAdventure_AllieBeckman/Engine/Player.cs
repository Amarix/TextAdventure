using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    // a class defining the player
    public class Player : LivingThing
    {
        public Location CurrentLocation { get; set; }
        public int Mana { get; set; }
        public int TotalMana { get; set; }
        public int ExperiencePts { get; set; }
        public int Level { get; set; }
        public int Damage { get; set; }
        public int BaseDamage { get; set; }
        public string Name { get; set; }

        public Player(string name, int health, int currentHealth, int totalMana, int mana, int exp, int level, int damage)
        {
            CurrentHealth = currentHealth;
            TotalHealth = health;
            Mana = mana;
            TotalMana = totalMana;
            ExperiencePts = exp;
            Level = level;
            Damage = damage;
            BaseDamage = damage;
            Name = name;
        }

        public int getBaseDamage()
        {
            return BaseDamage;
        }

        public string getName()
        {
            return Name;
        }

        public int getMana()
        {
            return Mana;
        }

        public int getTotalMana()
        {
            return TotalMana;
        }

        public int getCurrentHealth()
        {
            return CurrentHealth;
        }
        
        public int getTotalHealth()
        {
            return TotalHealth;
        }

        public int getLevel()
        {
            return Level;
        }

        public int getExpPts()
        {
            return ExperiencePts;
        }

        public int getDamage()
        {
            return Damage;
        }


    }
}
