using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < counter; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int command = input[0];

                if(command == 1)
                {
                    for (int k = 1; k < input.Length; k++)
                    {
                        stack.Push(input[k]);
                    }
                }
                else if(command == 2)
                {
                    if(stack.Count == 0)
                    {
                        continue;
                    }
                    stack.Pop();
                }
                else if(command == 3)
                {
                    if (stack.Count == 0)
                    {
                        continue;
                    }
                    int maxNumber = stack.Max();
                    Console.WriteLine(maxNumber);
                }
                else if(command == 4)
                {
                    if (stack.Count == 0)
                    {
                        continue;
                    }
                    int minNumber = stack.Min();
                    Console.WriteLine(minNumber);
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
