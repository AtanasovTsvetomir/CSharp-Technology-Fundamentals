﻿using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string day = string.Empty;
            switch (input)
            {
                case "1":
                    day = "Monday";
                    break;
                case "2":
                    day = "Tuesday";
                    break;
                case "3":
                    day = "Wednesday";
                    break;
                case "4":
                    day = "Thursday";
                    break;
                case "5":
                    day = "Friday";
                    break;
                case "6":
                    day = "Saturday";
                    break;
                case "7":
                    day = "Sunday";
                    break;
                default:
                    Console.WriteLine("Invalid day!");
                    break;
            }
            Console.WriteLine(day);
        }
    }
}
