using System;

namespace WatterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 0;

            for (int i = 1; i <= n; i++)
            {
                int water = int.Parse(Console.ReadLine());

                if (capacity + water <= 255)
                {
                    capacity += water;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                if (i == n)
                {
                    Console.WriteLine(capacity);
                }
            }
        }
    }
}
