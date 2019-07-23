
namespace CarSalesman
{
    public class Engine
    {
        public Engine()
        {
            this.Displacement = "n/a";
            this.Efficiency = "n/a";
        }

        public Engine(string model, int power)
            : this()
        {
            this.Model = model;
            this.Power = power;
        }

        private string model;
        private int power;
        private string displacement;
        private string efficiency;

        public string Model
        {
            get { return this.model; }

            set { this.model = value; }
        }

        public int Power
        {
            get { return this.power; }

            set { this.power = value; }
        }

        public string Displacement
        {
            get { return this.displacement; }

            set { this.displacement = value; }
        }

        public string Efficiency
        {
            get { return this.efficiency; }

            set { this.efficiency = value; }
        }
    }
}
