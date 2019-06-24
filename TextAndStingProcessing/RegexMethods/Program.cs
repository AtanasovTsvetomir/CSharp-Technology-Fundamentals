using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;


namespace RegexMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            var text = "Augusta Ada King, Countess of Lovelace (née Byron; 10 December 1815 – 27 November 1852) was an English mathematician and writer, chiefly known for her work on Charles Babbage's proposed mechanical general-purpose computer, the Analytical Engine. ";

            if (Regex.IsMatch(text, @""))
            {
                // vrushta bool
            }

            var matches = Regex.Matches(text, @"");

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
                // vrushta vsichki usloviq na regex
            }

            string replacedString = Regex.Replace(text, @"", "_");
            // repralce


            var regex = Regex.Match(text, @"@(?<name>[A-Za-z]+)([^@:!\->]*):(?<population>[0-9]+)([^@:!\->]*)!(?<type>(A|D))!([^@:!\->]*)->(?<count>[0-9]+)");

            if (regex.Success)
            {
                string name = match.Groups["name"].Value;
                var type = match.Groups["type"].Value;
            }

            

    }
}
}
