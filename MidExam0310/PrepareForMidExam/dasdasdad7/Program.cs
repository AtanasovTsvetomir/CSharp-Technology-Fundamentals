using System;
using System.Linq;

namespace dasdasdad7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dungeonestRoom = Console.ReadLine()
                .Split('|')
                .ToArray();
            int initialHealth = 100;
            int initialCoins = 0;

            for (int i = 0; i < dungeonestRoom.Length; i++)
            {
                string[] room = dungeonestRoom[i].Split().ToArray();
                string command = room[0];
                int number = int.Parse(room[1]);

                if (command == "potion")
                {
                    int currentHealth = initialHealth;
                    initialHealth += number;

                    if (initialHealth > 100)
                    {
                        Console.WriteLine($"You healed for {100 - currentHealth} hp.");
                        Console.WriteLine("Current health: 100 hp.");
                        initialHealth = 100;
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {number} hp.");
                        Console.WriteLine($"Current health: {initialHealth} hp.");
                    }
                }
                else if (command == "chest")
                {
                    initialCoins += number;
                    Console.WriteLine($"You found {number} coins.");
                }
                else
                {
                    initialHealth -= number;
                    if (initialHealth > 0)
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {i+1}");
                        return;
                    }
                }
            }
            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Coins: {initialCoins}");
            Console.WriteLine($"Health: {initialHealth}");
        }
    }
}

