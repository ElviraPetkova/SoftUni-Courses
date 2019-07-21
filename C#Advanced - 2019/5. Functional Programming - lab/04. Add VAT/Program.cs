using System;
using System.Linq;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(x => x * 1.2)
                .ToList();

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}
