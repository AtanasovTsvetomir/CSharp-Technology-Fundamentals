using System;
using System.Linq;
using System.Collections.Generic;

namespace Santa_sList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialList = Console.ReadLine()
                .Split('&')
                .ToList();

            string command = Console.ReadLine();

            while (command != "Finished!")
            {
                string[] modify = command.Split().ToArray();

                TypeOfKind(initialList, modify);

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", initialList));
        }

        private static void TypeOfKind(List<string> initialList, string[] modify)
        {
            if (modify[0] == "Bad")
            {
                if (!initialList.Contains(modify[1]))
                {
                    initialList.Insert(0, modify[1]);
                }
            }
            else if (modify[0] == "Good")
            {
                if (initialList.Contains(modify[1]))
                {
                    initialList.Remove(modify[1]);
                }
            }
            else if (modify[0] == "Rename")
            {
                if (initialList.Contains(modify[1]))
                {
                    int oldName = initialList.IndexOf(modify[1]);
                    initialList.RemoveAt(oldName);
                    initialList.Insert(oldName, modify[2]);
                }
            }
            else if (modify[0] == "Rearrange")
            {
                if (initialList.Contains(modify[1]))
                {
                    initialList.Remove(modify[1]);
                    initialList.Add(modify[1]);
                }
            }
        }
    }
}
