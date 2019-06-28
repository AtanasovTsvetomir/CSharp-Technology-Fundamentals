using System;
using System.Linq;
using System.Collections.Generic;

namespace QuestsJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string>journal = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();

            while (command != "Retire!")
            {
                string[] quest = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                
                if (quest[0] == "Start")
                {
                    if (!journal.Contains(quest[1]))
                    {
                        journal.Add(quest[1]);
                    }
                }
                else if (quest[0] == "Complete")
                {
                    if (journal.Contains(quest[1]))
                    {
                        journal.Remove(quest[1]);
                    }
                }
                else if (quest[0] == "Side Quest")
                {
                    string[] sideQuest = quest[1].Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();
                    
                    if (journal.Contains(sideQuest[0]))
                    {
                        int indexOfQuest = journal.IndexOf(sideQuest[0]);
                        if (!journal.Contains(sideQuest[1]))
                        {
                            journal.Insert(indexOfQuest + 1, sideQuest[1]);
                        }
                    }
                }
                else if (quest[0] == "Renew")
                {
                    if (journal.Contains(quest[1]))
                    {
                        int indexOfQuest = journal.IndexOf(quest[1]);
                        journal.RemoveAt(indexOfQuest);
                        journal.Add(quest[1]);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", journal));
        }
    }
}
