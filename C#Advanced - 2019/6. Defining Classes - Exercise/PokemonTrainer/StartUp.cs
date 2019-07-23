using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Trainer> listOfTrainers = new List<Trainer>();

            while (input != "Tournament")
            {
                string[] splitedInput = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                //"{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"

                string trainerName = splitedInput[0];
                string pokemonName = splitedInput[1];
                string pokemonElement = splitedInput[2];
                int pokemonHealth = int.Parse(splitedInput[3]);

                Pokemon newPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                Trainer currentTrainer = listOfTrainers
                    .FirstOrDefault(x => x.Name == trainerName);

                if (currentTrainer == null)
                {
                    Trainer newTrainer = new Trainer(trainerName);
                    newTrainer.ListOfPokemons.Add(newPokemon);
                    listOfTrainers.Add(newTrainer);
                }
                else
                {
                    int index = listOfTrainers.IndexOf(currentTrainer);
                    listOfTrainers[index].ListOfPokemons.Add(newPokemon);
                }              

                input = Console.ReadLine();
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                ChekingTrainers(listOfTrainers, command);

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, listOfTrainers
                                .OrderByDescending(x=>x.NumberOfBadgest)));
        }

        private static void ChekingTrainers(List<Trainer> listOfTrainers, string command)
        {
            for (int i = 0; i < listOfTrainers.Count; i++)
            {
                //Trainer trainer = listOfTrainers[i];
                //List<Pokemon> listOfPokemons = trainer.ListOfPokemons.ToList();

                bool isHavePokemon = listOfTrainers[i].ChekingPokemonsInOneTrainer(command);

                if (!isHavePokemon)
                {
                    listOfTrainers[i].PokemonLossOfHealth();
                }
                else
                {
                    listOfTrainers[i].NumberOfBadgest++;
                }
            }
        }

    }
}
