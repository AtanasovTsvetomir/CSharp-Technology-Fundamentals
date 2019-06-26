using System;
using System.Collections.Generic;
using System.Linq;


namespace SantaNewList
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            var children = new Dictionary<string, int>();
            var presents = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "END")
            {
                var commands = input
                    .Split("->");
                string childName = commands[0];
                string type = commands[1];

                if (childName == "Remove")
                {
                    children.Remove(type);
                }
                else
                {
                    int count = int.Parse(commands[2]);

                    if (!children.ContainsKey(childName))
                    {
                        children.Add(childName, count);
                    }
                    else
                    {
                        children[childName] += count;
                    }

                    if (!presents.ContainsKey(type))
                    {
                        presents.Add(type, count);
                    }
                    else
                    {
                        presents[type] += count;
                    }
                }
            }

            Console.WriteLine("Children:");

            foreach (var name in children
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{name.Key} -> {name.Value}");
            }

            Console.WriteLine("Presents:");

            foreach (var toy in presents)
            {
                Console.WriteLine($"{toy.Key} -> {toy.Value}");
            }
        }
    }
}
