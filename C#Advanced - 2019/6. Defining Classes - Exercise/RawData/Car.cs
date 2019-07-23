
namespace RawData
{
    public class Car
    {
        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType,
            double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age,
            double tire3Pressure, int tire3Age, double tire4Pressure, int tire4Age)
        {
            this.Model = model;
            this.Engine = new Engine(engineSpeed, enginePower);
            this.Cargo = new Cargo(cargoWeight, cargoType);
            this.Tires = new Tire[]
            {
                new Tire(tire1Pressure, tire1Age),
                new Tire(tire2Pressure, tire2Age),
                new Tire(tire3Pressure, tire3Age),
                new Tire(tire4Pressure, tire4Age)
            };
        }

        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tire[] tires;

        public string Model
        {
            get { return this.model; }

            set { this.model = value; }
        }

        public Engine Engine
        {
            get { return this.engine; }

            set { this.engine = value; }
        }

        public Cargo Cargo
        {
            get { return this.cargo; }

            set { this.cargo= value; }
        }

        public Tire[] Tires
        {
            get { return this.tires; }

            set { this.tires = value; }
        }

    }
}
