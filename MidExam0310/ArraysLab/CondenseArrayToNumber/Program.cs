using System;
using System.Linq;
namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int finalResult = 0;
            int lenght = numberArray.Length - 1;

            if (numberArray.Length == 1)
            {
                Console.WriteLine(numberArray[0]);
                return;
            }

            for (int i = 0; i < lenght; i++)
            {
                int[] condenseArray = new int[numberArray.Length - 1];

                for (int j = 0; j < condenseArray.Length; j++)
                {
                    condenseArray[j] = numberArray[j] + numberArray[j + 1];
                }

                numberArray = condenseArray;
                finalResult = condenseArray[0];
            }

            Console.WriteLine(finalResult);
        }
    }
}
