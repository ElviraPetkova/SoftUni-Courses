using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arrayOfDouble = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> countOfValues = new Dictionary<double, int>();

            foreach (double number in arrayOfDouble)
            {
                if(countOfValues.ContainsKey(number) == false)
                {
                    countOfValues[number] = 0;
                }

                countOfValues[number]++;
            }

            foreach (var kvp in countOfValues)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}
