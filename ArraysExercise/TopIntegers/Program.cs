using System;
using System.Linq;
namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < myArray.Length; i++)
            {
                bool isBigger = false;
                for (int j = i+1; j < myArray.Length; j++)
                {
                    if (myArray[i] <= myArray[j])
                    {
                        isBigger = true;
                    }
                }
                if (isBigger)
                {
                    Console.Write(myArray[i] + " ");
                }
            }
        }
    }
}
