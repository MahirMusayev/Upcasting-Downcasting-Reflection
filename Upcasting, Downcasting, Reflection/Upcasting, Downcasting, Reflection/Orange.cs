using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting__Downcasting__Reflection
{
    internal class Orange :Fruit
    {
        public double VitaminC {  get; set; }
        public Orange( int vitaminC,double price, string sort) : base(price, sort)
        {
            VitaminC = vitaminC;
        }


        public override void Taste()
        {
            Console.WriteLine("Orange");
        }
    }
}
