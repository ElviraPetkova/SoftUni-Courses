using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rangeArgs = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int start = rangeArgs[0];
            int end = rangeArgs[1];

            string typeNumbers = Console.ReadLine();

            List<int> numbers = new List<int>();

            Predicate<int> filter = x => typeNumbers == "odd" ? x % 2 != 0 : x % 2 == 0;

            for (int i = start; i <= end; i++)
            {
                numbers.Add(i);
            }

            Console.WriteLine(string.Join(" ", numbers.Where(x => filter(x))));
        }
    }
}
