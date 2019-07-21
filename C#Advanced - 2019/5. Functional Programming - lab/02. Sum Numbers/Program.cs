using System;
using System.Linq;

namespace _02._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[]
                    {',', ' '},
                    StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int count = numbers.Count;
            int sum = numbers.Sum();

            Console.WriteLine(count);
            Console.WriteLine(sum);
        }
    }
}
