using System;
using System.Linq;
namespace Trian
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagonsCount = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] peopleInWagons = new int[wagonsCount];

            for (int i = 0; i < wagonsCount; i++)
            {
                int people = int.Parse(Console.ReadLine());
                sum += people;
                peopleInWagons[i] = people;
            }
            Console.WriteLine(string.Join(" ", peopleInWagons));
            Console.WriteLine(sum);
        }
    }
}
