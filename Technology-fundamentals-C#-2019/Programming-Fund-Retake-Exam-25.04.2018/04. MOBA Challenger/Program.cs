using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._MOBA_Challenger
{

    class Program
    {
        static void Main(string[] args)
        {
            var dictionaryOfPlayers = new Dictionary<string, Dictionary<string, int>>();
            //key = player, value => key = position, value = points

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Season end")
                {
                    break;
                }

                if (input.Contains("->"))
                {
                    var tokens = input.Split(" -> ");
                    string player = tokens[0];
                    string possition = tokens[1];
                    int points = int.Parse(tokens[2]);

                    if(dictionaryOfPlayers.ContainsKey(player) == false)
                    {
                        dictionaryOfPlayers.Add(player, new Dictionary<string, int>());
                        dictionaryOfPlayers[player].Add(possition, points);
                    }
                    else //if player is exist
                    {
                        if(dictionaryOfPlayers[player].ContainsKey(possition) == false)
                        {
                            dictionaryOfPlayers[player].Add(possition, points);
                        }
                        else //if possition is exist, update points
                        {
                            if(dictionaryOfPlayers[player][possition] < points)
                            {
                                dictionaryOfPlayers[player][possition] = points;
                            }
                        }
                    }
                }
                else
                {
                    var tokens = input.Split(" vs ");
                    string firstPlayer = tokens[0];
                    string secondPlayer = tokens[1];

                    if(dictionaryOfPlayers.ContainsKey(firstPlayer) && dictionaryOfPlayers.ContainsKey(secondPlayer))
                    {
                        HappendDuel(dictionaryOfPlayers, firstPlayer, secondPlayer);
                    }
                }
            }

            foreach (var kvp in dictionaryOfPlayers.OrderByDescending(x=>x.Value.Values.Sum()).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Values.Sum()} skill");

                foreach (var info in kvp.Value.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"- {info.Key} <::> {info.Value}");
                }
            }
        }

        private static void HappendDuel(Dictionary<string, Dictionary<string, int>> dictionaryOfPlayers, string firstPlayer, string secondPlayer)
        {
            var firstPlayerPossitions = dictionaryOfPlayers[firstPlayer];
            var secondPlayerPossitions = dictionaryOfPlayers[secondPlayer];

            bool haveSomePossitions = false;
            string remolvedPlayer = string.Empty;

            foreach (var kvp in firstPlayerPossitions)
            {
                string firstPossition = kvp.Key;
                int points = kvp.Value;

                if (secondPlayerPossitions.ContainsKey(firstPossition))
                {
                    if(points > secondPlayerPossitions[firstPossition])
                    {
                        remolvedPlayer = secondPlayer;
                    }
                    else if(points < secondPlayerPossitions[firstPossition])
                    {
                        remolvedPlayer = firstPlayer;
                    }

                    haveSomePossitions = true;
                    break;
                }
            }

            if (haveSomePossitions)
            {
                dictionaryOfPlayers.Remove(remolvedPlayer);
            }
        }
    }
}
