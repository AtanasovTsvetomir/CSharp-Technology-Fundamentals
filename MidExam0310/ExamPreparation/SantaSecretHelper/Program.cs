using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SantaSecretHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            var kids = new List<string>();

            int key = int.Parse(Console.ReadLine());

            string pattern = @"@(?<name>[A-Za-z]+)[^-@!:>]*!(?<behavior>(G))!";

            while ((input = Console.ReadLine()) != "end")
            {
                StringBuilder sb = new StringBuilder();
                foreach (var symbol in input)
                {
                    char decodedSymbol = (char)(symbol - key);
                    sb.Append(decodedSymbol);
                }

                Match match = Regex.Match(sb.ToString(), pattern);

                if (match.Success)
                {
                    string text = match.Groups["name"].Value;
                    kids.Add(text);
                }
            }
            foreach (var name in kids)
            {
                Console.WriteLine(name);
            }
        }
    }
}
