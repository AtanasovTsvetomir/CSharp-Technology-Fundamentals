using System;
using System.Collections.Generic;
using System.Linq;

namespace SantaLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> kids = Console.ReadLine()
                .Split('&')
                .ToList();
            string command = Console.ReadLine();

            while (command != "Finished!")
            {
                string[] commandLine = command.Split();

                TypeOfKids(kids, commandLine);

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", kids));
        }

        private static void TypeOfKids(List<string> kids, string[] commandLine)
        {
            if (commandLine[0] == "Bad")
            {
                if (!kids.Contains(commandLine[1]))
                {
                    kids.Insert(0, commandLine[1]);
                }
            }
            if (commandLine[0] == "Good")
            {
                if (kids.Contains(commandLine[1]))
                {
                    kids.Remove(commandLine[1]);
                }
            }
            if (commandLine[0] == "Rename")
            {
                if (kids.Contains(commandLine[1]))
                {
                    int index =kids.IndexOf(commandLine[1]);
                    kids[index] = commandLine[2];
                }
            }
            if (commandLine[0] == "Rearrange")
            {
                if (kids.Contains(commandLine[1]))
                {
                    kids.Remove(commandLine[1]);
                    kids.Add(commandLine[1]);
                }
            }
        }
    }
}