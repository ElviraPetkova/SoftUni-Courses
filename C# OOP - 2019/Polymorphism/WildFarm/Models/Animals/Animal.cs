namespace WildFarm.Models.Animals
{
    using Foods;
    using System.Collections.Generic;
    using System;

    public abstract class Animal
    {
        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name { get; protected set; }

        public double Weight { get; protected set; }

        public int FoodEaten { get; protected set; }

        protected abstract List<Type> PrefferedFoodTypes { get; }

        protected abstract double WeightMultiplier { get; }

        public abstract string AskFood();

        public void Feed(Food food)
        {
            if (!this.PrefferedFoodTypes.Contains(food.GetType()))
            {
                throw new InvalidOperationException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

            this.Weight += food.Quantity * this.WeightMultiplier;

            this.FoodEaten += food.Quantity;
        }

    }
}
