using System;
using System.Linq;
using System.Collections.Generic;

namespace _9._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int sumOfValue = 0;

            while (numbers.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());
                //TODO: If index < 0 || index > number.Count - 1

                int value = 0;
                if (index < 0)
                {
                    //index = 0;
                    value = numbers[0];
                    numbers[0] = numbers[numbers.Count - 1];
                }
                else if(index > numbers.Count - 1)
                {
                    value = numbers[numbers.Count - 1];
                    numbers[numbers.Count - 1] = numbers[0];
                }
                else
                {
                    value = numbers.ElementAt(index);
                    numbers.RemoveAt(index);
                    
                }

                sumOfValue += value;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if(numbers[i] <= value)
                    {
                        numbers[i] += value;
                    }
                    else if(numbers[i] > value)
                    {
                        numbers[i] -= value;
                    }
                }

            }

            Console.WriteLine(sumOfValue);

        }
    }
}
