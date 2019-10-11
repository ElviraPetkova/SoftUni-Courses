﻿namespace WildFarm.Models.Animals.Mammals.Felines
{
    using System;
    using System.Collections.Generic;
    using Foods;

    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        protected override List<Type> PrefferedFoodTypes
            => new List<Type> { typeof(Meat) };

        protected override double WeightMultiplier => 1.00;

        public override string AskFood()
        {
            return "ROAR!!!";
        }
    }
}
