using System;
using System.Collections.Generic;
using System.Linq;

namespace GrainOfSands
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequance = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "Mort")
            {
                string[] commands = command.Split().ToArray();

                if (commands[0] == "Add")
                {
                    sequance.Add(int.Parse(commands[1]));
                }
                else if (commands[0] == "Remove")
                {
                    if (sequance.Contains(int.Parse(commands[1])))
                    {
                        sequance.Remove(int.Parse(commands[1]));
                    }
                    else if (int.Parse(commands[1]) <= sequance.Count)
                    {
                        sequance.RemoveAt(int.Parse(commands[1]));
                    }
                }
                else if (commands[0] == "Replace")
                {
                    if (sequance.Contains(int.Parse(commands[1])))
                    {
                        int value = sequance.IndexOf(int.Parse(commands[1]));
                        sequance.RemoveAt(value);
                        sequance.Insert(value, int.Parse(commands[2]));
                    }
                }
                else if (commands[0] == "Increase")
                {
                    bool flag = false;

                    for (int i = 0; i < sequance.Count; i++)
                    {
                        if (sequance[i] > int.Parse(commands[1]))
                        {
                            for (int j = 0; j < sequance.Count; j++)
                            {
                                sequance[j] = int.Parse(commands[1]);
                                flag = true;
                            }
                            break;
                        }

                    }
                    if (flag == false)
                    {
                        int valueOfLastIndex = sequance.IndexOf(sequance.Count - 1);

                        for (int k = 0; k < sequance.Count; k++)
                        {
                            sequance[k] += sequance.Last();
                        }
                    }
                }
                else if (commands[0] == "Collapse")
                {
                    sequance.RemoveAll(e => e < int.Parse(commands[1]));
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", sequance));
        }
    }
}

