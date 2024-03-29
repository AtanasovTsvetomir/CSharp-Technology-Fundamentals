﻿using System;
using System.Linq;

namespace WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = Console.ReadLine()
                .Split(' ')
                .Where(x => x.Length % 2 == 0);

            foreach (var word in collection)
            {
                Console.WriteLine(word);
            }
        }
    }
}
