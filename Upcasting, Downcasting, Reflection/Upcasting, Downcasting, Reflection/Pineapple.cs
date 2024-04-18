using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting__Downcasting__Reflection
{
    internal class Pineapple : Fruit
    {

        public double VitaminD { get; set; }
        public double VitaminE { get; set; }
        public Pineapple(double vitaminD, double vitaminE, double price, string sort) : base(price, sort)
        {
            VitaminD = vitaminD;
            VitaminE = vitaminE;
        }

        public override void Taste()
        {
            Console.WriteLine("Pineapple");
        }
    }
}
