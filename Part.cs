using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuInterface
{
    public class Part
    {
        public string name { get; set; }
        public int value { get; set; }
        public int key { get; set; }
        public string FullPartInfo
        {
            get
            {
                return $"{ name } { value }";
            }

        }
    }
}
