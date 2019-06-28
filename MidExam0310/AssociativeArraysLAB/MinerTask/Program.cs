using System;
using System.Collections.Generic;
using System.Linq;

namespace MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = string.Empty;
            var collection = new Dictionary<string, int>();

            while ((resource = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!collection.ContainsKey(resource))
                {
                    collection[resource] = quantity;
                }
                else
                {
                    collection[resource] += quantity;
                }
            }

            foreach (var item in collection.OrderBy(x => x.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
