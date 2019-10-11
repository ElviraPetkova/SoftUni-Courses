using System;

namespace _1.Smallest_of_Three_Numbers
{
    class Program
    {
        public static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            PrintSmallesNumber(first, second, third);
        }

        public static void PrintSmallesNumber(int firstNum, int secondNum, int thirdNum)
        {
            int smallesNumber = Math.Min(firstNum, secondNum);
            smallesNumber = Math.Min(smallesNumber, thirdNum);
            Console.WriteLine(smallesNumber);
        }
    }
}
