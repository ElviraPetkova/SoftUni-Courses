using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int counter = 1; counter <= number; counter++)
            {
                int sumOfDigits = 0;
                int digits = counter;
                while (digits > 0)
                {
                    sumOfDigits += (digits % 10);
                    digits /= 10;
                }

                bool isEguals = false;
                if ((sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11))
                {
                    isEguals = true;
                }
                Console.WriteLine($"{counter} -> {isEguals}");
            }
        }
    }
}
