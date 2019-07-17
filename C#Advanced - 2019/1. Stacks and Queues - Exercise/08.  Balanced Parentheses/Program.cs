using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.__Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stackOfParentheses = new Stack<char>();

            var input = Console.ReadLine()
                .ToCharArray();

            char[] openParentheses = new char[] { '(', '{', '[' };

            bool isValid = true;
            if (!openParentheses.Contains(input[0]))
            {
                isValid = false;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if(openParentheses.Contains(input[i]))
                {
                    stackOfParentheses.Push(input[i]);
                    continue;
                }

                if(stackOfParentheses.Count == 0)
                {
                    isValid = false;
                    break;
                }
                
                if(stackOfParentheses.Peek() == '(' & input[i] == ')')
                {
                    stackOfParentheses.Pop();
                }
                else if (stackOfParentheses.Peek() == '{' & input[i] == '}')
                {
                    stackOfParentheses.Pop();
                }
                else if (stackOfParentheses.Peek() == '[' & input[i] == ']')
                {
                    stackOfParentheses.Pop();
                }
                else
                {
                    isValid = false;
                    break;
                }
            }

            if (isValid)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
