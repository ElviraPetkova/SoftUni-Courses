using System;

namespace _10.Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 17; i <= number; i++)
            {
                if(DivideOfEightSumOfDigit(i) && OddDigitInNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool DivideOfEightSumOfDigit(int number)
        {
            int sumOfDigits = 0;
            bool isDivideEight = false;

            while (number > 0)
            {
                int digit = number % 10;
                number /= 10;
                sumOfDigits += digit;
            }

            if (sumOfDigits % 8 == 0)
            {
                isDivideEight = true;
            }

            return isDivideEight;
        }

        public static bool OddDigitInNumber(int number)
        {
            bool isOddDigit = false;
            while (number > 0)
            {
                int digit = number % 10;
                number /= 10;

                if(digit % 2 == 1)
                {
                    isOddDigit = true;
                }
            }

            return isOddDigit;
        }
    }
}
