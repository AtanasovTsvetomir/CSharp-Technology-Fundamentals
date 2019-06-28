using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniExamResult
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentAndPoints = new Dictionary<string, int>();
            var submissions = new Dictionary<string, int>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "exam finished")
            {
                string[] inputLine = input.Split('-');

                string name = inputLine[0];

                if (inputLine[1] == "banned")
                {
                    studentAndPoints.Remove(name);
                }
                else
                {
                    string language = inputLine[1];
                    int points = int.Parse(inputLine[2]);

                    if (!studentAndPoints.ContainsKey(name))
                    {
                        studentAndPoints[name] = points;
                    }
                    else if(points > studentAndPoints[name])
                    {
                        studentAndPoints[name] = points; 
                    }

                    if (!submissions.ContainsKey(language))
                    {
                        submissions[language] = 0;
                    }

                    submissions[language]++;
                }
            }

            Console.WriteLine("Results:");

            foreach (var kvp in studentAndPoints
                .OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var kvp in submissions
                .OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
