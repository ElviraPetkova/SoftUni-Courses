using System;

namespace _8.Factorial_Division
{
    class Program
    {
        public static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{(FactorialDivision(firstNumber, secondNumber)):f2}");
        }

        public static double FactorialDivision(int firstNum, int secondNum)
        {
            double firstFactorial = Factorial(firstNum);
            double secondFactorial = Factorial(secondNum);
            double division = (double)firstFactorial / (double)secondFactorial;

            return division;
        }

        public static double Factorial(int firstNum)
        {
            double factorial = firstNum;

            for (int i = 1; i < firstNum; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
        }
    }
}
