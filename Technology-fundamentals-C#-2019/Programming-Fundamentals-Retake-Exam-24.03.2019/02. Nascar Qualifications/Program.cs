using System;
using System.Linq;

namespace _02._Nascar_Qualifications
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfNames = Console.ReadLine().Split(' ').ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end")
                {
                    Console.WriteLine(string.Join(" ~ ", listOfNames));
                    break;
                }

                var info = input.Split(' ');
                string command = info[0];
                string racer = info[1];

                if(command == "Race")
                {
                    //add the pilot on the last position, if he isn’t in the race.

                    if (listOfNames.Contains(racer) == false)
                    {
                        listOfNames.Add(racer);
                    }
                }
                else if(command == "Accident")
                {
                    //remove the racer from the race.

                    int index = listOfNames.IndexOf(racer);
                    if(index >= 0)
                    {
                        listOfNames.Remove(racer);
                    }
                }
                else if(command == "Box")
                {
                    //move the racer one position back, if he is in the race and he is not already last.

                    int index = listOfNames.IndexOf(racer);
                    if(index >= 0 && index != listOfNames.Count - 1)
                    {
                        listOfNames.Remove(racer);
                        listOfNames.Insert(index + 1, racer);
                    }
                }
                else if(command == "Overtake")
                {
                    int count = int.Parse(info[2]);

                    //move the racer the given count of positions forward, if he is in the race and the position is valid.

                    int index = listOfNames.IndexOf(racer);
                    if(index != -1)
                    {
                        if(index - count >= 0)
                        {
                            listOfNames.Remove(racer);
                            listOfNames.Insert(index - count, racer);
                        }
                    }
                }
            }
        }
    }
}
