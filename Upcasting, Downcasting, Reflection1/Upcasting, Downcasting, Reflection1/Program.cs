namespace Upcasting__Downcasting__Reflection1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cow cow = new Cow("Holstein cow");
            Lion lion = new Lion("Azerbaijan Lion");

            Animal[] animals = { cow, lion };

            foreach (var animal in animals)
            {
                if (animal is Lion)
                {
                    Lion lyon = (Lion)animal;
                    lyon.EatFood(new Meat("Toyug", 200));
                }
                else if (animal is Cow)
                {
                    Cow cow1 = (Cow)animal;
                    cow1.EatFood(new Grass("Yonca", 100));
                }
            }

      

        }

    }
}

