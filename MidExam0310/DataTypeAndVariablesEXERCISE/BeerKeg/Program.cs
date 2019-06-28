using System;

namespace BeerKeg
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double max = 0;
            string name = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double total = (Math.PI) * (radius * radius) * height;

                if (total > max)
                {
                    max = total;
                    name = model;
                }

            }
            Console.WriteLine(name);
        }
    }
}
