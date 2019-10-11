using System;
using System.Linq;

namespace _01._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            double averange = numbers.Average();

            long[] numberMoreAverange = numbers.Where(x => x > averange).ToArray();
            Array.Sort(numberMoreAverange);
            Array.Reverse(numberMoreAverange);

            int lenght = 0;
            if(numberMoreAverange.Length == 0)
            {
                Console.WriteLine("No");
                return;
            }
            else if(numberMoreAverange.Length < 5)
            {
                lenght = numberMoreAverange.Length;
            }
            else
            {
                lenght = 5;
            }

            long[] topNumbers = numberMoreAverange.Take(lenght).ToArray();

            Console.WriteLine(string.Join(" ", topNumbers));
        }
    }
}
