using System;
using System.Linq;
using System.Collections.Generic;

namespace CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine()
                .Where(x => x != ' ')
                .ToArray();

            var collection = new Dictionary<char, int>();

            foreach (var element in text)
            {
                if (!collection.ContainsKey(element))
                {
                    collection[element] = 0;
                }
                collection[element]++;
            }

            foreach (var kvp in collection)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
