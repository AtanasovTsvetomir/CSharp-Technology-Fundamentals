using System;

namespace RepeatingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = input.Split();
            string result = string.Empty;

            foreach (var word in words)
            {
                var repeatCount = word.Length;

                for (int i = 0; i < repeatCount; i++)
                {
                    result += word;
                }
            }
            Console.WriteLine(result);
        }
    }
}
