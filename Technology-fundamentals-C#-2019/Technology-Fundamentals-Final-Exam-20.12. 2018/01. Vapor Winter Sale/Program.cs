using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Vapor_Winter_Sale
{
    class Game
    {
        public string Name { get; set; }

        public string DLS { get; set; }

        public double Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] games = Console.ReadLine().Split(", ");

            var gamesWithoutDLS = new Dictionary<string, double>();

            var gamesWithDLS = new Dictionary<string, Game>();

            for (int i = 0; i < games.Length; i++)
            {
                string infoPerOneGame = games[i];

                if (infoPerOneGame.Contains(':'))
                {
                    var information = infoPerOneGame.Split(':');

                    string gameName = information[0];
                    string DLS = information[1];

                    if (gamesWithoutDLS.ContainsKey(gameName))
                    {
                        double price = gamesWithoutDLS[gameName];
                        price += (price * 0.2);
                        Game currentGame = new Game()
                        {
                            Name = gameName,
                            DLS = DLS,
                            Price = price
                        };
                        gamesWithDLS.Add(gameName, currentGame);
                    }
                }
                else if (infoPerOneGame.Contains('-'))
                {
                    var information = infoPerOneGame.Split('-');
                    string gameName = information[0];
                    double price = double.Parse(information[1]);

                    if(gamesWithoutDLS.ContainsKey(gameName) == false)
                    {
                        gamesWithoutDLS.Add(gameName, price);
                    }
                }
            }

            foreach (var kvp in gamesWithDLS.OrderBy(x=>x.Value.Price))
            {
                Console.WriteLine($"{kvp.Value.Name} - {kvp.Value.DLS} - {(kvp.Value.Price / 2.0):f2}");
            }

            var someGameWithoutDLS = new Dictionary<string, double>();
            foreach (var kvp in gamesWithoutDLS)
            {
                string nameOfGame = kvp.Key;
                bool haveName = false;
                foreach (var game in gamesWithDLS)
                {
                    string name = game.Key;

                    if(name == nameOfGame)
                    {
                        haveName = true;
                        break;
                    }
                }

                if(haveName == false)
                {
                    double price = kvp.Value;
                    price -= (price * 0.2);
                    someGameWithoutDLS.Add(nameOfGame, price);
                }
            }

            foreach (var kvp in someGameWithoutDLS.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value:f2}");
            }
        }
    }
}
