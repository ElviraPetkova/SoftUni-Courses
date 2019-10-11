using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayFromNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arrayFromNumbers.Length - 1; i++)
            {
                int number = arrayFromNumbers[i];
                for (int j = i + 1; j < arrayFromNumbers.Length; j++)
                {
                    int nextNumber = arrayFromNumbers[j];
                    if (number <= nextNumber)
                    {
                        break;
                    }
                    else if(j == arrayFromNumbers.Length - 1)
                    {
                        Console.Write(number + " ");
                    }
                }
            }
            Console.WriteLine(arrayFromNumbers[arrayFromNumbers.Length - 1]);
        }
    }
}
