using System;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruits = "banana, kiwi, apple,banana, strawberry";
            Console.WriteLine(fruits.LastIndexOf("banana"));
        }
    }
}
