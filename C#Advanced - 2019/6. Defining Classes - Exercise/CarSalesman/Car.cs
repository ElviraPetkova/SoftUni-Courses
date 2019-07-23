
using System;

namespace CarSalesman
{
    public class Car
    {
        public Car()
        {
            this.Weight = "n/a";
            this.Color = "n/a";
        }

        public Car(string model, Engine engine)
            : this()
        {
            this.Model = model;
            this.Engine = engine;
        }

        private string model;
        private Engine engine;
        private string weight;
        private string color;

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public string Weight { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            string carPrint = $"{Model}:\n  { Engine.Model}:\n" +
                                            $"      Power: {Engine.Power}\n" +
                                            $"      Displacement: { Engine.Displacement}\n" +
                                            $"      Efficiency: { Engine.Efficiency}\n" +
                                            $"  Weight: {Weight}\n" +
                                            $"  Color: {Color}";

            return carPrint.ToString();
        }
    }
}
