using System;
using System.Linq;
namespace EqualSum
{
    class Program
    {
        // 10 5 5 99 3 4 2 5 1 1 4
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            if (numbers.Length==1)
            {
                Console.WriteLine(0);
                return;
            }
            int firstSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i>0)
                {
                    firstSum += numbers[i - 1];
                }
                
                int secondSum = 0;

                for (int j = i+1; j < numbers.Length; j++)
                {
                    secondSum += numbers[j];

                }
                if (firstSum == secondSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
