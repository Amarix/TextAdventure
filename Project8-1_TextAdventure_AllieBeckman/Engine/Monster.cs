using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    // a class to define monsters
    public class Monster : LivingThing
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int MinDamage { get; set; }
        public int RewardExp { get; set; }
        public int Attack { get; set; }
        public string monsterMissed { get; set; }

        public Monster(int currentHealth, int totalHealth, int id, string name, int maxDam, int rewardExp)
        {
            CurrentHealth = currentHealth;
            TotalHealth = totalHealth;
            ID = id;
            Name = name;
            MaximumDamage = maxDam;
            MinDamage = maxDam - 2;
            RewardExp = rewardExp;
        }

        public int getHealth()
        {
            return CurrentHealth;
        }

        public string getName()
        {
            return Name;
        }

        public int getReward()
        {
            return RewardExp;
        }

        public int getID()
        {
            return ID;
        }

        public int getMaxDamage()
        {
            return MaximumDamage;
        }

        public int getAttack()
        {
            Random r = new Random();
            Attack = r.Next(MinDamage, MaximumDamage);
            return Attack;
        }

        public string missed()
        {
            monsterMissed = "The " + Name + " missed you!";
            return monsterMissed;
        }
    }
}
