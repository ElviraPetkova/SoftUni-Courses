using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int originalLenght = numbers.Count;

            for (int i = 0; i < originalLenght / 2; i++)
            {
                int first = numbers[i];
                int last = numbers[numbers.Count - 1];
                numbers[i] = first + last;
                numbers.RemoveAt(numbers.Count - 1);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
