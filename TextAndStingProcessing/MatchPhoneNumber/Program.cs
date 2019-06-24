using System;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var numbers = Regex.Matches(input, @"\+359([- \s])2\1\d{3}\1\d{4}\b");

            bool firstPrint = true;

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
