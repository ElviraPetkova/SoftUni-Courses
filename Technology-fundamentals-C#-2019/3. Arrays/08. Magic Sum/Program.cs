using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length - 1; i++)
            {
                int firstNum = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    int secondNum = array[j];
                    if(firstNum + secondNum == magicSum)
                    {
                        Console.WriteLine($"{firstNum} {secondNum}");
                    }
                }
            }
        }
    }
}
