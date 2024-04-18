using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting__Downcasting__Reflection
{
    internal class Apple :Fruit
    {
        public double VitaminA {  get; set; }
        public double VitaminB { get; set; }
        public Apple(double vitaminA, double vitaminB, double price, string sort) : base(price, sort)
        {
            VitaminA = vitaminA;
            VitaminB = vitaminB;
        }
        
       

        public override void Taste()
        {
            Console.WriteLine("Apple");
        }
    }

}
