using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            var challenger = new Dictionary<string, Dictionary<string, int>>();

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
                    string position = tokens[1];
                    int skill = int.Parse(tokens[2]);

                    if (challenger.ContainsKey(player) == false)
                    {
                        challenger.Add(player, new Dictionary<string, int>());
                        challenger[player].Add(position, skill);
                    }
                    else
                    {
                        if(challenger[player].ContainsKey(position) == false)
                        {
                            challenger[player].Add(position, skill);
                        }
                        else
                        {
                            if(challenger[player][position] < skill)
                            {
                                challenger[player][position] = skill;
                            }
                        }
                    }

                }
                else
                {
                    var tokens = input.Split(" vs ");

                    string firstPlayer = tokens[0];
                    string secondPlayer = tokens[1];

                    if(challenger.ContainsKey(firstPlayer) && challenger.ContainsKey(secondPlayer))
                    {
                        var posittionsPerFirstPlayer = challenger[firstPlayer].ToList();
                        var posittionsPerSecondPlayer = challenger[secondPlayer].ToList();

                        bool havePosition = false;
                        string removedPLayer = string.Empty;

                        foreach (var kvp in posittionsPerFirstPlayer)
                        {
                            string position = kvp.Key;
                            int points = kvp.Value;
                            foreach (var positionSecond in posittionsPerSecondPlayer)
                            {
                                string twoPosition = positionSecond.Key;
                                int twoPoints = positionSecond.Value;

                                if(position == twoPosition)
                                {
                                    if(points > twoPoints)
                                    {
                                        removedPLayer = secondPlayer;
                                    }
                                    else if (points < twoPoints)
                                    {
                                        removedPLayer = firstPlayer;
                                    }
                                    havePosition = true;
                                    break;
                                }
                            }
                        }

                        if(havePosition)
                        {
                            challenger.Remove(removedPLayer);
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }

            foreach (var kvp in challenger.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Values.Sum()} skill");
                foreach (var position in kvp.Value.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }
    }
}
