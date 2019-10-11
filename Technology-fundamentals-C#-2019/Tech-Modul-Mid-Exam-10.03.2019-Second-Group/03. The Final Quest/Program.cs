using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._The_Final_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfWords = Console.ReadLine()
                .Split(' ')
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Stop")
                {
                    Console.WriteLine(string.Join(" ", listOfWords));
                    break;
                }

                string[] tokens = input.Split(' ');

                /*  -	Delete {index} – removes the word after the given index if it is valid.
                    -	Swap {word1} {word2} – find the given words in the collections if they exist and swap their places.
                    -	Put {word} {index} – add a word at the previous place {index} before the 
                        given one, if it exists.
                    -	Sort – you must sort the words in descending order.
                    -	Replace {word1} {word2} – find the second word {word2} in the collection (if it exists) and 
                        replace it with the first word – {word1}. */

                string command = tokens[0];
                if (command == "Delete")
                {
                    int index = int.Parse(tokens[1]);
                    if (index >= 0 && index < listOfWords.Count - 1)
                    {
                        listOfWords.RemoveAt(index + 1);
                    }
                }
                else if (command == "Swap")
                {
                    string firstWord = tokens[1];
                    string secondWord = tokens[2];

                    int indexPerFirstWord = listOfWords.IndexOf(firstWord);
                    int indexPerSecondWord = listOfWords.IndexOf(secondWord);

                    if (indexPerFirstWord != -1 && indexPerSecondWord != -1)
                    {
                        listOfWords[indexPerFirstWord] = secondWord;
                        listOfWords[indexPerSecondWord] = firstWord;
                    }
                }
                else if (command == "Put")
                {
                    string word = tokens[1];
                    int index = int.Parse(tokens[2]);

                    if (index - 1 >= 0 && index - 2 < listOfWords.Count)
                    {
                        listOfWords.Insert(index - 1, word);
                    }
                }
                else if (command == "Sort")
                {
                    listOfWords.Sort();
                    listOfWords.Reverse();
                }
                else if (command == "Replace")
                {
                    string newWord = tokens[1];
                    string oldWord = tokens[2];

                    if (listOfWords.Contains(oldWord))
                    {
                        int index = listOfWords.IndexOf(oldWord);
                        listOfWords[index] = newWord;
                    }
                }
            }
        }
    }
}
