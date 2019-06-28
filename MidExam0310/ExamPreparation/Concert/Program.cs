using System;
using System.Collections.Generic;
using System.Linq;

namespace Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            var totalTime = 0;

            var bandTime = new Dictionary<string, int>();
            var bandMembers = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "start of concert")
            {
                var command = input
                    .Split("; ",StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var action = command[0];
                var band = command[1];

                if (action == "Add")
                {
                    var members = command[2].Split(", ");

                    if (!bandMembers.ContainsKey(band))
                    {
                        bandMembers.Add(band, new List<string>());
                    }

                    for (int i = 0; i < members.Length; i++)
                    {
                        if (!bandMembers[band].Contains(members[i]))
                        {
                            bandMembers[band].Add(members[i]);
                        }
                    }
                }
                else if(action == "Play")
                {
                    var playTime = int.Parse(command[2]);
                    totalTime += playTime;

                    if (!bandTime.ContainsKey(band))
                    {
                        bandTime.Add(band, playTime);
                    }
                    else
                    {
                        bandTime[band] += playTime;
                    }
                }
            }
            var finalLine = Console.ReadLine();

            Console.WriteLine($"Total time: {totalTime}");

            foreach (var band in bandTime
                .OrderByDescending(x => x.Value)
               .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }

            foreach (var band in bandMembers)
            {
                if (band.Key == finalLine)
                {
                    Console.WriteLine($"{band.Key}");

                    foreach (var mem in band.Value)
                    {
                        Console.WriteLine($"=> {mem}");
                    }
                }
            }
        }
    }
}
