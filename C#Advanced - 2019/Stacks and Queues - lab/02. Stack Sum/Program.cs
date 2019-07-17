using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOfNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stackOfNumbers = new Stack<int>(arrayOfNumbers);

            while (true)
            {
                string input = Console.ReadLine().ToLower();
                if(input == "end")
                {
                    break;
                }
                var tokens = input.Split();
                string command = tokens[0];
                if(command == "add")
                {
                    int firstNumber = int.Parse(tokens[1]);
                    int secondNumber = int.Parse(tokens[2]);

                    stackOfNumbers.Push(firstNumber);
                    stackOfNumbers.Push(secondNumber);
                }
                else if(command == "remove")
                {
                    int countOfRemove = int.Parse(tokens[1]);

                    if(countOfRemove <= stackOfNumbers.Count)
                    {
                        for (int i = 1; i <= countOfRemove; i++)
                        {
                            stackOfNumbers.Pop();
                        }
                    }

                }
            }

            int sum = 0;
            if(stackOfNumbers.Count > 0)
            {
                sum = stackOfNumbers.Sum();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
