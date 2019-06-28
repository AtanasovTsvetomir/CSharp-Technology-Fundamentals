using System;
using System.Collections.Generic;
using System.Linq;

namespace OnTheWayToAnnapurna
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            var dictionary = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "END")
            {
                var commands = input.Split("->");

                string action = commands[0];
                string store = commands[1];

                if (action == "Remove")
                {
                    dictionary.Remove(store);
                }
                else if(action == "Add")
                {
                    var item = commands[2].Split(",");

                    if (!dictionary.ContainsKey(store))
                    {
                        dictionary.Add(store, new List<string>());
                    }

                    for (int i = 0; i < item.Length; i++)
                    {
                            dictionary[store].Add(item[i]);
                    }
                }
            }

            Console.WriteLine($"Stores list:");

            foreach (var store in dictionary
                .OrderByDescending(x => x.Value.Count)
                .ThenByDescending(x => x.Key))
            {
                Console.WriteLine(store.Key);

                foreach (var item in store.Value)
                {
                    Console.WriteLine($"<<{item}>>");
                }
            }
        }
    }
}
