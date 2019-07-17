using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var arrayFromNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int countOfNumbersPerPush = numbers[0]; //N - push
            int countOfNumbersPerPop = numbers[1]; //S
            int numbersPerSearh = numbers[2]; //X

            Queue<int> queueOfNumbers = new Queue<int>();

            //push numbers in stack
            for (int i = 0; i < arrayFromNumbers.Length; i++)
            {
                int currentNumber = arrayFromNumbers[i];
                queueOfNumbers.Enqueue(currentNumber);
            }

            int counter = Math.Min(queueOfNumbers.Count, countOfNumbersPerPop);
            for (int i = 0; i < counter; i++)
            {
                queueOfNumbers.Dequeue();
            }

            int smallNumber = 0;
            if (queueOfNumbers.Count > 0)
            {
                smallNumber = queueOfNumbers.Min();
            }

            bool haveNumber = false;
            int countPerStack = queueOfNumbers.Count;
            for (int i = 0; i < countPerStack; i++)
            {
                int currentNumber = queueOfNumbers.Dequeue();

                if (currentNumber == numbersPerSearh)
                {
                    //Console.WriteLine("true");
                    haveNumber = true;
                    break;
                }
            }

            if (!haveNumber)
            {
                Console.WriteLine(smallNumber);
            }
            else
            {
                Console.WriteLine($"{haveNumber.ToString().ToLower()}");
            }
        }
    }
}
