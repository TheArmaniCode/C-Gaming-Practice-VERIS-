using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuInterface
{
    class Enemy
    {
        public string name { get; set; }
        public int maxHealth { get; set; }
        public int currentHealth;
        public int meleeAttack { get; set; }
        public int meleeDefence { get; set; }
        public int rangedAttack { get; set; }
        public int rangedDefence { get; set; }
        public int movementSpeed { get; set; }
        public int attackSpeed { get; set; }
        public string weakness { get; set; }
        public string resistance { get; set; }
        public int exp { get; set; }
        public int money { get; set; }
        public string item { get; set; }
        public double dropChance { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{name} {exp}";
            }
        }

        public void CalculateRanged(int pRangedAttack, string element)
        {
            int damage = pRangedAttack - rangedDefence;
            CalculateWeakness(damage, element, weakness, resistance);

            currentHealth -= damage;
        }

        public void CalculateMelee (int pMeleeAttack, string element)
        {
            int damage = pMeleeAttack - meleeDefence;
            CalculateWeakness(damage, element, weakness, resistance);

            currentHealth -= damage;
        }

        public void CalculateWeakness (int damage, string element, string weakness, string resistance)
        {
            if (element == weakness)
            {
                damage *= 2;
            }
            else if (element == resistance)
            {
                damage /= 2;
            }
        }
    }
}
