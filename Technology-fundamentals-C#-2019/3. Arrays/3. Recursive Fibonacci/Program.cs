using System;

namespace _3._Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            if (count <= 1)
            {
                Console.WriteLine("1");
                return;
            }

            int numberOfFibonacciOfCount = FibonacciNumbers(count);
            Console.WriteLine(numberOfFibonacciOfCount);
        }

        private static int FibonacciNumbers(int count)
        {
            //fibanacci = a + b;
            //int a = 0; int b = 1; fibonacci[i] = a + b; a = b; b = fibonacci[i];
            int[] fibonacci = new int[count];

            fibonacci[0] = 1;
            fibonacci[1] = 1;

            for (int i = 2; i < fibonacci.Length; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            return fibonacci[fibonacci.Length - 1];
        }
    }
}
