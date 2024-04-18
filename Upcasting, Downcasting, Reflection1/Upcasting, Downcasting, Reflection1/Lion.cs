using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting__Downcasting__Reflection1
{
    public class Lion : Animal
    {
        public Lion(string breed) : base(breed)
        {
        }

        public bool IsPrideLeader { get; set; }
        public override void EatFood(Food food)
        {

            if (food is Meat)
            {
                Console.WriteLine("ugurla qidalandi");
            }
            else
            {
                Console.WriteLine("Lion üçün yanlış yemək verilir.");
            }
        }
        public override void MakeSound()
        {
            Console.WriteLine("sir sesi");
        }


    }
}
