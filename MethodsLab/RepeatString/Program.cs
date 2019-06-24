using System;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            RepeatStringMethod(command, count);

        }

        private static void RepeatStringMethod(string command, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(command);
            }
            Console.WriteLine();
        }
    }
}
