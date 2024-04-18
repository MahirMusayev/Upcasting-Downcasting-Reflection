using System.Reflection;

namespace Upcasting__Downcasting__Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple(20, 25, 12, "alma");
            Orange orange = new Orange(30, 14, "oringe");
            Pineapple pineapple = new Pineapple(40, 45, 16, "pineapple");
            Fruit[] fruits = { apple, orange, pineapple };
            foreach (var fruit in fruits)
            {

                Type type = fruit.GetType();
                Console.WriteLine(type.Name + " typeinden obyektde:");

                PropertyInfo[] properties = type.GetProperties();
                foreach (var property in properties)
                {
                    Console.WriteLine(property.Name + ": " + property.GetValue(fruit));
                }

                Console.WriteLine();
            }


            foreach (Fruit fruit in fruits)
            {


                //Apple app = fruit as Apple;
                //Pineapple pine = fruit as Pineapple;
                //Orange org = fruit as Orange;
                //if (app != null)
                //{
                //    Console.WriteLine("apple");
                //    Console.WriteLine(app.VitaminA + " " + app.Price + " " + app.VitaminB+ " " +app.Sort);
                //}
                //if (pine != null)
                //{
                //    Console.WriteLine("Pineapple");
                //    Console.WriteLine(pine.VitaminD + " " + pine.Price + " " + pine.VitaminE + " " + pine.Sort);
                //}
                //if (org != null)
                //{
                //    Console.WriteLine("Orange");
                //    Console.WriteLine(org.VitaminC + " " + org.Price +  " " + org.Sort);
                //}
            }

        }
    }
}
