namespace P02_CarsSalesman
{
    using System.Text;

    public class Engine
    {
        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
        }

        public Engine(string model, int power, int displacement)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
        }

        public Engine(string model, int power, string effeciency)
        {
            this.Model = model;
            this.Power = power;
            this.Efficiency = effeciency;
        }

        public Engine(string model, int power, int displacement, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }

        public string Model { get; set; }

        public int Power { get; set; }

        public int Displacement { get; set; }

        public string Efficiency { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendFormat($"  {this.Model}:\n");
            stringBuilder.AppendFormat($"    Power: {this.Power}\n");
            stringBuilder.AppendFormat("    Displacement: {0}\n", this.Displacement == 0 ? "n/a" : this.Displacement.ToString());
            stringBuilder.AppendFormat("    Efficiency: {0}\n", this.Efficiency == null ? "n/a" : this.Efficiency.ToString());

            return stringBuilder.ToString();
        }

        private string ChekingDisplacement(int displacement)
        {
            string result = this.Displacement.ToString();
            return this.Displacement == -1
                ? "n/a"
                : result;
        }
    }
}
