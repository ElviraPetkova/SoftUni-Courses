using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int, int, int> sortFunc = (a, b) => a.CompareTo(b);
            Action<int[], int[]> print = (x , y) => Console.WriteLine($"{string.Join(" ", x)} {string.Join(" ", y)}");

            var evenNumbers = numbers
                .Where(x => x % 2 == 0)
                .ToArray();

            var oddNumbers = numbers
                .Where(x => x % 2 != 0)
                .ToArray();

            Array.Sort(evenNumbers, new Comparison<int>(sortFunc));
            Array.Sort(oddNumbers, new Comparison<int>(sortFunc));

            print(evenNumbers, oddNumbers);
            
        }
    }
}
