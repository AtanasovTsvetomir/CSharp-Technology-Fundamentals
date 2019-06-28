using System;
using System.Collections.Generic;
using System.Linq;
namespace ListDeclaration
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ages = new List<int>();

            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

        }
    }
}
