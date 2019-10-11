using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] arrayOfNumb = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int bombNumber = arrayOfNumb[0];
            int power = arrayOfNumb[1];

            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                int currentNumber = listOfNumbers[i];
                
                if(currentNumber == bombNumber)
                {
                    int startIndex = i - power;
                    int endIndex = i + power;

                    if(startIndex < 0)
                    {
                        startIndex = 0;
                    }

                    if(endIndex > listOfNumbers.Count - 1)
                    {
                        endIndex = listOfNumbers.Count - 1;
                    }

                    if(startIndex > listOfNumbers.Count - 1 || endIndex < 0)
                    {
                        continue;
                    }

                    int lenght = (endIndex - startIndex) + 1;
                    listOfNumbers.RemoveRange(startIndex, lenght);

                    i = startIndex - 1;
                } 
            }

            int sum = listOfNumbers.Sum();
            Console.WriteLine(sum);

        }
    }
}
