using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            
            StringBuilder sb = new StringBuilder();

            var pattern = @"^[A-Z][a-z]+ [A-Z][a-z]+$";
            Regex order = new Regex(pattern);

            foreach (var name in input)
            {
                if (order.IsMatch(name))
                {
                    Console.WriteLine(name + " ");
                }
            }
        }
    }
}
