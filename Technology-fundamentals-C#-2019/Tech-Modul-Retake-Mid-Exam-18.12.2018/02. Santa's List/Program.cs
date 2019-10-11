using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Santa_s_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> kids = Console.ReadLine()
                .Split('&')
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Finished!")
                {
                    break;
                }

                string[] info = input.Split();

                /*  •	Bad {kidName} - adds a kid at the start of the list.  If the kid already exists skip this line.
                    •	Good {kidName} - removes the kid with the given name only if he exists in the list, otherwise skip this line.
                    •	Rename {oldName} {newName} – if the kid with the given old name exists change his name with the newer one. If he doesn't exist skip this line.
                    •	Rearrange {kidName} - If the kid exists in the list remove him from his current position and add him at the end of the list.
                */

                string command = info[0];
                string name = info[1];

                if(command == "Bad")
                {
                    if(kids.Contains(name) == false)
                    {
                        kids.Insert(0, name);
                    }
                }
                else if(command == "Good")
                {
                    if (kids.Contains(name))
                    {
                        kids.Remove(name);
                    }
                }
                else if(command == "Rename")
                {
                    int indexOfKid = kids.IndexOf(name);

                    if(indexOfKid != -1)
                    {
                        string newName = info[2];
                        kids[indexOfKid] = newName;
                    }
                }
                else if(command == "Rearrange")
                {
                    if (kids.Contains(name))
                    {
                        kids.Remove(name);
                        kids.Add(name);
                    }
                }

            }

            Console.WriteLine(string.Join(", ", kids));
        }
    }
}
