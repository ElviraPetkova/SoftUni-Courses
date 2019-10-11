using System;

namespace _07.Math_Power
{
    class Program
    {
        public static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());
            double numberOfPow = (double)CalculateNumberOfPow(number, pow);
            Console.WriteLine(numberOfPow);
        }

        public static double CalculateNumberOfPow(double num, int pow)
        {
            double result = Math.Pow(num, pow);

            return result;
        }
    }
}
