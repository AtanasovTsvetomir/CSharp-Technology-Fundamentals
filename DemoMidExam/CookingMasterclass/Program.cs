using System;
using System.Linq;

namespace CookingMasterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int student = int.Parse(Console.ReadLine());
            double priceOfFlour = double.Parse(Console.ReadLine());
            double priceOfEgg = double.Parse(Console.ReadLine());
            double priceOfApron = double.Parse(Console.ReadLine());

            int freePackes = 0;

            if (student >= 5)
            {
                for (int i = 1; i <= student; i++)
                {
                    if (i % 5 == 0)
                    {
                        freePackes++;
                    }
                }
            }

            double TwentyPercent = Math.Ceiling(student + (student * 0.20));
            double moneyForApron = priceOfApron * TwentyPercent;
            double moneyForEgg = priceOfEgg * 10 * student;
            double moneyForFlour = priceOfFlour * (student - freePackes);

            double result = moneyForApron + moneyForEgg + moneyForFlour;
            double neededMoney = result - budget;

            if (budget >= result)
            {
                Console.WriteLine($"Items purchased for {result:f2}$.");
            }
            else
            {
                Console.WriteLine($"{neededMoney:f2}$ more needed.");
            }
        }
    }
}
