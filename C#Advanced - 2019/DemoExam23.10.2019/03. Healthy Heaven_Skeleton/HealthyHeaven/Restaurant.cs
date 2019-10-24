namespace HealthyHeaven
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Restaurant
    {
        private ICollection<Salad> data;

        public Restaurant(string name)
        {
            this.Name = name;
            this.Data = new List<Salad>();
        }

        public string Name { get; private set; }

        public ICollection<Salad> Data { get; private set; }

        public void Add(Salad salad)
        {
            this.Data.Add(salad);
        }

        public bool Buy(string name)
            => this.Data.FirstOrDefault(x => x.Name == name) != null ? true : false;

        public Salad GetHealthiestSalad()
        {
            var minimalCalories = this.Data.Min(x => x.Products.Sum(y => y.Calories));
            Salad salad = this.Data.FirstOrDefault(s => s.Products.Sum(c => c.Calories) == minimalCalories);

            //var firstProdusctName = salad.Products.Select(x => x.Name).First();
            //var productsNames = salad.Products.Select(x => x.Name.ToLower()).Skip(1);
            //string saladAsString =firstProdusctName + " with " +  string.Join(" with ", productsNames);
            //return saladAsString;

            return salad;
        }

        public string GenerateMenu()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{this.Name} have {this.Data.Count} salads:");
            foreach (var salad in this.Data)
            {
                stringBuilder.AppendLine(salad.ToString());
            }

            return stringBuilder.ToString().Trim();
        }
    }
}
