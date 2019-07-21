using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());

            var collectionOfDividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var numbers = new List<int>();

            for (int i = 1; i <= end; i++)
            {
                var isDivisible = true;
                foreach (var item in collectionOfDividers)
                {
                    Predicate<int> isNotDivisor = x => i % x != 0;
                    if (isNotDivisor(item))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    numbers.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
