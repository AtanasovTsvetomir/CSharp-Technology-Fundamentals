using System;

namespace TrippleOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()) + 'a';

            for (char i = 'a'; i < number; i++)
            {
                for (char j = 'a'; j < number; j++)
                {
                    for (char k = 'a'; k < number; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
