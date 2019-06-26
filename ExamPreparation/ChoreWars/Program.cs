using System;
using System.Text.RegularExpressions;

namespace ChoreWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int totalTime = 0;
            int timeDishes = 0;
            int timeCleaning = 0;
            int timeLaundry = 0;

            while ((input = Console.ReadLine()) !="wife is happy")
            {
                string patternDishes = @"[?:<][a-z0-9]+[?:>]";
                string patternCleaning = @"[?:[][A-Z0-9]+[]?:]";
                string patternLaundry = @"[?:{].+[?:}]";

                var regexDishes = Regex.Matches(input, patternDishes);
                var regexCleaning = Regex.Matches(input, patternCleaning);
                var regexLaundry = Regex.Matches(input, patternLaundry);

                foreach (var dishes in regexDishes)
                {
                    string dishe = dishes.ToString();
                    foreach (var dish in dishe)
                    {
                        if (char.IsDigit(dish))
                        {
                            timeDishes += dish - '0';
                        }
                    }

                }

                foreach (Match cleaning in regexCleaning)
                {
                    string clean = cleaning.ToString();

                    foreach (var cleaned in clean)
                    {
                        if (char.IsDigit(cleaned))
                        {
                            timeCleaning += cleaned - '0';
                        }
                    }
                }

                foreach (Match laundry in regexLaundry)
                {
                    string washing = laundry.ToString();

                    foreach (var wash in washing)
                    {
                        if (char.IsDigit(wash))
                        {
                            timeLaundry += wash - '0';
                        }
                    }

                }
            }
            totalTime = timeLaundry + timeDishes + timeCleaning;

            Console.WriteLine($"Doing the dishes - {timeDishes} min.");
            Console.WriteLine($"Cleaning the house - {timeCleaning} min.");
            Console.WriteLine($"Doing the laundry - {timeLaundry} min.");
            Console.WriteLine($"Total - {totalTime} min.");
        }
    }
}
