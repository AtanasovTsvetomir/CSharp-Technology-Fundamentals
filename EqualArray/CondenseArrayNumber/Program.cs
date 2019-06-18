using System;
using System.Linq;
namespace CondenseArrayNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int finalResult = 0;
            int lenght = numbers.Length - 1;

            if (numbers.Length == 1)
            {
                Console.WriteLine(numbers[0]);
                return;
            }

            for (int i = 0; i < lenght; i++)
            {
                int[] condenseArray = new int[numbers.Length - 1];
                for (int j = 0; j < condenseArray.Length; j++)
                {
                    condenseArray[j] = numbers[j] + numbers[j + 1];
                }
                numbers = condenseArray;
                finalResult = condenseArray[0];
            }
            Console.WriteLine(finalResult);
        }
    }
}
