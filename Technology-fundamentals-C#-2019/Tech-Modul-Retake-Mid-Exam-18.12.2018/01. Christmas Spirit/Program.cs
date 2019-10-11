using System;

namespace _01._Christmas_Spirit
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int spirit = 0;
            int cost = 0;

            /*  •	Ornament Set – 2$ a piece
                •	Tree Skirt – 5$ a piece
                •	Tree Garlands – 3$ a piece
                •	Tree Lights – 15$ a piece */

            for (int counterOfDays = 1; counterOfDays <= days; counterOfDays++)
            {
                
                if (counterOfDays % 11 == 0)
                {
                    quantity += 2;
                }

                if (counterOfDays % 2 == 0)
                {
                    spirit += 5;
                    cost += (2 * quantity);
                }
                if (counterOfDays % 3 == 0)
                {
                    spirit += 13;
                    cost += ((5 * quantity) + (3 * quantity));
                }
                if (counterOfDays % 5 == 0)
                {
                    spirit += 17;
                    cost += (15 * quantity);

                    if (counterOfDays % 3 == 0)
                    {
                        spirit += 30;
                    }
                }

                if (counterOfDays % 10 == 0)
                {
                    spirit -= 20;
                    cost += (5 + 3 + 15);

                    if(days == counterOfDays)
                    {
                        spirit -= 30;
                    }
                }


                
            }

            Console.WriteLine($"Total cost: {cost}");
            Console.WriteLine($"Total spirit: {spirit}");
        }
    }
}
