using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end")
                {
                    break;
                }

                string[] tokens = input.Split();

                string command = tokens[0];

                 /* Add {number}: add a number to the end of the list.
                    Remove {number}: remove a number from the list.
                    RemoveAt {index}: remove a number at a given index.
                    Insert {number} {index}: insert a number at a given index. */
                 
                if(command == "Add")
                {
                    int number = int.Parse(tokens[1]);
                    listOfNumbers.Add(number);
                }
                else if(command == "Remove")
                {
                    int number = int.Parse(tokens[1]);
                    listOfNumbers.Remove(number);
                }
                else if(command == "RemoveAt")
                {
                    int index = int.Parse(tokens[1]);
                    listOfNumbers.RemoveAt(index);
                }
                else if(command == "Insert")
                {
                    int number = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    listOfNumbers.Insert(index, number);
                }
            }

            Console.WriteLine(string.Join(" ", listOfNumbers));
        }
    }
}
