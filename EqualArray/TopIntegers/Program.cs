using System;
using System.Linq;
namespace TopIntegers
{
    class Program
    { 
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] bigger = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                bool flag = true;
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] <= numbers[j])
                    {
                        flag = false;
                        
                    }
                }
                if (flag)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
