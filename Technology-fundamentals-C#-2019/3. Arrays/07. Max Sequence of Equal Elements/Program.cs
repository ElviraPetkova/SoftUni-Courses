using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxLenght = 0;
            int maxStartIndex = 0;
            int maxEndIndex = -1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                int startIndex = i;
                int lenght = 1;

                while (i < array.Length - 1 && array[i] == array[i + 1])
                {
                    lenght++;
                    i++;
                }

                if(lenght > maxLenght)
                {
                    maxLenght = lenght;
                    maxStartIndex = startIndex;
                    maxEndIndex = i;
                }
            }

            for (int i = maxStartIndex; i <= maxEndIndex; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
