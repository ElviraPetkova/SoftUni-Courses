namespace Sport_Cards
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            var allSportCards = new Dictionary<string, Dictionary<string, decimal>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input
                    .Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);

                if(arguments[0] == "check")
                {
                    string card = arguments[1];

                    if (allSportCards.ContainsKey(card))
                    {
                        Console.WriteLine($"{card} is available!");
                    }
                    else
                    {
                        Console.WriteLine($"{card} is not available!");
                    }
                }
                else
                {
                    string card = arguments[0];
                    string sport = arguments[1];
                    decimal price = decimal.Parse(arguments[2]);

                    if (!allSportCards.ContainsKey(card))
                    {
                        allSportCards.Add(card, new Dictionary<string, decimal>());
                    }

                    if (!allSportCards[card].ContainsKey(sport))
                    {
                        allSportCards[card].Add(sport, 0);
                    }

                    allSportCards[card][sport] = price;
                }
            }

            var result = allSportCards
                .OrderByDescending(x => x.Value.Keys.Count)
                .ToList();

            foreach (var card in result)
            {
                Console.WriteLine($"{card.Key}:");
                foreach (var sport in card.Value.OrderBy(x=>x.Key))
                {
                    Console.WriteLine($"  -{sport.Key} - {sport.Value:f2}");
                }
            }
        }
    }
}
