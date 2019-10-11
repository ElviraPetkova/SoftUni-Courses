using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .ToArray();

            int lenght = 3;
            if (numbers.Length < 3)
            {
                lenght = numbers.Length;
            }

            int[] topNumbers = numbers.Take(lenght).ToArray();

            Console.WriteLine(string.Join(" ", topNumbers));
        }
    }
}
