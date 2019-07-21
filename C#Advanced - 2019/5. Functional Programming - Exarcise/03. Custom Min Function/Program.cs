using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> printSmallest = Console.WriteLine;
            Func<List<int>, int> funcPerSmallest = x => x.Min();

            var number = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            printSmallest(funcPerSmallest(number));


            /* Second solution
            Action<int> printSmallest = Console.WriteLine;

            var number = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Func<int, int, bool> function = (x, y) => x < y;
            int min = int.MaxValue;
            for (int i = 0; i < number.Count; i++)
            {
                if (function(number[i], min))
                {
                    min = number[i];
                }
            }

            printSmallest(min); */
        }
    }
}
