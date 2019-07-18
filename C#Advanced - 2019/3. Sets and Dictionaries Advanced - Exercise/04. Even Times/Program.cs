using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            var numbers = new Dictionary<int, int>();

            for (int i = 0; i < counter; i++)
            {
                int numb = int.Parse(Console.ReadLine());

                if (numbers.ContainsKey(numb) == false)
                {
                    numbers.Add(numb, 0);
                }

                numbers[numb]++;
            }

            int evenNumber = numbers
                .SingleOrDefault(n => n.Value % 2 == 0)
                .Key;

            Console.WriteLine(evenNumber);
        }
    }
}
