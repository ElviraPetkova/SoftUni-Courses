using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int count = 1; count <= number; count++)
            {
                int sumOfDigits = 0;
                int digits = count;

                while (digits > 0)
                {
                    int oneDigit = digits % 10;
                    digits /= 10;
                    sumOfDigits += oneDigit;
                }

                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    Console.WriteLine($"{count} -> True");
                }
                else
                {
                    Console.WriteLine($"{count} -> False");
                }
            }
        }
    }
}
