using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var wordToChek = Console.ReadLine().Split(" | ").ToList();

            var dictionary = new Dictionary<string, List<string>>();

            while (input != "End")
            {
                if (input == "List")
                {
                    foreach (var word in dictionary.OrderBy(x => x.Key))
                    {
                        Console.Write($"{word.Key} ");
                    }
                    return;
                }

                var wordsAndDefinitions = input.Split(" | ").ToList();
                
                for (int i = 0; i < wordsAndDefinitions.Count; i++)
                {
                    var command = wordsAndDefinitions[i].Split(": ");
                    string word = command[0];

                    if (!dictionary.ContainsKey(word))
                    {
                        dictionary.Add(word, new List<string>());
                    }
                    dictionary[word].Add(command[1]);
                }
                
                for (int i = 0; i < wordToChek.Count; i++)
                {
                    if (dictionary.ContainsKey(wordToChek[i]))
                    {
                        foreach (var word in dictionary.OrderBy(x => x.Key))
                        {
                            Console.WriteLine($"{word.Key}");

                            foreach (var definition in word.Value.OrderByDescending(x => x.Length))
                            {
                                Console.WriteLine($" -{definition}");
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
