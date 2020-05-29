using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuInterface
{
    public class PartyMember
    {
        string PM;
        List<PartyMember> partyMembers = new List<PartyMember>();
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
        public string craftingElement { get; set; }

        //DataAccess db = new DataAccess();

        //partyMembers = db.GetPartyMembers(PM);

        public string FullPartyMemberInfo
        {  
            //Assing name from database
            get 
            {
                //Mallory (Nanotech)
                return $"{ name } ({weapon})";
            }
        }

        double[] craftingStats = {};
        double[] weaponStats = {};

        //Crafting function

    }
}
