using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            var collection = new Dictionary<string, string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];

                if (command == "register")
                {
                    string userName = input[1].ToString();
                    string carNumber = input[2].ToString();

                    if (collection.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {carNumber}");
                    }
                    else
                    {
                        collection[userName] = carNumber;
                        Console.WriteLine($"{userName} registered {carNumber} successfully");
                    }
                }
                else if(command == "unregister")
                {
                    string userName = input[1].ToString();

                    if (!collection.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        collection.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                }
            }

            foreach (var usernames in collection)
            {
                Console.WriteLine($"{usernames.Key} => {usernames.Value}");
            }
        }
    }
}
