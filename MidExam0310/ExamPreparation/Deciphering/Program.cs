using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var secondLine = Console.ReadLine().Split();

            StringBuilder sb = new StringBuilder();

            var pattern = @"^[d-z{}\|#]*$";
            Regex order = new Regex(pattern);

            if (order.IsMatch(input))
            {
                foreach (var symbol in input)
                {
                    char decryptedSymbol = (char)(symbol - 3);
                    sb.Append(decryptedSymbol);
                }

                string firstSub = secondLine[0];
                string secondSub = secondLine[1];

                sb.Replace(firstSub, secondSub);

                Console.WriteLine(sb);
            }
            else
            {
                Console.WriteLine("This is not the book you are looking for.");
            }
        }
    }
}
