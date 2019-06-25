using System;

namespace GoogleSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int numberOfUsers = int.Parse(Console.ReadLine());
            double moneyPerSearch = double.Parse(Console.ReadLine());

            double totalMoney = 0;

            for (int i = 1; i <= numberOfUsers; i++)
            {
                int words = int.Parse(Console.ReadLine());
                double money = 0;

                if (words == 1)
                {
                    money = moneyPerSearch * 2;
                }
                else if (words > 1 && words <= 5)
                {
                    money = moneyPerSearch;
                }
                if (i % 3 == 0)
                {
                    money *= 3;
                }
                totalMoney += money;
            }
            totalMoney *= days;
            Console.WriteLine($"Total money earned for {days} days: {totalMoney:f2}");
        }
    }
}
