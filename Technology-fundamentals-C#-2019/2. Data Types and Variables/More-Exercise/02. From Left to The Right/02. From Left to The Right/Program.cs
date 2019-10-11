using System;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            long maxNumber = long.MinValue;

            for (int count = 1; count <= num; count++)
            {
                string textFromTwoNumber = Console.ReadLine();
                string[] numbers = textFromTwoNumber.Split();

                long[] parsedNumbers = new long[numbers.Length];
                for (int i = 0; i < numbers.Length; i++)
                {
                    parsedNumbers[i] = long.Parse(numbers[i]);
                }

                maxNumber = Math.Max(parsedNumbers[0], parsedNumbers[1]);

                long sumFromOneMaxNumber = 0;
                while (maxNumber != 0)
                {
                    long lastNumFromNumber = maxNumber % 10;
                    sumFromOneMaxNumber += lastNumFromNumber;
                    maxNumber /= 10;
                }

                Console.WriteLine(Math.Abs(sumFromOneMaxNumber));

            }
        }
    }
}
