using System;
using System.Collections.Generic;
using System.Linq;

namespace WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeats = int.Parse(Console.ReadLine());
            var collection = new Dictionary<string, List<string>>();
            
            for (int i = 0; i < repeats; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!collection.ContainsKey(word))
                {
                    collection.Add(word, new List<string>());
                }
                
                collection[word].Add(synonym);
            }

            foreach (var kvp in collection)
            {
                Console.WriteLine($"{kvp.Key} - {string.Join(", ", kvp.Value)}");
            }
        }
    }
}
