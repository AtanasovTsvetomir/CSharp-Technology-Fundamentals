using System;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTriangle(number);
            PrintReverseTriangle(number -1);
        }

        private static void PrintReverseTriangle(int maxNumber)
        {
            for (int row = maxNumber; row >= 1; row--)
            {
                PrintRowWithNumbers(row);
            }
        }

        private static void PrintTriangle(int maxNumber)
        {
            for (int row = 1; row <= maxNumber; row++)
            {
                PrintRowWithNumbers(row);
            }

        }

        private static void PrintRowWithNumbers(int row)
        {
            for (int number = 1; number <= row; number++)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
