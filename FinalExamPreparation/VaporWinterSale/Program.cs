using System;
using System.Collections.Generic;
using System.Linq;

namespace VaporWinterSale
{
    class Program
    {
        static void Main(string[] args)
        {
            var gamesAndPrice = new Dictionary<string, decimal>();
            var gamesAndDlc = new Dictionary<string, string>();

            var input = Console.ReadLine()
                .Split(", ");

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Contains(":"))
                {
                    var tokensDlc = input[i].Split(":");

                    var gameName = tokensDlc[0];
                    var dlc = tokensDlc[1];

                    if (gamesAndPrice.ContainsKey(gameName))
                    {
                        gamesAndDlc.Add(gameName, dlc);

                        decimal increasePrice = gamesAndPrice[gameName] += (gamesAndPrice[gameName] * 0.20m);

                        gamesAndPrice[gameName] = increasePrice;
                    }
                }
                else
                {
                    var tokensWithoutDlc = input[i].Split("-");

                    var gameName = tokensWithoutDlc[0];
                    decimal gamePrice = decimal.Parse(tokensWithoutDlc[1]);

                    gamesAndPrice.Add(gameName, gamePrice);
                }
            }

            var gamesAndLowerPriceWithoutDlc = new Dictionary<string,decimal>();
            var gamesAndLowerPriceWithDlc = new Dictionary<string,decimal>();

            foreach (var game in gamesAndPrice)
            {
                var gameName = game.Key;
                decimal price = game.Value;

                if (!gamesAndDlc.ContainsKey(gameName))
                {
                    decimal lowerPrice = price - (price * 0.20m);

                    gamesAndLowerPriceWithoutDlc.Add(gameName, lowerPrice);
                }
                else
                {
                    decimal lowerPrice = price - (price * 0.50m);

                    gamesAndLowerPriceWithDlc.Add(gameName, lowerPrice);
                }
            }

            foreach (var kvp in gamesAndLowerPriceWithDlc
                .OrderBy(x => x.Value))
            {
                string name = kvp.Key;
                decimal price = kvp.Value;
                Console.WriteLine($"{name} - {gamesAndDlc[kvp.Key]} - {price:f2}");
            }

            foreach (var kvp in gamesAndLowerPriceWithoutDlc
                .OrderByDescending(x=>x.Value))
            {
                string name = kvp.Key;
                decimal price = kvp.Value;
                Console.WriteLine($"{name} - {price:f2}");
            }
        }
    }
}
