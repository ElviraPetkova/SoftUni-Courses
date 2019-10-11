using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Quests_Journal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine()
                .Split(", ")
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Retire!")
                {
                    break;
                }

                string[] tokens = input.Split(" - ");

                string command = tokens[0];
                string quest = tokens[1];

                /*  •	"Start - {quest}" – Receiving this command, you should add the given quest in your journal. If the quest already exists, you should skip this line.
                    •	"Complete - {quest}" – You should remove the quest from your journal, if it exists.
                    •	"Side Quest - {quest}:{sideQuest}" – You should check if the quest exists, if so, add the side quest after the quest. Note that you shouldn`t add the sideQuest if it already exists.
                    •	"Renew – {quest}" – If the given quest exists, you should change its position and put it last in your journal. */


                if (command == "Start")
                {
                    if(journal.Contains(quest) == false)
                    {
                        journal.Add(quest);
                    }
                }
                else if(command == "Complete")
                {
                    if (journal.Contains(quest))
                    {
                        journal.Remove(quest);
                    }
                }
                else if(command == "Side Quest")
                {
                    string[] newInfo = quest.Split(':');
                    string trueQuest = newInfo[0];
                    string sideQuest = newInfo[1];

                    if (journal.Contains(trueQuest) && journal.Contains(sideQuest) == false)
                    {
                        int index = journal.IndexOf(trueQuest);
                        journal.Insert(index + 1, sideQuest);
                    }
                }
                else if(command == "Renew")
                {
                    if (journal.Contains(quest))
                    {
                        journal.Remove(quest);
                        journal.Add(quest);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", journal));
        }
    }
}
