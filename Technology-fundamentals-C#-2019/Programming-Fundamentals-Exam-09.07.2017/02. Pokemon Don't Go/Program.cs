using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequenceOfIntegers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int sumOfRemovedElements = 0;

            while (true)
            {
                if(sequenceOfIntegers.Count == 0)
                {
                    Console.WriteLine(sumOfRemovedElements);
                    break;
                }

                int index = int.Parse(Console.ReadLine());
                int value = 0;

                if(index < 0)
                {
                    value = sequenceOfIntegers[0];

                    sequenceOfIntegers[0] = sequenceOfIntegers[sequenceOfIntegers.Count - 1];
                }
                else if(index > sequenceOfIntegers.Count - 1)
                {
                    value = sequenceOfIntegers[sequenceOfIntegers.Count - 1];

                    sequenceOfIntegers[sequenceOfIntegers.Count - 1] = sequenceOfIntegers[0];
                }
                else
                {
                    value = sequenceOfIntegers[index];

                    sequenceOfIntegers.RemoveAt(index);
                }

                sumOfRemovedElements += value;

                for (int i = 0; i < sequenceOfIntegers.Count; i++)
                {
                    int currentElement = sequenceOfIntegers[i];

                    if (currentElement <= value)
                    {
                        sequenceOfIntegers[i] += value;
                    }
                    else
                    {
                        sequenceOfIntegers[i] -= value;
                    }
                }
            }
        }
    }
}
