using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations__
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

            Stack<int> stackOfNumbers = new Stack<int>();

            //push numbers in stack
            for (int i = 0; i < arrayFromNumbers.Length; i++)
            {
                int currentNumber = arrayFromNumbers[i];
                stackOfNumbers.Push(currentNumber);
            }

            int counter = Math.Min(stackOfNumbers.Count, countOfNumbersPerPop);
            for (int i = 0; i < counter; i++)
            {
                stackOfNumbers.Pop();
            }

            int smallNumber = 0;
            if (stackOfNumbers.Count > 0)
            {
                smallNumber = stackOfNumbers.Min();
            }
            
            bool haveNumber = false;
            int countPerStack = stackOfNumbers.Count;
            for (int i = 0; i < countPerStack; i++)
            {
                int currentNumber = stackOfNumbers.Pop();

                if(currentNumber == numbersPerSearh)
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
