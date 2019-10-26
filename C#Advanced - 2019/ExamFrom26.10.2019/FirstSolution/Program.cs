namespace FirstSolution
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            int[] arrayOfMales = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] arrayOfFemales = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> males = new Stack<int>(arrayOfMales);
            Queue<int> females = new Queue<int>(arrayOfFemales);
            int coutMathes = 0;

            while (males.Any() && females.Any())
            {
                int oneMale = males.Peek();
                int oneFemale = females.Peek();

                if(oneFemale <= 0 || oneMale <= 0)
                {
                    if (oneMale <= 0)
                    {
                        males.Pop();
                    }

                    if (oneFemale <= 0)
                    {
                        females.Dequeue();
                    }

                    continue;
                }

                if(oneMale % 25 == 0 || oneFemale % 25 == 0)
                {
                    if(oneMale % 25 == 0)
                    {
                        males.Pop();
                        males.Pop();
                    }

                    if(oneFemale % 25 == 0)
                    {
                        females.Dequeue();
                        females.Dequeue();
                    }

                    continue;
                }

                if(oneFemale.Equals(oneMale))
                {
                    males.Pop();
                    females.Dequeue();
                    coutMathes++;
                }
                else
                {
                    females.Dequeue();
                    oneMale -= 2;
                    males.Pop();
                    males.Push(oneMale);
                }
            }

            Console.WriteLine($"Matches: {coutMathes}");

            string resultStringByMales = males.Any() ? $"Males left: {string.Join(", ", males)}" : "Males left: none";
            Console.WriteLine(resultStringByMales);

            string resultStringByFemales = females.Any() ? $"Females left: {string.Join(", ", females)}" : "Females left: none";
            Console.WriteLine(resultStringByFemales);
        }
    }
}
