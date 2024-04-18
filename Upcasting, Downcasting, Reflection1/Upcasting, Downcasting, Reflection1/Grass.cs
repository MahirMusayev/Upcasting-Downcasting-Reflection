using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting__Downcasting__Reflection1
{
    public class Grass : Food 
    {
        public string Name {  get; set; }
        public Grass(string name ,int calori) :base(calori)
        {
            Name = name;
        }
    }
}
