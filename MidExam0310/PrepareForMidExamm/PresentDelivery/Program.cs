using System;
using System.Linq;
using System.Collections.Generic;

namespace PresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine()
                .Split('@')
                .Select(int.Parse)
                .ToList();

            int currentPosition = 0;
            int lastIndexPosition = 0;

            string command = Console.ReadLine();

            while (command != "Merry Xmas!")
            {
                string[] jump = command.Split().ToArray();
                int jumpLenght = int.Parse(jump[1]);

                if (jump[0] == "Jump")
                {
                    for (int i = 0; i < houses.Count; i++)
                    {
                        if (jumpLenght + currentPosition >= 0 && jumpLenght + currentPosition < houses.Count)
                        {
                            currentPosition += jumpLenght;
                        }
                        else
                        {
                            currentPosition = (currentPosition + jumpLenght) % houses.Count;
                        }

                        lastIndexPosition = currentPosition;

                        if (houses[currentPosition] == 0)
                        {
                            Console.WriteLine($"House {currentPosition} will have a Merry Christmas.");
                            break;
                        }
                        else
                        {
                            houses[currentPosition] -= 2;
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            int failedHouses = 0;

            for (int i = 0; i < houses.Count; i++)
            {
                if (houses[i] != 0)
                {
                    failedHouses++;
                }
            }

            Console.WriteLine($"Santa's last position was {lastIndexPosition}.");

            if (failedHouses == 0)
            {
                Console.WriteLine($"Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Santa has failed {failedHouses} houses.");
            }
        }
    }
}
