using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string regex = @"(?<value>[^0-9]+)(?<times>[0-9]+)";
            MatchCollection matched = Regex.Matches(input, regex);

            StringBuilder result = new StringBuilder();

            var uniqueSymbols = new List<char>();

            foreach (Match match in matched)
            {
                var value = match.Groups["value"].Value.ToUpper();
                var times = int.Parse(match.Groups["times"].Value);

                for (int i = 0; i < times; i++)
                {
                    result.Append(value);
                }

                if (times > 0)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (!uniqueSymbols.Contains(value[i]))
                        {
                            uniqueSymbols.Add(value[i]);
                        }
                    }
                }
            }

            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Count}");
            Console.WriteLine(result);
        }
    }
}
