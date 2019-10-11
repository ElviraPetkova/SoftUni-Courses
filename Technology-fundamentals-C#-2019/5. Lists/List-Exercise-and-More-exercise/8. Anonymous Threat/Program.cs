using System;
using System.Linq;
using System.Collections.Generic;

namespace _8._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfText = Console.ReadLine()
                .Split()
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "3:1")
                {
                    break;
                }

                string[] tokens = input.Split();
                string command = tokens[0];

                if(command == "merge")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);

                    if (startIndex > listOfText.Count - 1 || endIndex < 0)
                    {
                        continue;
                    }
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > listOfText.Count - 1)
                    {
                        endIndex = listOfText.Count - 1;
                    }

                    if (listOfText.Count == 1)
                    {
                        continue;
                    }

                    MergeVeluesInOneIndex(listOfText, startIndex, endIndex);
                }
                else if(command == "divide")
                {
                    int index = int.Parse(tokens[1]); 
                    int parts = int.Parse(tokens[2]);

                    string value = listOfText.ElementAt(index);
                    listOfText.RemoveAt(index);

                    List<string> newWords = Divide(value, parts);

                    listOfText.InsertRange(index, newWords);
                }
            }

            Console.WriteLine(string.Join(" ", listOfText));
        }

        private static List<string> Divide(string value, int parts)
        {
            int partLenght = value.Length / parts;
            int lastElement = partLenght + (value.Length % parts);

            List<string> newWords = new List<string>();

            for (int i = 0; i < parts; i++)
            {
                string newWord = value.Substring(i * partLenght, partLenght);

                if(i == parts - 1)
                {
                    newWord = value.Substring(i * partLenght, lastElement);
                }

                newWords.Add(newWord);
            }

            return newWords;
        }

        private static void MergeVeluesInOneIndex(List<string> listOfText, int startIndex, int endIndex)
        {
            string newValue = string.Empty;
            for (int i = startIndex; i <= endIndex; i++)
            {
                newValue += listOfText[i];
            }

            int lenght = (endIndex - startIndex) + 1;
            listOfText.RemoveRange(startIndex, lenght);
            listOfText.Insert(startIndex, newValue);
        }

    }
}
