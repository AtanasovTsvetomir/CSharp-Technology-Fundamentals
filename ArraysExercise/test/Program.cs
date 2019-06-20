using System;
using System.Linq;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);

            /*
             
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            string allElements = string.Empty;

            for (int i = 0; i < number; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;
                allElements += currentNumber + " ";
            }
            Console.WriteLine(allElements.Trim());       /.Trim() izrqzva spaco-vete otpred i otzad .
            Console.WriteLine(sum);

            */
           
        }
    }
}
