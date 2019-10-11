using System;
using System.Linq;

namespace _2._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] arrayFromNumbers = new int[number];

            for (int i = 0; i < number; i++)
            {
                arrayFromNumbers[i] = int.Parse(Console.ReadLine());
            }

            //for (int i = arrayFromNumbers.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(arrayFromNumbers[i] + " ");
            //}
            //Console.WriteLine();

            arrayFromNumbers = arrayFromNumbers.Reverse().ToArray();
            Console.WriteLine(string.Join(" ", arrayFromNumbers));
        }
    }
}
