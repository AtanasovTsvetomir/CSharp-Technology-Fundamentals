using System;
using System.Linq;
using System.Collections.Generic;
// rest-2|order-10|eggs-100|rest-10 
namespace BreadFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] workingDayEvents = Console.ReadLine()
                .Split('|')
                .ToArray();
            int initialEnergy = 100;
            int initialCoins = 100;
            
            for (int i = 0; i < workingDayEvents.Length; i++)
            {
                string[] events = workingDayEvents[i]
                    .Split('-')
                    .ToArray();
                string command = events[0];
                int number = int.Parse(events[1]);

                if (command == "rest")
                {
                    int currentEnergy = initialEnergy;
                    initialEnergy += number;
                    if (initialEnergy >= 100)
                    {
                        initialEnergy = 100;
                        Console.WriteLine($"You gained {100 - currentEnergy} energy.");
                        Console.WriteLine($"Current energy: {initialEnergy}.");
                    }
                    else
                    {
                        Console.WriteLine($"You gained {number} energy.");
                        Console.WriteLine($"Current energy: {initialEnergy}.");
                    }
                }
                else if (command == "order")
                {
                    if (initialEnergy >= 30)
                    {
                        initialCoins += number;
                        initialEnergy -= 30;
                        Console.WriteLine($"You earned {number} coins.");
                    }
                    else
                    {
                        initialEnergy += 50;
                        Console.WriteLine($"You had to rest!");
                    }
                }
                else
                {
                    initialCoins -= number;
                    if (initialCoins > 0)
                    {
                        Console.WriteLine($"You bought {command}.");

                    }
                    else
                    {
                        Console.WriteLine($"Closed! Cannot afford {command}.");
                        return;
                    }
                }
            }
            Console.WriteLine($"Day completed!");
            Console.WriteLine($"Coins: {initialCoins}");
            Console.WriteLine($"Energy: {initialEnergy}");
        }
    }
}
