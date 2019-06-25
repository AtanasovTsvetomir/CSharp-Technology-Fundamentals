using System;
using System.Globalization;
namespace SoftUniCoffeOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int orderCount = int.Parse(Console.ReadLine());
            decimal orderPrice = 0;

            for (int i = 0; i < orderCount; i++)
            {
                decimal pricePerCapsules = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                int capsulesCount = int.Parse(Console.ReadLine());
                int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                decimal currentPrice = (daysInMonth * capsulesCount) * pricePerCapsules;
                orderPrice += currentPrice;

                Console.WriteLine($"The price for the coffee is: ${currentPrice:F2}");
            }
            Console.WriteLine($"Total: ${orderPrice:F2}");
        }
    }
}
