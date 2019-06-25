using System;
using System.Collections.Generic;
using System.Linq;
namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int capacityOfWagons = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "end")
            {
                List<string> directions = command.Split().ToList();
                if (directions[0] == "Add")
                {
                    int customersInWagon = int.Parse(directions[1]);
                    wagons.Add(customersInWagon);
                }
                else
                {
                    int passengersToFit = int.Parse(directions[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengersToFit <= capacityOfWagons)
                        {
                            wagons[i] += passengersToFit;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.Write(string.Join(" ", wagons));
        }
    }
}
