using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            var attackedPlanets = new List<string>();
            var destroyedPlanets = new List<string>();

            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();

                StringBuilder sb = new StringBuilder(input);

                for (int j = 0; j < sb.Length; j++)
                {
                    if (sb[j] == 's' || sb[j] == 't' || sb[j] == 'a' || sb[j] == 'r' ||
                        sb[j] == 'S' || sb[j] == 'T' || sb[j] == 'A' || sb[j] == 'R')
                    {
                        sum++;
                    }
                }

                for (int j = 0; j < sb.Length; j++)
                {
                    sb[j] = (char)(sb[j] - sum);
                }

                string output = sb.ToString();

                sum = 0;

                string pattern = @"@(?<name>[A-Za-z]+)([^@:!\->]*):(?<population>[0-9]+)([^@:!\->]*)!(?<type>(A|D))!([^@:!\->]*)->(?<count>[0-9]+)";

                var match = Regex.Match(output, pattern);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    var type = match.Groups["type"].Value;

                    if (type =="A")
                    {
                        attackedPlanets.Add(name);
                    }
                    else
                    {
                        destroyedPlanets.Add(name);
                    }
                }
            }

            int sumAttacked = attackedPlanets.Count;
            int sumDestroyed = destroyedPlanets.Count;

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed plantes: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
