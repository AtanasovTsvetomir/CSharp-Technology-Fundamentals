using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var names = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var name in names)
            {
                Regex regex = new Regex("^[A-Z][a-z]+ [A-Z][a-z]+$");
                bool hasMatch = regex.Match(name).Success;
                if (hasMatch)
                {
                    Console.Write(name + " ");
                }
            }
        }
    }
}
