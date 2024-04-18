using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting__Downcasting__Reflection1
{
    public abstract class Food
    { 
        public int Calorie {  get; set; }
        protected Food(int calori)
        {
            Calorie = calori;
        }

    }
}
