using System;

namespace _02._Division
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int divisible = 0;
            bool isDivisible = true;

            if (number % 10 == 0)
            {
                divisible = 10;
            }
            else if (number % 7 == 0)
            {
                divisible = 7;
            }
            else if (number % 6 == 0)
            {
                divisible = 6;
            }
            else if (number % 3 == 0)
            {
                divisible = 3;
            }
            else if (number % 2 == 0)
            {
                divisible = 2;
            }
            else
            {
                isDivisible = false;
            }

            if (isDivisible)
            {
                Console.WriteLine($"The number is divisible by {divisible}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
