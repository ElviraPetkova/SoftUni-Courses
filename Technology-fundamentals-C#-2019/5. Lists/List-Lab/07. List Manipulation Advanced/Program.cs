using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            bool changeList = false;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] tokens = input.Split();

                string command = tokens[0];

                /* Add {number}: add a number to the end of the list.
                   Remove {number}: remove a number from the list.
                   RemoveAt {index}: remove a number at a given index.
                   Insert {number} {index}: insert a number at a given index. 

                 Contains {number} – check if the list contains the number and if so - print "Yes", otherwise print "No such number".
                 PrintEven – print all the even numbers, separated by a space.
                 PrintOdd – print all the odd numbers, separated by a space.
                 GetSum – print the sum of all the numbers.
                 Filter {condition} {number} – print all the numbers that fulfill the given condition. The condition will be either '<', '>', ">=", "<=".
 */

                if (command == "Add")
                {
                    int number = int.Parse(tokens[1]);
                    listOfNumbers.Add(number);

                    changeList = true;
                }
                else if (command == "Remove")
                {
                    int number = int.Parse(tokens[1]);
                    listOfNumbers.Remove(number);

                    changeList = true;
                }
                else if (command == "RemoveAt")
                {
                    int index = int.Parse(tokens[1]);
                    listOfNumbers.RemoveAt(index);

                    changeList = true;
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    listOfNumbers.Insert(index, number);

                    changeList = true;
                }
                else if(command == "Contains")
                {
                    int number = int.Parse(tokens[1]);
                    if (listOfNumbers.Contains(number))
                    {
                        Console.WriteLine("yes");
                    }
                    else
                    {
                        Console.WriteLine("no");
                    }
                }
                else if(command == "PrintEven")
                {
                    var evenNumbers = listOfNumbers.Where(x => x % 2 == 0).ToList();

                    Console.WriteLine(string.Join(" ", evenNumbers));
                }
                else if(command == "PrintOdd")
                {
                    var oddNumbers = listOfNumbers.Where(x => x % 2 == 1).ToList();

                    Console.WriteLine(string.Join(" ", oddNumbers));
                }
                else if(command == "GetSum")
                {
                    int sumOfNumbers = listOfNumbers.Sum();

                    Console.WriteLine(sumOfNumbers);
                }
                else if(command == "Filter")
                {
                    string filterElement = tokens[1];
                    int filterNumber = int.Parse(tokens[2]);

                    var resultList = FilteringListByGivenFilter(listOfNumbers, filterElement, filterNumber).ToList();

                    Console.WriteLine(string.Join(" ", resultList));
                }
            }

            if (changeList)
            {
                Console.WriteLine(string.Join(" ", listOfNumbers));
            }
        }

        private static List<int> FilteringListByGivenFilter(List<int> listOfNumbers, string filterElement, int filterNumber)
        {
            var result = new List<int>();

            switch (filterElement)
            {
                case ">":
                    result = listOfNumbers.Where(x => x > filterNumber).ToList();
                    break;

                case ">=":
                    result = listOfNumbers.Where(x => x >= filterNumber).ToList();
                    break;

                case "<":
                    result = listOfNumbers.Where(x => x < filterNumber).ToList();
                    break;

                case "<=":
                    result = listOfNumbers.Where(x => x <= filterNumber).ToList();
                    break;
            }

            return result;
        }
    }
}
