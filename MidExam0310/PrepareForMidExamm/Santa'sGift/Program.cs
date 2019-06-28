using System;
using System.Linq;
using System.Collections.Generic;

namespace Santa_sGift
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfCommands = int.Parse(Console.ReadLine());
            List<int> houseNumebers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int position = 0;
            for (int i = 0; i < countOfCommands; i++)
            {
                string[] commands = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (commands[0] == "Forward")
                {
                    if (position + int.Parse(commands[1]) < houseNumebers.Count)
                    {
                        position = position + int.Parse(commands[1]);
                        houseNumebers.RemoveAt(position);
                    }
                }
                else if (commands[0] == "Back")
                {
                    if (position - int.Parse(commands[1]) >= 0)
                    {
                        int count = int.Parse(commands[1]);
                        position = position - int.Parse(commands[1]);
                        houseNumebers.RemoveAt(position);
                    }
                }
                else if (commands[0] == "Gift")
                {
                    if (int.Parse(commands[1]) >= 0 && int.Parse(commands[1]) <= houseNumebers.Count)
                    {
                        houseNumebers.Insert(int.Parse(commands[1]), int.Parse(commands[2]));
                        position = int.Parse(commands[1]);
                    }
                }
                else if (commands[0] == "Swap")
                {
                    if (houseNumebers.Contains(int.Parse(commands[1])) && 
                        houseNumebers.Contains(int.Parse(commands[2])))
                    {
                        int firstNumber = houseNumebers.IndexOf(int.Parse(commands[1]));
                        int secondNumber = houseNumebers.IndexOf(int.Parse(commands[2]));
                        houseNumebers.RemoveAt(firstNumber);
                        houseNumebers.Insert(firstNumber, int.Parse(commands[2]));
                        houseNumebers.RemoveAt(secondNumber);
                        houseNumebers.Insert(secondNumber, int.Parse(commands[1]));
                    }
                }
            }
            Console.WriteLine($"Position: {position}");
            Console.WriteLine(string.Join(", ", houseNumebers));
        }
    }
}
