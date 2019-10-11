namespace NeedForSpeed.CarClases
{
    public class SportCar : Car
    {
        private const double DefaulFuelConsumption = 10;

        public SportCar(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
        }

        public override double FuelConsumption => DefaulFuelConsumption;
    }
}
