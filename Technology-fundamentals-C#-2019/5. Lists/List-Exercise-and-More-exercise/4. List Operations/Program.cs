using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "End")
                {
                    break;
                }

                string[] tokens = input.Split();
                string command = tokens[0];

                if(command == "Add")
                {
                    int value = int.Parse(tokens[1]);

                    listOfIntegers.Add(value);
                }
                else if(command == "Insert")
                {
                    int value = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);

                    bool existIndex = CheckingIndex(listOfIntegers, index);
                    if (existIndex)
                    {
                        listOfIntegers.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if(command == "Remove")
                {
                    int index = int.Parse(tokens[1]);

                    bool existIndex = CheckingIndex(listOfIntegers, index);
                    if(existIndex)
                    {
                        listOfIntegers.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if(command == "Shift")
                {
                    string direction = tokens[1];
                    int count = int.Parse(tokens[2]);

                    ShiftingNumbersPerCount(listOfIntegers, direction, count);
                }
            }

            Console.WriteLine(string.Join(" ", listOfIntegers));
        }

        private static void ShiftingNumbersPerCount(List<int> listOfIntegers, string direction, int count)
        {
            for (int i = 0; i < count; i++)
            {
                if(direction == "left") //first is last
                {
                    ShiftLeft(listOfIntegers);
                }
                else if(direction == "right") //last is first
                {
                    ShiftRight(listOfIntegers);
                }
            }
        }

        private static void ShiftRight(List<int> listOfIntegers)
        {
            int last = listOfIntegers[listOfIntegers.Count - 1];
            for (int i = listOfIntegers.Count - 1; i > 0; i--)
            {
                listOfIntegers[i] = listOfIntegers[i - 1];
            }
            listOfIntegers[0] = last;
        }

        private static void ShiftLeft(List<int> listOfIntegers)
        {
            int first = listOfIntegers[0];
            for (int i = 0; i < listOfIntegers.Count - 1; i++)
            {
                listOfIntegers[i] = listOfIntegers[i + 1];
            }
            listOfIntegers[listOfIntegers.Count - 1] = first;
        }

        private static bool CheckingIndex(List<int> listOfIntegers, int index)
        {
            if(index < 0 || index > listOfIntegers.Count)
            {
                return false;
            }

            return true;
        }
    }
}
