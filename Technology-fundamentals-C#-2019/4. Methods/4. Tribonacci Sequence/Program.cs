using System;

namespace _4.Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            if(counter == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                int[] arrayOfTribonacci = TribonacciSeguence(counter);
                Console.WriteLine(string.Join(" ", arrayOfTribonacci));
            }
        }

        private static int[] TribonacciSeguence(int counter)
        {
            //tribonacciNumber = a + b +c;
            int[] tribonacci = new int[counter];
            tribonacci[0] = 1;

            int a = 0;
            int b = 0;
            int c = 1;

            for (int i = 1; i < tribonacci.Length; i++)
            {
                tribonacci[i] = a + b + c;
                a = b;
                b = c;
                c = tribonacci[i];
            }

            return tribonacci;
        }
    }
}
