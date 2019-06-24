using System;
using System.Linq;
namespace MultiplyEvenByOdds
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] numberArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            GetSumOfEvenDigits(numberArray);
            GetSumOfOddDigits(numberArray);
            GetSumOfEvenAndOdds(numberArray);

            Console.WriteLine(GetSumOfEvenAndOdds(numberArray));
        }

        static int GetSumOfEvenAndOdds(int[] numberArray)
        {

            int sumOfEvenAndOdds = GetSumOfOddDigits(numberArray) + GetSumOfEvenDigits(numberArray);
            return sumOfEvenAndOdds;
        }

        static int GetSumOfOddDigits(int[] numberArray)
        {
            int sumOfOddDigits = 0;
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sumOfOddDigits += numberArray[i];
                }
            }
            return sumOfOddDigits;
        }

        static int GetSumOfEvenDigits(int[] numberArray)
        {
            int sumOfEvenDigits = 0;
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sumOfEvenDigits += numberArray[i];
                }
            }
            return sumOfEvenDigits;
        }
    }
}
