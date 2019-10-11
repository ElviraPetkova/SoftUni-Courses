namespace PizzaCalories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Dough
    {
        //FOR CHEKING FLOURTYPE AND BAKINGTEHNIQUE USE TOLOWER(), 
        //BECOSE IN FLOUR AND BAKING EVERY KEYS IS TOLOWER CASE, 
        //AND FLOURTYPE AND BAKINGTEHNIQUE IS INPUT, DO NOT CHANGE NAME
        private const double BaseCaloriesPerGram = 2;

        private Dictionary<string, double> flour = new Dictionary<string, double>
        {
            ["white"] = 1.5,
            ["wholegrain"] = 1.00
        };

        private Dictionary<string, double> baking = new Dictionary<string, double>
        {
            ["crispy"] = 0.9,
            ["chewy"] = 1.1,
            ["homemade"] = 1.0
        };


        private string flourType;
        private string bakingTechnique;
        private int weight; // in grams

        public Dough(string flourType, string bakingTechnique, int weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        private string FlourType
        {
            get => this.flourType;
            set
            {
    
                if (!this.flour.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        private string BakingTechnique
        {
            get => this.bakingTechnique;
            set
            {
                if (!this.baking.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.bakingTechnique = value;
            }
        }

        private int Weight
        {
            get => this.weight;
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }

        public double TotalCalories()
        {
            //(2 * weight) * 1.5 * 1.1 
            double flourCalories = this.flour.Single(f => f.Key == this.FlourType.ToLower()).Value;
            double bakingCalories = this.baking.Single(b => b.Key == this.BakingTechnique.ToLower()).Value;

            double totalCalories = (BaseCaloriesPerGram * this.Weight) * flourCalories * bakingCalories;

            return totalCalories;
        }
    }
}
