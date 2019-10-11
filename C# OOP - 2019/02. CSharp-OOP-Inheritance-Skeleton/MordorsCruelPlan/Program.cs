namespace MordorsCruelPlan
{
    using System;
    using System.Collections.Generic;
    using Foods;
    using System.Linq;
    using Moods;

    public class Program
    {
        static void Main(string[] args)
        {
            List<Food> foodsEaten = new List<Food>();
            FoodFactory foodFactory = new FoodFactory();
            MoodFactory moodFactory = new MoodFactory();

            string[] foods = Console.ReadLine().Split();

            foreach (var food in foods)
            {
                Food foodToAdd = foodFactory.GetFood(food);

                foodsEaten.Add(foodToAdd);
                
            }

            int happinesFood = foodsEaten
                   .Select(x => x == null ? -1 : x.Happiness)
                   .Sum();

            Mood happinesMood = moodFactory.GetMood(happinesFood);

            Console.WriteLine(happinesFood);
            Console.WriteLine(happinesMood.GetType().Name);
        }
    }
}
