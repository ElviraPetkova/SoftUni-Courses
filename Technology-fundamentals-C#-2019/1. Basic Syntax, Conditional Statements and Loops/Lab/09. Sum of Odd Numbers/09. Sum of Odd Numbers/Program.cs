using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int counter = 0;
            int sum = 0;

            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
                sum += i;
                counter++;
                if (counter == number)
                {
                    break;
                }
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
