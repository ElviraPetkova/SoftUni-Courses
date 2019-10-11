using System;

namespace _04._Print_and_sum
{
    class Program
    {
        static void Main()
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            int sumOfNumber = 0;

            for (int i = startNumber; i <= endNumber; i++)
            {
                Console.Write(i + " ");
                sumOfNumber += i;
            }

            Console.WriteLine();
            Console.WriteLine($"Sum: {sumOfNumber}");

        }
    }
}
