using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfStrings = Console.ReadLine().Split(' ').ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "3:1")
                {
                    Console.WriteLine(string.Join(" ", listOfStrings));
                    break;
                }

                string[] tokens = input.Split(' ');

                string command = tokens[0];

                if(command == "merge")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);

                    if(listOfStrings.Count == 1)
                    {
                        continue;
                    }

                    MergingValuesFromStartToEndIndex(listOfStrings, startIndex, endIndex);
                }
                else if(command == "divide")
                {
                    int index = int.Parse(tokens[1]);
                    int partitions = int.Parse(tokens[2]);

                    DivideValueByPartitions(listOfStrings, index, partitions);
                }
            }
        }

        private static void DivideValueByPartitions(List<string> listOfStrings, int index, int partitions)
        {
            string text = listOfStrings[index];
            int lenghtOfText = text.Length;

            int lenghtOfElements = lenghtOfText / partitions;
            bool isDivide = true;
            if (lenghtOfText % partitions != 0)
            {
                isDivide = false;
            }

            List<string> newList = new List<string>();
            int startIndex = 0;
            int lenght = lenghtOfElements;
            for (int i = 1; i <= partitions; i++)
            {
                if (isDivide == false && i == partitions)
                {
                    lenght = lenghtOfText - startIndex;
                }
                string oneElement = text.Substring(startIndex, lenght);
                newList.Add(oneElement);
                startIndex += lenght;
            }

            listOfStrings.RemoveAt(index);
            listOfStrings.InsertRange(index, newList);
        }

        private static void MergingValuesFromStartToEndIndex(List<string> listOfStrings, int startIndex, int endIndex)
        {
            startIndex = CheckingStartIndex(listOfStrings, startIndex);
            endIndex = CheckingEndIndex(listOfStrings, endIndex);

            StringBuilder newText = new StringBuilder();

            for (int i = startIndex; i <= endIndex; i++)
            {
                newText.Append(listOfStrings[i]);
            }

            int lenghtOfRemove = endIndex + 1 - startIndex;

            listOfStrings.RemoveRange(startIndex, lenghtOfRemove);
            listOfStrings.Insert(startIndex, newText.ToString());
        }

        private static int CheckingEndIndex(List<string> listOfStrings, int endIndex)
        {
            if (endIndex > listOfStrings.Count - 1)
            {
                endIndex = listOfStrings.Count - 1;
            }

            return endIndex;
        }

        private static int CheckingStartIndex(List<string> listOfStrings, int startIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            else if (startIndex > listOfStrings.Count - 1)
            {
                startIndex = listOfStrings.Count - 1;
            }

            return startIndex;
        }
    }
}
