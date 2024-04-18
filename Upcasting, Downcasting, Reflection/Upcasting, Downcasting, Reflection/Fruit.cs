using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting__Downcasting__Reflection
{
    internal  abstract class Fruit
    {
        
        public double Price { get; set; }
        public string Sort { get; set; }
        public Fruit(double price , string sort)
        {
            Price = price;
            Sort = sort;
        }
        public abstract void Taste();



    }
}
