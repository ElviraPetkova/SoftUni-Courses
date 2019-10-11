using System;

namespace _001._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int[] arrayOfNumbers = { firstNum, secondNum, thirdNum };
            Array.Sort(arrayOfNumbers);
            Array.Reverse(arrayOfNumbers);

            foreach (int number in arrayOfNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
