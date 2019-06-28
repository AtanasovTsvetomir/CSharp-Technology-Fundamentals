using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            MathOperationsMethod(firstNumber, command, secondNumber);
        }

        private static void MathOperationsMethod(int firstNumber, string command, int secondNumber)
        {
            double result = 0;

            switch (command)
            {
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
