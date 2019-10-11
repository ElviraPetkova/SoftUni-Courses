using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Take_Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            List<char> text = Console.ReadLine().ToList();

            for (int i = 0; i < text.Count; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    numbers.Add(int.Parse(text[i].ToString()));
                }
            }

            text.RemoveAll(char.IsDigit);

            List<int> takeList = new List<int>(); //even numbers
            List<int> skipList = new List<int>(); //odd numbers

            for (int i = 0; i < numbers.Count; i++)
            {
                if(i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }

            string resultText = string.Empty;

            int total = 0;
            for (int i = 0; i < skipList.Count; i++)
            {
                int skipCount = skipList[i];
                int takeCount = takeList[i];

                resultText += new string(text.Skip(total).Take(takeCount).ToArray());
                total += skipCount + takeCount;
            }

            Console.WriteLine(resultText);
        }
    }
}
