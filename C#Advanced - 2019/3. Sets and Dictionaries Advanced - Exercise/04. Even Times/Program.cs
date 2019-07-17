using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args) // 80/100
        {
            int counter = int.Parse(Console.ReadLine());

            HashSet<int> numbers = new HashSet<int>();
            int evenNumber = 0;

            for (int i = 0; i < counter; i++)
            {
                int numb = int.Parse(Console.ReadLine());

                if (numbers.Contains(numb))
                {
                    evenNumber = numb;
                }

                numbers.Add(numb);
            }

            Console.WriteLine(evenNumber);
        }
    }
}
