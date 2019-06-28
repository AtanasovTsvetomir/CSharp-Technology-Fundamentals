using System;

namespace readingArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int index = 0; index < n; index++)
            {
                array[index] = int.Parse(Console.ReadLine());
            }

            string values = Console.ReadLine();
            string[] valuesAsStrings = values.Split(); 
            int[] numbers = new int[valuesAsStrings.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(valuesAsStrings[i]);
            }

        }
    }
}
