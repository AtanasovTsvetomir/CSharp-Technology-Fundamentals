using System;
using System.Linq;
using System.Collections.Generic;


namespace SoftUniCoursePlaning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> scheduleOfLessons = Console.ReadLine()
                .Split(", ").ToList();
            string command = Console.ReadLine();

            while (command != "course start")
            {
                string[] modify = command.Split(':').ToArray();

                if (modify[0] == "Add")
                {
                    if (!scheduleOfLessons.Contains(modify[1]))
                    {
                        scheduleOfLessons.Add(modify[1]);
                    }
                }
                else if (modify[0] == "Insert")
                {
                    if (!scheduleOfLessons.Contains(modify[1]) && int.Parse(modify[2]) <= scheduleOfLessons.Count)
                    {
                        scheduleOfLessons.Insert(int.Parse(modify[2]), modify[1]);
                    }
                }
                else if (modify[0] == "Remove")
                {
                    if (scheduleOfLessons.Contains(modify[1]))
                    {
                        scheduleOfLessons.Remove(modify[1]);
                    }
                    else if (scheduleOfLessons.Contains($"{modify[1]}-Exercise"))
                    {
                        scheduleOfLessons.Remove($"{modify[1]}-Exercise");
                    }
                }
                else if (modify[0] == "Swap")
                {
                    if (scheduleOfLessons.Contains(modify[1]) && scheduleOfLessons.Contains(modify[2]))
                    {
                        int firstIndex = scheduleOfLessons.IndexOf(modify[1]);
                        int secondIndex = scheduleOfLessons.IndexOf(modify[2]);
                        scheduleOfLessons.RemoveAt(firstIndex);
                        scheduleOfLessons.Insert(firstIndex, modify[2]);
                        scheduleOfLessons.RemoveAt(secondIndex);
                        scheduleOfLessons.Insert(secondIndex, modify[1]);

                    }
                    else if (scheduleOfLessons.Contains($"{modify[1]}-Exercise") && scheduleOfLessons.Contains($"{modify[1]}-Exercise"))
                    {
                        int firstIndex = scheduleOfLessons.IndexOf($"{modify[1]}-Exercise");
                        int secondIndex = scheduleOfLessons.IndexOf($"{modify[2]}-Exercise");
                        scheduleOfLessons.RemoveAt(firstIndex);
                        scheduleOfLessons.Insert(firstIndex, $"{modify[2]}-Exercise");
                        scheduleOfLessons.RemoveAt(secondIndex);
                        scheduleOfLessons.Insert(secondIndex, $"{modify[1]}-Exercise");
                    }
                }
                else if (modify[0] == "Exercise")
                {
                    if (scheduleOfLessons.Contains(modify[1]))
                    {
                        int indexOfExercise = scheduleOfLessons.IndexOf(modify[1]);
                        if (!scheduleOfLessons.Contains($"{modify[1]}-Exercise"))
                        {
                            scheduleOfLessons.Insert(indexOfExercise + 1, $"{modify[1]}-Exercise");
                        }
                    }
                    else
                    {
                        scheduleOfLessons.Add(modify[1]);
                        scheduleOfLessons.Add($"{modify[1]}-Exercise");
                    }
                }

                command = Console.ReadLine();
            }

            for (int i = 1; i <= scheduleOfLessons.Count; i++)
            {
                Console.WriteLine($"{i}.{scheduleOfLessons[i-1]}");
            }
        }
    }
}
