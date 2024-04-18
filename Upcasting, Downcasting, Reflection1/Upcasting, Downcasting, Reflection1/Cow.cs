using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting__Downcasting__Reflection1
{
    public class Cow : Animal
    {
        public Cow(string breed) : base(breed)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Moooo moo");

        }

        public override void EatFood(Food food)
        {

            if (food is Grass)
            {
                Console.WriteLine("ugurla qidalandi");
            }
            else
            {
                Console.WriteLine("“İnək üçün yanlış yemək verilir.");
            }
        }
        public void ProduceMilk()
        {
            Console.WriteLine("Milk produced.");
        }

    }
}
