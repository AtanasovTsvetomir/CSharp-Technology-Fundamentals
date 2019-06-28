using System;

namespace CristmasSpirit
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int totalCost = 0;
            int totalSpirit = 0;
            
            for (int i = 1; i <= days; i++)
            {
                if (i % 11 == 0)
                {
                    quantity = quantity + 2;
                }
                if (i % 2 == 0)
                {
                    totalCost += quantity * 2;
                    totalSpirit += 5;
                }
                if (i % 3 == 0)
                {
                    totalCost += quantity * 5;
                    totalCost += quantity * 3;
                    totalSpirit += 13;
                }
                if (i % 5 == 0)
                {
                    totalCost += quantity * 15;
                    totalSpirit += 17;
                    if (i % 3 == 0)
                    {
                        totalSpirit += 30;
                    }
                }
                if (i % 10 == 0)
                {
                    totalSpirit -= 20;
                    totalCost += (5 + 3 + 15);
                    if (i == days)
                    {
                        totalSpirit -= 30;
                    }

                }
            }
            Console.WriteLine($"Total cost: {totalCost}");
            Console.WriteLine($"Total spirit: {totalSpirit}");
        }
    }
}
