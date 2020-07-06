using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuInterface
{
    public class PartyMemberCraft
    {
        public List<int> stats = new List<int>();
        public List<string> comparison = new List<string>();
        public string name { get; set; }
        public double health { get; set; }
        public double meleeAttack { get; set; }
        public double meleeDefence { get; set; }
        public double rangedAttack { get; set; }
        public double rangedDefence { get; set; }
        public double movementSpeed { get; set; }
        public double attackSpeed { get; set; }
        public double status { get; set; }
        public string craftingElement { get; set; }

        public void addStats(int stat1, double stat2)
        {
            string arrow = "  --->  ";
            int stat = (Convert.ToInt32(stat1 * stat2));
            stats.Add(stat);
            string stat1String = stat.ToString();
            string stat2String = stat1.ToString();
            comparison.Add(stat2String + arrow + stat1String);
        }

        public void addStatus(double status1, double status2)
        {
            string arrow = "  --->  ";
            double status = status1 * status2;
            string stat1String = status.ToString();
            string stat2String = status1.ToString();
            comparison.Add(stat1String + arrow + stat2String);
        }
        public void checkElement (Weapon weapon)
        {
            {
                for(int i=0; i<stats.Count; i++)
                {
                    stats[i] = Convert.ToInt32(i * 1.1);
                }
                weapon.status *= weapon.status * 1.01;
            }
        }

        public string FullCraftInfo
        {
            get
            {
                return $"{ name } ({craftingElement})";
            }
        }
    }
}
