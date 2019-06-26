using System;
using System.Linq;
using System.Collections.Generic;

namespace LastStop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> collection = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] type = command.Split().ToArray();
                

                if (type[0] == "Change")
                {
                    if (collection.Contains(int.Parse(type[1])))
                    {
                        int index = collection.IndexOf(int.Parse(type[1]));
                        collection.RemoveAt(index);
                        collection.Insert(index, int.Parse(type[2]));
                    }
                }
                else if (type[0] == "Hide")
                {
                    if (collection.Contains(int.Parse(type[1])))
                    {
                        collection.Remove(int.Parse(type[1]));
                    }
                }
                else if (type[0] == "Switch")
                {
                    if (collection.Contains(int.Parse(type[1])) && collection.Contains(int.Parse(type[2])))
                    {
                        int firstIndex = collection.IndexOf(int.Parse(type[1]));
                        int secondIndex = collection.IndexOf(int.Parse(type[2]));
                        collection.RemoveAt(firstIndex);
                        collection.Insert(firstIndex, int.Parse(type[2]));
                        collection.RemoveAt(secondIndex);
                        collection.Insert(secondIndex, int.Parse(type[1]));
                    }
                }
                else if (type[0] == "Insert")
                {
                    if (int.Parse(type[1]) + 1 < collection.Count)
                    {
                        collection.Insert(int.Parse(type[1]) + 1, int.Parse(type[2]));
                    }
                }
                else if (type[0] =="Reverse")
                {
                    collection.Reverse();
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", collection));
        }
    }
}
