using System;

namespace _004._Refactoring_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int num = 2; num <= number; num++)
            {
                bool isPrime = true;
                for (int divider = 2; divider < num; divider++)
                {
                    if (num % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                Console.WriteLine("{0} -> {1}", num, isPrime.ToString().ToLower());
            }
        }
    }
}
