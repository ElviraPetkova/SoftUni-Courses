
using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class Trainer
    {
        public Trainer()
        {
            this.NumberOfBadgest = 0;
            this.ListOfPokemons = new List<Pokemon>();
        }

        public Trainer(string name)
            : this()
        {
            this.Name = name;
        }

        private string name;
        private int numberOfBadgest;
        private List<Pokemon> listOfPokemons;

        public string Name { get; set; }

        public int NumberOfBadgest { get; set; }

        public List<Pokemon> ListOfPokemons { get; set; }

        public bool ChekingPokemonsInOneTrainer(string command)
        {
            bool isHavePokemon = false;
            for (int j = 0; j < ListOfPokemons.Count; j++)
            {
                if (this.ListOfPokemons[j].Element == command)
                {
                    isHavePokemon = true;
                    break;
                }
            }

            return isHavePokemon;
        }

        public void PokemonLossOfHealth()
        {
            Action<List<Pokemon>> action = x => x.ForEach(y => y.Health -= 10);

            action(ListOfPokemons);

            ListOfPokemons = ListOfPokemons
                    .Where(x => x.Health > 0)
                    .ToList();
        }

        public override string ToString()
        {
            string result = $"{Name} {NumberOfBadgest} {ListOfPokemons.Count()}";
            return result.ToString();
        }
    }
}
