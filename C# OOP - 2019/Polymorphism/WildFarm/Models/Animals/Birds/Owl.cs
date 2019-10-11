namespace WildFarm.Models.Animals.Birds
{
    using Foods;
    using System;
    using System.Collections.Generic;

    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override string AskFood()
        {
            return "Hoot Hoot";
        }

        protected override List<Type> PrefferedFoodTypes
           => new List<Type> { typeof(Meat) };

        protected override double WeightMultiplier => 0.25;

    }
}
