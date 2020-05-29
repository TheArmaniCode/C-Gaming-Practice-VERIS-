using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuInterface
{
    class Quests
    {
        public string name { get; set; }
        public string description { get; set; }
        public string objective { get; set; }
        public string location { get; set; }
        public int expReward { get; set; }
        public int moneyReward { get; set; }
        public string itemReward { get; set; }
        public Boolean cleared;

        public string FullInfo
        {
            get
            {
                return $"{name} {cleared}";
            }
        }
    }
}
