using System;

namespace SoftUniRecepcion
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeEfficiency = int.Parse(Console.ReadLine());
            int secondEmployeeEfficiency = int.Parse(Console.ReadLine());
            int thirdEmployeeEfficiency = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            
            int studentPerHour = firstEmployeeEfficiency + secondEmployeeEfficiency + thirdEmployeeEfficiency;
            
            int hours = 0;
            int freeHour = 0;
            int counter = 0;

            while (true)
            {
                if (studentsCount <= 0)
                {
                    break;
                }
                counter++;

                if (counter % 4 == 0)
                {
                    freeHour++;
                    continue;
                }
                studentsCount -= studentPerHour;
                hours++;
            }

            int totalHours = hours + freeHour;
            Console.WriteLine($"Time needed: {totalHours}h.");
        }
    }
}
