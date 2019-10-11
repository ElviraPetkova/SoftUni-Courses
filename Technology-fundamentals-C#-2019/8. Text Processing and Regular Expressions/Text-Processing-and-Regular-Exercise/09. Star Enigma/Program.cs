using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _09._Star_Enigma
{
    class Planet
    {
        public Planet(string name, int population, int soldier)
        {
            this.Name = name;
            this.Population = population;
            this.SoldierCount = soldier;
        }

        public string Name { get; set; }

        public int Population { get; set; }

        public int SoldierCount { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int countOfMessage = int.Parse(Console.ReadLine());

            string pattern = @"@([A-Za-z]+)[^@|-|!|:|>]*:(\d+)[^@|-|!|:|>]*!([A|D])![^@|-|!|:|>]*->(\d+)";

            Regex regex = new Regex(pattern);

            List<Planet> attackedPlanets = new List<Planet>();
            List<Planet> destroyedPlanets = new List<Planet>();

            for (int i = 0; i < countOfMessage; i++)
            {
                string message = Console.ReadLine();
                int key = CounterOfSpecialLetters(message);

                message = DecriptMessage(message, key);

                if (regex.IsMatch(message))
                {
                    Match matchMessage = regex.Match(message);

                    string nameOfPlanet = matchMessage.Groups[1].Value;
                    int planetPopulation = int.Parse(matchMessage.Groups[2].Value);
                    char typeAttack = char.Parse(matchMessage.Groups[3].Value);
                    int soldierCount = int.Parse(matchMessage.Groups[4].Value);

                    Planet currentPlanet = new Planet(nameOfPlanet, planetPopulation, soldierCount);

                    switch (typeAttack)
                    {
                        case 'A': attackedPlanets.Add(currentPlanet); break;
                        case 'D': destroyedPlanets.Add(currentPlanet); break;
                    }
                }
            }
           
            PrintPlanets(attackedPlanets, "Attacked planets:");
            PrintPlanets(destroyedPlanets, "Destroyed planets:");
        }

        private static void PrintPlanets(List<Planet> planets, string printText)
        {
            Console.WriteLine($"{printText} {planets.Count}");
            foreach (Planet item in planets.OrderBy(p=>p.Name))
            {
                Console.WriteLine($"-> {item.Name}");
            }
        }

        private static string DecriptMessage(string message, int key)
        {
            string result = string.Empty;

            for (int i = 0; i < message.Length; i++)
            {
                result += (char)(message[i] - key);
            }

            return result;

        }

        private static int CounterOfSpecialLetters(string message)
        {
            string messInLowerCase = message.ToLower();
            int counterOfLetters = 0;

            for (int i = 0; i < messInLowerCase.Length; i++)
            {
                char oneChar = messInLowerCase[i];
                if(oneChar == 's' || oneChar == 't' || oneChar == 'a' || oneChar == 'r')
                {
                    counterOfLetters++;
                }
            }

            return counterOfLetters;
        }
    }
}
