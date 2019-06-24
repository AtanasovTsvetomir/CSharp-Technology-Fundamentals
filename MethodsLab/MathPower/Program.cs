using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            mathPowerMethod(firstNumber, secondNumber);
        }

        private static void mathPowerMethod(double firstNumber, double secondNumber)
        {
            double mathPower = Math.Pow(firstNumber, secondNumber);
            Console.WriteLine(mathPower);
        }
    }
}
