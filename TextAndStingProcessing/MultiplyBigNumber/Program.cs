using System;
using System.Text;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            sb.Append(firstNumber * secondNumber);

            Console.WriteLine(sb);
        }
    }
}
