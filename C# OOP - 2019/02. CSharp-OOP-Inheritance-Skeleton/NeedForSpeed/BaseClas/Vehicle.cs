namespace NeedForSpeed.BaseClas
{
    public class Vehicle
    {
        private const double DefaulFuelConsumption = 1.25;

        private int horsePower;
        private double fuel;

        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public virtual double FuelConsumption => DefaulFuelConsumption;

        public int HorsePower { get; set; }

        public double Fuel { get; set; }

        public virtual void Drive(double kilometers)
        {
            double fuelNeeded = this.FuelConsumption * kilometers;

            if(this.Fuel >= fuelNeeded)
            {
                this.Fuel -= fuelNeeded;
            }
        }

    }
}
