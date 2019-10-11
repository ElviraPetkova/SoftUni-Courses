using System;
using System.Linq;

namespace _7._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < firstArray.Length; i++)
            {
                int firstNum = firstArray[i];
                int secundNum = secondArray[i];
                if (firstNum != secundNum)
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
            }

            int sum = firstArray.Sum();
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
