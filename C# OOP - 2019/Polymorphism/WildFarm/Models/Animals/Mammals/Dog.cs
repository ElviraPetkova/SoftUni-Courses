namespace WildFarm.Models.Animals.Mammals
{
    using System;
    using System.Collections.Generic;
    using Foods;

    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        protected override List<Type> PrefferedFoodTypes
            => new List<Type>
            {
                typeof(Meat)
            };

        protected override double WeightMultiplier => 0.40;

        public override string AskFood()
        {
            return "Woof!";
        }
    }
}
