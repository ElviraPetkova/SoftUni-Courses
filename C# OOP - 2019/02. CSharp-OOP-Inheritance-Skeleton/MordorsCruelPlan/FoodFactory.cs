﻿namespace MordorsCruelPlan
{
    using Foods;

    public class FoodFactory
    {
        public Food GetFood(string food)
        {
            switch (food.ToLower())
            {
                case "apple": return new Apple();
                case "cram": return new Cram();
                case "honeycake": return new HoneyCake();
                case "lembas": return new Lembas();
                case "melon": return new Melon();
                case "mushrooms": return new Mushrooms();

                default: return null;
            }
        }
    }
}
