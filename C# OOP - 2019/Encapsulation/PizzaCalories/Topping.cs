namespace PizzaCalories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Topping
    {
        //FOR CHEKING NAME OF TOPPING USE TOLOWER(), 
        //BECOSE IN ALLTOPPING EVERY KEYS IS TOLOWER CASE, 
        //AND TOPPING NAME IS INPUT, DO NOT CHANGE NAME
        private const double BaseCaloriesPerGram = 2;

        private Dictionary<string, double> allTopping = new Dictionary<string, double>
        {
            ["meat"] = 1.2,
            ["veggies"] = 0.8,
            ["cheese"] = 1.1,
            ["sauce"] = 0.9
        };

        private string name;
        private int weight; //in grams

        public Topping(string name, int weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        private string Name
        {
            get => this.name;
            set
            {
                if (!this.allTopping.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.name = value;
            }
        }

        private int Weight
        {
            get => this.weight;
            set
            {
                if(value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.Name} weight should be in the range [1..50].");
                }

                this.weight = value;
            }
        }

        public double TotalCalories()
        {
            double currentCalories = this.allTopping.Single(t => t.Key == this.Name.ToLower()).Value;
            return BaseCaloriesPerGram * currentCalories * this.Weight;
        }
    }
}
