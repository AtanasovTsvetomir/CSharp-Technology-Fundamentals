using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            SmallestNumber(firstNumber, secondNumber, thirdNumber);
        }

        private static void SmallestNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            int smallestNumber = 0;

            if (firstNumber < secondNumber && firstNumber < thirdNumber)
            {
                smallestNumber = firstNumber;
            }
            else if (secondNumber < firstNumber && secondNumber < thirdNumber)
            {
                smallestNumber = secondNumber;
            }
            else
            {
                smallestNumber = thirdNumber;
            }
            Console.WriteLine(smallestNumber);
        }
    }
}
