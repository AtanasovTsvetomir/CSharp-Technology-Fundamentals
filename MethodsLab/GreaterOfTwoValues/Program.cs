using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();

            GetMax(value, firstInput, secondInput);

        }

        private static void GetMax(string value, string firstInput, string secondInput)
        {

            if (value == "int")
            {
                int firstInt = int.Parse(firstInput);
                int secondInt = int.Parse(secondInput);
                int getMax = 0;
                if (firstInt > secondInt)
                {
                    getMax = firstInt;
                    Console.WriteLine(firstInt);
                }
                else
                {
                    Console.WriteLine(secondInput);
                }
            }
            if (value == "string" || value == "char")
            {
                if (string.Compare(firstInput, secondInput) < 0)
                {
                    Console.WriteLine(secondInput);
                }
                else
                {
                    Console.WriteLine(firstInput);
                }
            }
        }
    }
}
