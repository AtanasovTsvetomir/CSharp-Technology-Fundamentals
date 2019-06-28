using System;
using System.Linq;
namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int[] firstZigZagArray = new int[n];
            int[] secondZigZagArray = new int[n];

            for (int i = 1; i <= n; i++)
            {
                int[] Array = Console.ReadLine()
                    .Split().
                    Select(int.Parse)
                    .ToArray();
                if (i % 2 != 0)
                {
                    firstZigZagArray[i - 1] = Array[0];
                    secondZigZagArray[i - 1] = Array[1];
                }
                else
                {
                    firstZigZagArray[i - 1] = Array[1];
                    secondZigZagArray[i - 1] = Array[0];
                }
            }
            Console.Write(string.Join(" ", firstZigZagArray));
            Console.WriteLine();
            Console.Write(string.Join(" ", secondZigZagArray));
        }
    }
}
