using System;

namespace _01._Party_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int coins = 50 * days;

            for (int counterOfDays = 1; counterOfDays <= days; counterOfDays++)
            {

                if(counterOfDays % 15 == 0)
                {
                    partySize += 5;
                }
                if (counterOfDays % 10 == 0)
                {
                    partySize -= 2;
                }
                if (counterOfDays % 5 == 0)
                {
                    coins += 20 * partySize;

                    if(counterOfDays % 3 == 0)
                    {
                        coins -= 2 * partySize;
                    }
                }
                if (counterOfDays % 3 == 0)
                {
                    coins -= 3 * partySize;
                }

                coins -= 2 * partySize;
            }

            Console.WriteLine($"{partySize} companions received {coins / partySize} coins each.");
        }
    }
}
