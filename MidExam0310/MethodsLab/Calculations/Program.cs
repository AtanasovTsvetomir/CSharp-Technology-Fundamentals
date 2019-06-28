using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            addMethod(command, firstNumber, secondNumber);
            substractMethod(command, firstNumber, secondNumber);
            multiplyMethod(command, firstNumber, secondNumber);
            devideMethod(command, firstNumber, secondNumber);
        }

        private static void devideMethod(string command, int firstNumber, int secondNumber)
        {
            if (command == "divide")
            {
                Console.WriteLine(firstNumber / secondNumber);
            }
        }

        private static void multiplyMethod(string command, int firstNumber, int secondNumber)
        {
            if (command == "multiply")
            {
                Console.WriteLine(firstNumber * secondNumber);
            }
        }

        private static void substractMethod(string command, int firstNumber, int secondNumber)
        {
            if (command == "subtract")
            {
                Console.WriteLine(firstNumber - secondNumber);
            }
        }

        private static void addMethod(string command, int firstNumber, int secondNumber)
        {
            if (command == "add")
            {
                Console.WriteLine(firstNumber + secondNumber);
            }
        }
    }
}
