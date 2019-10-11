using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());

            int[] firstArray = new int[lenght];
            int[] secondArray = new int[lenght];

            for (int i = 0; i < lenght; i++)
            {
                int[] twoNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int firstNumber = twoNumbers[0];
                int secondNumber = twoNumbers[1];

                if(i % 2 == 0)
                {
                    firstArray[i] = firstNumber;
                    secondArray[i] = secondNumber;
                }
                else
                {
                    firstArray[i] = secondNumber;
                    secondArray[i] = firstNumber;
                }
            }

            Console.WriteLine(string.Join(" ",firstArray));
            Console.WriteLine(string.Join(" ",secondArray));
        }
    }
}
