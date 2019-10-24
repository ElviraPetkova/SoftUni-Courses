namespace HealthyHeaven
{
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;

    public class Salad
    {
        private ICollection<Vegetable> products;

        public Salad(string name)
        {
            this.Name = name;
            this.Products = new List<Vegetable>();
        }

        public string Name { get; private set; }

        public ICollection<Vegetable> Products { get; private set; }

        public int GetTotalCalories()
            => this.Products.Sum(p => p.Calories);

        public int GetProductCount()
            => this.Products.Count();

        public void Add(Vegetable product)
        {
            this.Products.Add(product);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"* Salad {this.Name} is {this.GetTotalCalories()} calories and have {this.GetProductCount()} products:");
            foreach (var vegetable in this.Products)
            {
                stringBuilder.AppendLine(vegetable.ToString());
            }
            return stringBuilder.ToString().Trim();
        }
    }
}
