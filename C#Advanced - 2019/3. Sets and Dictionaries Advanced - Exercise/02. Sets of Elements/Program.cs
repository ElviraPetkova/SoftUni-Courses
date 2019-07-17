using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] info = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < info[0] + info[1]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(i < info[0])
                {
                    firstSet.Add(number);
                }
                else
                {
                    secondSet.Add(number);
                }
                
            }

            int[] array = firstSet.ToArray();

            HashSet<int> uniqueSet = new HashSet<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (secondSet.Contains(array[i]))
                {
                    uniqueSet.Add(array[i]);
                }
            }

            Console.WriteLine(string.Join(" ", uniqueSet));
        }
    }
}
