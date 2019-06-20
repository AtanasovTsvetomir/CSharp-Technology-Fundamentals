using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            var collection = new Dictionary<string, List<string>>();

            while ((command = Console.ReadLine()) != "end")
            {
                string[] courseAndStudent = command.Split(" : ");

                string course = courseAndStudent[0];
                string student = courseAndStudent[1];

                if (!collection.ContainsKey(course))
                {
                    collection.Add(course, new List<string>());
                }
                collection[course].Add(student);
            }

            foreach (var courses in collection.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{courses.Key}: {courses.Value.Count}");

                foreach (var student in courses.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
