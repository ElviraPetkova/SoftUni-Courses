using System;

namespace _09.Multiply_Evens_by_Odds
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvenAndOdds(Math.Abs(number)));
        }

        public static int GetMultipleOfEvenAndOdds(int number)
        {
            int multiple = GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
            return multiple;
        }

        public static int GetSumOfEvenDigits(int number)
        {
            return GetSumOfDigits(number, 0);
        }

        public static int GetSumOfOddDigits(int number)
        {
            return GetSumOfDigits(number, 1);
        }

        public static int GetSumOfDigits(int number, int expectedRemainder)
        {
            int sum = 0;

            while (number > 0)
            {
                int lastNum = number % 10;
                number /= 10;
                if (lastNum % 2 == expectedRemainder)
                {
                    sum += lastNum;
                }
            }

            return sum;
        }
    }
}
