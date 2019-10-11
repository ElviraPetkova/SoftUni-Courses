using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end")
                {
                    Console.WriteLine($"[{string.Join(", ", arrayOfNumbers)}]");
                    break;
                }

                string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];

                if(command == "exchange")
                {
                    int index = int.Parse(tokens[1]);

                    if(index < 0 || index > arrayOfNumbers.Length - 1)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    Exchange(arrayOfNumbers, index + 1);
                }
                else if(command == "max" || command == "min")
                {
                    string type = tokens[1]; //even or odd
                    int index = -1;

                    switch (type)
                    {
                        case "even":  index = MaxOrMinEvenOrOddIndex(arrayOfNumbers, 0, command); break;
                        case "odd": index = MaxOrMinEvenOrOddIndex(arrayOfNumbers, 1, command); break;
                    }

                    if(index == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(index);
                    }
                }
                else if(command == "first" || command == "last")
                {
                    int count = int.Parse(tokens[1]);
                    string type = tokens[2]; //even or odd

                    if(count <= 0 || count > arrayOfNumbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    switch (type)
                    {
                        case "even": PrintFirstOrLastEvenOrOddElements(arrayOfNumbers, 0, command, count); break;
                        case "odd": PrintFirstOrLastEvenOrOddElements(arrayOfNumbers, 1, command, count); break;
                    }
                }
            }
        }

        private static void PrintFirstOrLastEvenOrOddElements(int[] arrayOfNumbers, int indexType, string command, int count)
        {
            List<int> numbers = new List<int>();

            switch (indexType) //if index = 0 => even, if index = 1 => odd
            {
                case 0: numbers = arrayOfNumbers.Where(x => x % 2 == 0).ToList(); break;
                case 1: numbers = arrayOfNumbers.Where(x => x % 2 == 1).ToList(); break;
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("[]");

                return;
            }
            else
            {
                if(count > numbers.Count)
                {
                    count = numbers.Count;
                }

                switch (command)
                {
                    case "first": numbers = numbers.Take(count).ToList();
                        Console.WriteLine($"[{string.Join(", ", numbers)}]");
                        break;
                    case "last": //numbers = numbers.TakeLast(count).ToList(); => for .Net.Core working
                        List<int> lastNumbers = new List<int>(); //From row 111 to row 127 -> solution for .Net.Framework, 
                        int currentCount = 0;                    //becose don't working TakeList(count)

                        for (int i = numbers.Count - 1; i >= 0; i--)
                        {
                            lastNumbers.Add(numbers[i]);
                            currentCount++;

                            if (currentCount == count)
                            {
                                break;
                            }
                        }

                        lastNumbers.Reverse();

                        Console.WriteLine($"[{string.Join(", ", lastNumbers)}]");
                        break;
                }

                //Console.WriteLine($"[{string.Join(", ", numbers)}]");
            }
        }

        private static int MaxOrMinEvenOrOddIndex(int[] arrayOfNumbers, int indexEvenOrOdd, string command)
        {
            int index = -1;

            switch (command)
            {
                case "max":
                    int maxNumber = int.MinValue;

                    for (int i = 0; i < arrayOfNumbers.Length; i++)
                    {
                        if (arrayOfNumbers[i] >= maxNumber && arrayOfNumbers[i] % 2 == indexEvenOrOdd)
                        {
                            maxNumber = arrayOfNumbers[i];
                            index = i;
                        }
                    }
                    break;

                case "min":
                    int minNumber = int.MaxValue;

                    for (int i = 0; i < arrayOfNumbers.Length; i++)
                    {
                        if (arrayOfNumbers[i] <= minNumber && arrayOfNumbers[i] % 2 == indexEvenOrOdd)
                        {
                            minNumber = arrayOfNumbers[i];
                            index = i;
                        }
                    }
                    break;
            }

            return index;
        }

        private static void Exchange(int[] arrayOfNumbers, int count)
        {
            //first element = array[array.Lenght - 1];

            for (int i = 0; i < count; i++)
            {
                int fistElement = arrayOfNumbers[0];
                for (int j = 0; j < arrayOfNumbers.Length - 1; j++)
                {
                    arrayOfNumbers[j] = arrayOfNumbers[j + 1];
                }
                arrayOfNumbers[arrayOfNumbers.Length - 1] = fistElement;
            }
        }
    }
}
