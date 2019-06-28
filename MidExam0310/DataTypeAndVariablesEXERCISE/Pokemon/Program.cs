using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int halfPokePower = pokePower / 2;
            int counter = 0;
            while (pokePower >= distance)
            {
                pokePower -= distance;
                counter++;
                if (halfPokePower == pokePower)
                {
                    if (exhaustionFactor != 0)
                    {
                        pokePower /= exhaustionFactor;
                    }
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(counter);
        }
    }
}
