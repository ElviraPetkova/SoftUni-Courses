using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Pokemon_Evolution
{
    class Pokemon
    {
        public Pokemon(string name, string type, int power)
        {
            this.Name = name;
            this.Type = type;
            this.Power = power;
        }

        public string Name { get; set; }

        public string Type { get; set; }

        public int Power { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, List<Pokemon>>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "wubbalubbadubdub")
                {
                    break;
                }

                var splitedInput = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                if (splitedInput.Length > 1)
                {
                    string pokemonName = splitedInput[0];
                    string pokemonType = splitedInput[1];
                    int pokemonIndex = int.Parse(splitedInput[2]);

                    if(dictionary.ContainsKey(pokemonName) == false)
                    {
                        dictionary.Add(pokemonName, new List<Pokemon>());
                    }

                    Pokemon pokemon = new Pokemon(pokemonName, pokemonType, pokemonIndex);
                    dictionary[pokemonName].Add(pokemon);
                }
                else
                {
                    string pokemonName = splitedInput[0];
                    if (dictionary.ContainsKey(pokemonName))
                    {
                        var listOfPokemons = dictionary[pokemonName].ToList();
                        Console.WriteLine($"# {pokemonName}");
                        foreach (var pokemon in listOfPokemons)
                        {
                            Console.WriteLine($"{pokemon.Type} <-> {pokemon.Power}");
                        }
                    }
                }
            }

            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"# {kvp.Key}");
                foreach (var pokemon in kvp.Value.OrderByDescending(x=>x.Power))
                {
                    Console.WriteLine($"{pokemon.Type} <-> {pokemon.Power}");
                }
            }
        }
    }
}
