using System;
using System.Linq;

namespace _06._Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] collectionsOfTickets = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < collectionsOfTickets.Length; i++)
            {
                string currentTicket = collectionsOfTickets[i].Trim();

                if(currentTicket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                PrintWinnerTicket(currentTicket);
            }
        }

        private static void PrintWinnerTicket(string currentTicket)
        {
            int lenght = 0;
            char symbol = ' ';

            string leftSide = currentTicket.Substring(0, 10);
            string rightSide = currentTicket.Substring(10);

            //The winning symbols are '@', '#', '$' and '^';

            for (int i = 6; i <= 10; i++)
            {
                if(leftSide.Contains(new string('@', i)) && rightSide.Contains(new string('@', i)))
                {
                    lenght = i;
                    symbol = '@';
                }
                else if (leftSide.Contains(new string('#', i)) && rightSide.Contains(new string('#', i)))
                {
                    lenght = i;
                    symbol = '#';
                }
                else if (leftSide.Contains(new string('$', i)) && rightSide.Contains(new string('$', i)))
                {
                    lenght = i;
                    symbol = '$';
                }
                else if (leftSide.Contains(new string('^', i)) && rightSide.Contains(new string('^', i)))
                {
                    lenght = i;
                    symbol = '^';
                }
            }

            if(lenght < 6)
            {
                Console.WriteLine($"ticket \"{currentTicket}\" - no match");
            }
            else if(lenght == 10)
            {
                Console.WriteLine($"ticket \"{currentTicket}\" - {lenght}{symbol} Jackpot!");
            }
            else
            {
                Console.WriteLine($"ticket \"{currentTicket}\" - {lenght}{symbol}");
            }
        }
    }
}
