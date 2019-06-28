using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ArrivingInKathmandu
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
           
            string pattern = @"^(?<name>[A-Za-z0-9!@#$?]+)=(?<lenght>[0-9]*)<<(?<geohas>\w*)$";

            while ((input = Console.ReadLine()) != "Last note")
            {
                Regex order = new Regex(pattern);
                if (order.IsMatch(input))
                {
                    string name = order.Match(input).Groups["name"].Value;
                    int lenght = int.Parse(order.Match(input).Groups["lenght"].Value);
                    string geohas = order.Match(input).Groups["geohas"].Value;

                    if (lenght == geohas.Length)
                    {
                        StringBuilder sb = new StringBuilder();

                        foreach (var symbol in name)
                        {
                            if (char.IsLetter(symbol))
                            {
                                sb.Append(symbol);
                            }
                        }

                        Console.WriteLine($"Coordinates found! {sb} -> {geohas}");
                    }
                    else
                    {
                        Console.WriteLine($"Nothing found!");
                    }
                }
                else
                {
                    Console.WriteLine($"Nothing found!");
                }
            }
        }
    }
}
