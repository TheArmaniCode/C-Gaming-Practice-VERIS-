using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuInterface
{
    public class ElementChip : Part
    {
        public string element { get; set; }
        //display info chip
        public string FullChipInfo
        {
            get
            {
                //Fire Chip, 50, Fire
                return $"{ name } { value } { element }";
            }
        }
    }
}
