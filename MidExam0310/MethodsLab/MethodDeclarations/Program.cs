using System;

namespace MethodDeclarations
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        }

        private static void PrintNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
