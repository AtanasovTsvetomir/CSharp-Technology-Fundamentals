using System;

namespace IntegerOperationss
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourtNumber = int.Parse(Console.ReadLine());

            int firstSecondNumber = firstNumber + secondNumber;
            int devide = firstSecondNumber / thirdNumber;
            int total = devide * fourtNumber;
            Console.WriteLine(total);
        }
    }
}
