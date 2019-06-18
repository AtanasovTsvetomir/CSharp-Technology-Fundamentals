using System;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());
            int maxSnowballSnow = 0;
            int maxSnowballTime = 0;
            int maxSnowballQuality = 0;
            double max = 0;

            for (int i = 0; i < numberOfSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                int div = snowballSnow / snowballTime;

                double snowballValue = Math.Pow(div, snowballQuality);
                if (snowballValue > max)
                {
                    max = snowballValue;
                    maxSnowballSnow = snowballSnow;
                    maxSnowballTime = snowballTime;
                    maxSnowballQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{maxSnowballSnow} : {maxSnowballTime} = {max} ({maxSnowballQuality})");
        }
    }
}
