using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuInterface
{
    public class Item
    {
        public string name;
        public string type;
        public int effect;
        public int number;

        public string BaseItemInfo
        {
            get
            {
                return $"{ name } { "x" + number }";
            }
        }
        public string FullItemInfo
        {
            get
            {
                return $"{ name } { "x" + number } {effect}";
            }
        }

        public void heal(Item i, PartyMember p)
        {
            if (i.type == "Potion")
            {
                if (effect > p.maxHealth - p.currentHealth)
                {
                    p.currentHealth += p.maxHealth;
                }
                else
                {
                    p.currentHealth += effect;
                }
            }
        }
    }
}
