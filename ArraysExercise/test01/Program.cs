using System;
using System.Linq;
namespace test01
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] ages = { 20, 25, 32 };
            string[] names = input.Split(" ").ToArray();
            Console.WriteLine(input);
        }
    }
}
