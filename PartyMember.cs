using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuInterface
{
    public class PartyMember
    {
        public List<int> stats = new List<int>();
        public List<string> comparison = new List<string>();
        public Weapon equippedWeapon = new Weapon();
        public string name { get; set; }
        public string weapon { get; set; }
        public int maxHealth { get; set; }
        public int currentHealth;
        public int meleeAttack { get; set; }
        public int meleeDefence { get; set; }
        public int rangedAttack { get; set; }
        public int rangedDefence { get; set; }
        public int movementSpeed { get; set; }
        public int attackSpeed { get; set; }

        public double status = 0, newStatus = 0;
        public string craftingElement { get; set; }

        public void addStats(int stat1, double stat2)
        {
            string arrow = "  --->  ";
            string stat1String = stat1.ToString();
            string stat2String = stat2.ToString();
            comparison.Add(stat2String + arrow + stat1String);
        }

        public void addStatus(double status1, double status2)
        {
            string arrow = "  --->  ";
            newStatus = status1 * status2;
            string stat1String = newStatus.ToString();
            string stat2String = status1.ToString();
            comparison.Add(stat1String + arrow + stat2String);
        }

        public string menuInfo
        {
            //Assing name from database
            get
            {
                //Mallory (Nanotech)
                return $"{ name } ({currentHealth} {"/"} {maxHealth})";
            }
        }

        public string fullInfo
        {
            //Assing name from database
            get
            {
                //Mallory (Nanotech)
                return $"{ name } {currentHealth} {"/"} {maxHealth} {meleeAttack} {meleeDefence} {rangedAttack} {rangedDefence} {movementSpeed} {attackSpeed}";
            }
        }
    }
}