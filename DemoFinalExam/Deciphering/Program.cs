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

            var aph = Console.ReadLine().Split();

            var pattern = @"^[d-z{}\|#]*$";

            Regex order = new Regex(pattern);

            StringBuilder sb = new StringBuilder();

            if (order.IsMatch(input))
            {
                foreach (var character in input)
                {
                    sb.Append((char)(character - 3));
                }

                string firstSub = aph[0];
                string secondSub = aph[1];

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
