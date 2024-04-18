using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting__Downcasting__Reflection1
{
    public class Meat : Food
    {
        public string Type { get; set; }
        public Meat(string type, int calori) : base(calori)
        {
            Type = type;
        }


    }
}
