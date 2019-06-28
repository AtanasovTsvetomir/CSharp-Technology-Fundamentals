using System;
using System.Collections.Generic;
using System.Linq;

namespace InternationalSoftUniada
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            var countries = new Dictionary<string, Dictionary<string, int>>();

            while ((input = Console.ReadLine()) != "END")
            {
                var commands = input.Split(" -> ");
                var country = commands[0];
                var name = commands[1];
                var points = int.Parse(commands[2]);

                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, new Dictionary<string, int>());
                    countries[country].Add(name, points);
                }
                else
                {
                    if (!countries[country].ContainsKey(name))
                    {
                        countries[country].Add(name, points);
                    }
                    else
                    {
                        countries[country][name] += points;
                    }
                }
            }

            foreach (var country in countries.OrderByDescending(x=>x.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key}: {country.Value.Values.Sum()}");

                foreach (var name in country.Value)
                {
                    Console.WriteLine($"-- {name.Key} -> {name.Value}");
                }
            }
        }
    }
}
