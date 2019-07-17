using System;
using System.Collections.Generic;
using System.Text;

namespace _09.__Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            Stack<string> stackOfText = new Stack<string>();
            StringBuilder text = new StringBuilder();

            for (int i = 0; i < counter; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int numberOfCommand = int.Parse(input[0]);
                /*
                 •	1 someString - appends someString to the end of the text
                 •	2 count - erases the last count elements from the text
                 •	3 index - returns the element at position index from the text
                 •	4 - undoes the last not undone command of type 1 / 2 and returns the text to the state before that operation */

                if(numberOfCommand == 1)
                {
                    string someText = input[1];

                    stackOfText.Push(text.ToString());
                    text.Append(someText);
                }
                else if(numberOfCommand == 2)
                {
                    int countOfElements = int.Parse(input[1]);
                    stackOfText.Push(text.ToString());
                    string newText = text.ToString().Substring(0, text.Length - countOfElements);
                    text.Clear();
                    text.Append(newText);
                }
                else if(numberOfCommand == 3)
                {
                    int index = int.Parse(input[1]);
                    Console.WriteLine(text[index - 1].ToString());
                }
                else if (numberOfCommand == 4)
                {
                    string newText = stackOfText.Pop();
                    text.Clear();
                    text.Append(newText);
                }
            }
        }
    }
}
