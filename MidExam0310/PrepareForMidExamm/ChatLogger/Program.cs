using System;
using System.Collections.Generic;
using System.Linq;
namespace ChatLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<string> output = new List<string>();
            while (command != "end")
            {
                List<string> commands = command.Split().ToList();
                if (commands[0] == "Chat")
                {
                    output.Add(commands[1]);
                }
                else if (commands[0] == "Delete")
                {
                    if (output.Contains(commands[1]))
                    {
                        output.Remove(commands[1]);
                    }
                }
                else if (commands[0] == "Edit")
                {
                    int messageToEdit = output.IndexOf(commands[1]);
                    int editedMessage = output.IndexOf(commands[2]);
                    output.RemoveAt(messageToEdit);
                    output.Insert(messageToEdit, commands[2]);
                }
                else if (commands[0] == "Pin")
                {
                    int indexOfMessage = output.IndexOf(commands[1]);
                    output.RemoveAt(indexOfMessage);
                    output.Add(commands[1]);
                }
                else if (commands[0] == "Spam")
                {
                    commands.RemoveAt(0);
                    for (int i = 0; i < commands.Count; i++)
                    {
                        output.Add(commands[i]);
                    }
                }

                command = Console.ReadLine();
            }
            foreach (var message in output)
            {
                Console.WriteLine(message);
            }
        }
    }
}
