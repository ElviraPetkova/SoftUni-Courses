namespace P02_CarsSalesman
{
    using System.Text;

    public class Car
    {
        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }

        public Car(string model, Engine engine, int weight)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
        }

        public Car(string model, Engine engine, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Color = color;
        }

        public Car(string model, Engine engine, int weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public int Weight { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendFormat($"{this.Model}:\n");
            stringBuilder.Append(this.Engine.ToString());
            stringBuilder.AppendFormat("  Weight: {0}\n",this.Weight == 0 ? "n/a" : this.Weight.ToString());
            stringBuilder.AppendFormat("  Color: {0}", this.Color == null ? "n/a" : this.Color.ToString());

            return stringBuilder.ToString();
        }
    }
}
