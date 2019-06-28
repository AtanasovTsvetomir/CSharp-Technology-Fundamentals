using System;
using System.Linq;
using System.Collections.Generic;
namespace ArrayRottation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int firstNumber = array[0];
                array.RemoveAt(0);
                array.Add(firstNumber);
            }
            Console.WriteLine(string.Join(" ",array));
        }
    }
}
