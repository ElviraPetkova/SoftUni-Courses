using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Tseam_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfGames = Console.ReadLine().Split().ToList();

            string commands = string.Empty;

            while ((commands = Console.ReadLine()) != "Play!")
            {
                var tokens = commands.Split();

                /*  •	Install {game}
                    •	Uninstall {game}
                    •	Update {game}
                    •	Expansion {game}-{expansion} */

                string oneCommand = tokens[0];
                string gameName = tokens[1];

                if(oneCommand == "Install")
                {
                    if(listOfGames.Exists(element => element == gameName) == false)
                    {
                        listOfGames.Add(gameName);
                    }
                }
                else if(oneCommand == "Uninstall")
                {
                    if (listOfGames.Exists(element => element == gameName))
                    {
                        listOfGames.Remove(gameName);
                    }
                }
                else if (oneCommand == "Update")
                {
                    if (listOfGames.Exists(element => element == gameName))
                    {
                        listOfGames.Remove(gameName);
                        listOfGames.Add(gameName);
                    }
                }
                else if (oneCommand == "Expansion")
                {
                    var information = gameName.Split('-');
                    string game = information[0];
                    string currentExpansion = information[1];
                    string expansion = $"{game}:{currentExpansion}";

                    int indexOfGame = listOfGames.IndexOf(game);
                    int indexOfExpansion = listOfGames.IndexOf(expansion);

                    if(indexOfGame != -1 && indexOfExpansion == -1)
                    {
                        listOfGames.Insert(indexOfGame + 1, expansion);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", listOfGames));
        }
    }
}
