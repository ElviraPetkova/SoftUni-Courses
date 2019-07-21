using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToList();

            int divider = int.Parse(Console.ReadLine());

            Func<List<int>, List<int>> divedeByNumber = x => x.Where(y => y % divider != 0).ToList();
            Action<List<int>> printList = x => Console.WriteLine(string.Join(" ", x));

            numbers = divedeByNumber(numbers);
            printList(numbers);

        }
    }
}
