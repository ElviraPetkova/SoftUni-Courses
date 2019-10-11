using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Grains_of_Sands
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Mort")
                {
                    Console.WriteLine(string.Join(" ", listOfNumbers));
                    break;
                }

                string[] splitedInput = input.Split(' ');
                string command = splitedInput[0];
                int value = int.Parse(splitedInput[1]);

                /* 
                    "Add {value}" - you have to add {value} to the end of the sequence.
                    "Remove {value}" - you have to remove the first element in the sequence with value equal to {value}. 
                            If there is no such element you have to check if {value} is a valid index and remove the element at that index. 
                            Else you should ignore that command. 
                    "Replace {value} {replacement}" you have to find the first occurrence of the element equal to {value} and 
                            replace its value with the {replacement}. 
                            If element equal to {value} doesn’t exists in the sequence you have to ignore this command.
                    "Increase {value}" you have to find the first element with value not less than {value} and 
                            increase the value of all elements in the sequence with its value. 
                            If no such element exists in the sequence, you have to take the last element from the sequence 
                            and then increase the value of all elements in the sequence with its value.
                    "Collapse {value}" you have to remove from the sequence every element with value less than {value}, 
                            if there are such elements.
                  */

                if(command == "Add")
                {
                    listOfNumbers.Add(value);
                }
                else if(command == "Remove")
                {
                    if (listOfNumbers.Contains(value))
                    {
                        int indexOfValue = listOfNumbers.IndexOf(value);
                        listOfNumbers.RemoveAt(indexOfValue);
                    }
                    else
                    {
                        if(value >= 0 && value < listOfNumbers.Count) //value == index of remove
                        {
                            listOfNumbers.RemoveAt(value);
                        }
                    }
                }
                else if(command == "Replace")
                {
                    int replacement = int.Parse(splitedInput[2]);

                    if (listOfNumbers.Contains(value))
                    {
                        int indexOfValue = listOfNumbers.IndexOf(value);
                        listOfNumbers[indexOfValue] = replacement;
                    }
                }
                else if(command == "Increase")
                {
                    IncreasingEveryElementMoreValue(listOfNumbers, value);
                }
                else if(command == "Collapse")
                {
                    listOfNumbers.RemoveAll(x => x < value);
                }
            }
        }

        private static void IncreasingEveryElementMoreValue(List<int> listOfNumbers, int value)
        {
            int[] valuesByMoreInput = listOfNumbers.FindAll(x => x >= value).ToArray();

            if(valuesByMoreInput.Length == 0) //=> don't have value more greating inputValue
            {
                value = listOfNumbers[listOfNumbers.Count - 1]; //=>value = last value of the list
            }
            else
            {
                value = valuesByMoreInput[0]; //=> value = first element
            }

            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                listOfNumbers[i] += value;
            }
        }
    }
}
