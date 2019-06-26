using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloFrance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> collection = Console.ReadLine()
                .Split('|')
                .ToList();
            double budget = double.Parse(Console.ReadLine());
            List<double> newCollection = new List<double>();
            double profit = 0;
            double newPrice = 0;

            for (int i = 0; i < collection.Count; i++)
            {
                string[] item = collection[i].Split("->").ToArray();
                string type = item[0];
                double price = double.Parse(item[1]);

                if (type == "Clothes" && price <= 50.00 && budget >= price)
                {
                    budget -= price;
                    profit += (price * 0.40 + price) - price;
                    price = price + (price * 0.40);
                    newPrice += price;
                    newCollection.Add(price);
                }
                else if (type == "Shoes" && price <= 35.00 && budget >= price)
                {
                    budget -= price;
                    profit += (price * 0.40 + price) - price;
                    price = price + (price * 0.40);
                    newPrice += price;
                    newCollection.Add(price);

                }
                else if (type == "Accessories" && price <= 20.50 && budget >= price)
                {
                    budget -= price;
                    profit += (price * 0.40 + price) - price;
                    price = price + (price * 0.40);
                    newPrice += price;
                    newCollection.Add(price);
                }
            }
            foreach (var item in newCollection)
            {
                Console.Write($"{item:f2} ");
            }
            Console.WriteLine();
            double total = newPrice + budget;
            Console.WriteLine($"Profit: {profit:f2}");

            if (total >= 150)
            {
                Console.WriteLine($"Hello, France!");
            }
            else
            {
                Console.WriteLine($"Time to go.");
            }
        }
    }
}
