using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace _03._Star_Enigma
{
    class Planet
    {
        public Planet(string name, int population, int soldiers)
        {
            this.Name = name;
            this.Population = population;
            this.Soldiers = soldiers;
        }

        public string Name { get; set; }

        public int Population { get; set; }

        public int Soldiers { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessage = int.Parse(Console.ReadLine());

            string pattern = @"@(?<name>[A-Za-z]+)[^@|-|!|:|>]*?:(?<population>\d+)[^@|-|!|:|>]*?!(?<attackType>[A|D])![^@|-|!|:|>]*?->(?<soldiersCount>\d+)";
            Regex regex = new Regex(pattern);

            var attackerPlanets = new List<Planet>();
            var destructionPlanets = new List<Planet>();

            for (int i = 0; i < numberOfMessage; i++)
            {
                string encryptedMessage = Console.ReadLine();
                int key = CountOfSpecialLettters(encryptedMessage);

                string message = DecryptingMessage(encryptedMessage, key);

                if (regex.IsMatch(message))
                {
                    Match matchInfoPerPlanets = regex.Match(message);

                    string nameOfPlanet = matchInfoPerPlanets.Groups["name"].Value;
                    int population = int.Parse(matchInfoPerPlanets.Groups["population"].Value);
                    string attackType = matchInfoPerPlanets.Groups["attackType"].Value;
                    int soldiersCount = int.Parse(matchInfoPerPlanets.Groups["soldiersCount"].Value);

                    Planet currentPLanet = new Planet(nameOfPlanet, population, soldiersCount);

                    if(attackType == "A")
                    {
                        attackerPlanets.Add(currentPLanet);
                    }
                    else if(attackType == "D")
                    {
                        destructionPlanets.Add(currentPLanet);
                    }
                }
            }

            PrintPlanets(attackerPlanets, "Attacked planets");
            PrintPlanets(destructionPlanets, "Destroyed planets");
        }

        private static void PrintPlanets(List<Planet> planets, string printText)
        {
            Console.WriteLine($"{printText}: {planets.Count()}");
            foreach (Planet planet in planets.OrderBy(x=>x.Name))
            {
                Console.WriteLine($"-> {planet.Name}");
            }
        }

        private static string DecryptingMessage(string encryptedMessage, int key)
        {
            StringBuilder decryptMessage = new StringBuilder();

            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                char newCharacter = (char)(encryptedMessage[i] - key);
                decryptMessage.Append(newCharacter);
            }

            return decryptMessage.ToString();
        }

        private static int CountOfSpecialLettters(string encryptedMessage)
        {
            int counter = 0;
            encryptedMessage = encryptedMessage.ToLower();

            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                char oneLetter = encryptedMessage[i];
                if (oneLetter == 's' || oneLetter == 't' || oneLetter == 'a' || oneLetter == 'r')
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
