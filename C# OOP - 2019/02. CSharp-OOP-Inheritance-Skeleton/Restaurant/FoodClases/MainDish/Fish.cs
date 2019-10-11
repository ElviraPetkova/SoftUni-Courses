namespace Restaurant.FoodClases.MainDish
{
    public class Fish : MainDish
    {
        private const double DefaulGrams = 22;

        public Fish(string name, decimal price) 
            : base(name, price, DefaulGrams)
        {
        }

    }
}
