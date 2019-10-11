using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int numberCopy = number;
            int result = 0;
            int sumOfFactorial = 0;

            while (number != 0)
            {
                result = number % 10;
                number /= 10;

                int factorial = 1;
                for (int a = 2; a <= result; a++)
                {
                    factorial *= a;
                }
                sumOfFactorial += factorial;
            }

            if (sumOfFactorial == numberCopy)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
