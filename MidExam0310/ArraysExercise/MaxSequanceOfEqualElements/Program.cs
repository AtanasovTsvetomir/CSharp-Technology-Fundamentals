using System;
using System.Linq;
namespace MaxSequanceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int count = 1;
            int lastIndex = 0;
            int maxCount = 0;

            for (int i = 0; i < inputArray.Length -1; i++)
            {
                if (inputArray[i] == inputArray[i+1])
                {
                    count++;
                    lastIndex = i;
                }
                else
                {
                    count = 1;
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    lastIndex = i;
                }
            }
            
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(string.Join(" ", inputArray[lastIndex]));
            }
        }
    }
}
