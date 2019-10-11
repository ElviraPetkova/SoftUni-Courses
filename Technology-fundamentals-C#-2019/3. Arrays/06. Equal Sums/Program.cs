using System;
using System.Linq;

namespace _06._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (arrayOfNumbers.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }

            int rightSum = arrayOfNumbers.Sum();
            int leftSum = 0;
            bool isEqualsSum = false;

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                rightSum -= arrayOfNumbers[i];
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isEqualsSum = true;
                    break;
                }
                leftSum += arrayOfNumbers[i];
            }

            if (isEqualsSum == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
