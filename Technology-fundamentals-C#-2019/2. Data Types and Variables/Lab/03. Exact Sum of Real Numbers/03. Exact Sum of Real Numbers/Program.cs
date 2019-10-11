using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main()
        {
            int counterOfNumbers = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < counterOfNumbers; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}
