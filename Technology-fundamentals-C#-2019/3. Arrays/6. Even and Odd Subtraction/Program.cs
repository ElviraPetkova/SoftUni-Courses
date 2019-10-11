using System;
using System.Linq;

namespace _6._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int evenSum = numbers.Where(x => x % 2 == 0).Sum();
            int oddSum = numbers.Where(x => x % 2 == 1).Sum();
            int subtration = evenSum - oddSum;
            Console.WriteLine(subtration);
        }
    }
}
