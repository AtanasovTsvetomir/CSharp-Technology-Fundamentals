using System;

namespace CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            triangleAreaMethod(width, height);
        
        }

        private static void triangleAreaMethod(int widht, int height)
        {
            int triangleArea = widht * height;
            Console.WriteLine(triangleArea);
        }
    }
}
