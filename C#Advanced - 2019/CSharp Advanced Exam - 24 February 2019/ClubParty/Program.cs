using System;
using System.Collections.Generic;
using System.Linq;

namespace ClubParty
{
    class Program
    {
        static void Main()
        {
            int capacity = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Stack<string> information = new Stack<string>(input);
            Queue<string> halls = new Queue<string>();

            Dictionary<string, List<int>> peopleAndHalls = new Dictionary<string, List<int>>();

            while (information.Any())
            {
                var currentChar = information.Peek();

                if (char.IsLetter(currentChar[0]))
                {
                    peopleAndHalls[currentChar] = new List<int>();
                    halls.Enqueue(currentChar);
                    information.Pop();
                    continue;
                }

                if(peopleAndHalls.Count == 0)
                {
                    information.Pop();
                    continue;
                }

                foreach (var item in peopleAndHalls)
                {
                    if(item.Value.Sum() + int.Parse(currentChar) <= capacity)
                    {
                        peopleAndHalls[item.Key].Add(int.Parse(currentChar));
                        information.Pop();
                        break;
                    }

                    if(item.Value.Sum() + int.Parse(currentChar) >= capacity && halls.Any())
                    {
                        Console.WriteLine($"{halls.Dequeue()} -> {string.Join(", ", item.Value)}");
                        peopleAndHalls.Remove(item.Key);
                    }

                    break;
                }
            }
           
        }
    }
}
