using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var info = Console.ReadLine();

            var stackOfBrackets = new Stack<int>();

            for (int i = 0; i < info.Length; i++)
            {
                char currentChar = info[i];

                if (currentChar == '(')
                {
                    stackOfBrackets.Push(i);
                }
                else if(currentChar == ')')
                {
                    int startIndex = stackOfBrackets.Pop();
                    string contents = info.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(contents);
                }
            }
        }
    }
}
