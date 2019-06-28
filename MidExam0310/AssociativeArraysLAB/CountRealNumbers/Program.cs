using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> collection = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            var newCollection = new SortedDictionary<int, int>();

            foreach (var number in collection)
            {
                if (newCollection.ContainsKey(number))
                {
                    newCollection[number]++;
                }
                else
                {
                    newCollection.Add(number, 1);
                }
            }
            foreach (var number in newCollection)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");

            }
        }
    }
}
