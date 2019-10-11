using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethod
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Box<int> box = new Box<int>();

            for (int i = 0; i < count; i++)
            {
                int line = int.Parse(Console.ReadLine());
                box.Add(line);
            }

            int[] indexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            Swap(box.Data, firstIndex, secondIndex);
            Console.WriteLine(box);
        }

        public static void Swap<T>(List<T> listWithData, int firstIndex, int secondIndex)
        {
            T temp = listWithData[firstIndex];
            listWithData[firstIndex] = listWithData[secondIndex];
            listWithData[secondIndex] = temp;
        }
    }
}
