using System;
using System.Linq;

namespace _5._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //int sumOfEvenNumbers = numbers.Where(x => x % 2 == 0).Sum();
            //Console.WriteLine(sumOfEvenNumbers);

            int sumOfEvenNumbers = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    sumOfEvenNumbers += numbers[i];
                }
            }

            Console.WriteLine(sumOfEvenNumbers);
        }
    }
}
