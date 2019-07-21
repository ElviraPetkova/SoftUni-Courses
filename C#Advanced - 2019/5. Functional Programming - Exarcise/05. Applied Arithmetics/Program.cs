using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, List<int>> addFunc = x => x.Select(y => y += 1).ToList();
            Func<List<int>, List<int>> multiplyFunc = x => x.Select(y => y * 2).ToList();
            Func<List<int>, List<int>> subtractFunc = x => x.Select(y => y -= 1).ToList();
            Action<List<int>> printAction = x => Console.WriteLine(string.Join(" ", x));

            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if(command == "add")
                {
                    numbers = addFunc(numbers);
                }
                else if (command == "multiply")
                {
                    numbers = multiplyFunc(numbers);
                }
                else if (command == "subtract")
                {
                    numbers = subtractFunc(numbers);
                }
                else if (command == "print")
                {
                    printAction(numbers);
                }
                else if (command == "end")
                {
                    break;
                }

            }
        }
    }
}
