using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuInterface
{
    public class Weapon
    {
        public string name { get; set; }
        public int rangedAttack { get; set; }
        public int meleeAttack { get; set; }
        public int rangedDefence { get; set; }
        public int meleeDefence { get; set; }
        public int movementSpeed { get; set; }
        public int attackSpeed { get; set; }
        public string element { get; set; }
        public int rating { get; set; }
        public int key { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{name} {meleeAttack} {meleeDefence} {rangedAttack} {rangedDefence} {movementSpeed} {attackSpeed} {element} {rating}";
            }
        }
    }
}
