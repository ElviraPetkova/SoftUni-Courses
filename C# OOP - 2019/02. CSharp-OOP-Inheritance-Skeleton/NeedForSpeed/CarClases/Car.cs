namespace NeedForSpeed.CarClases
{
    using BaseClas;

    public class Car : Vehicle
    {
        private const double DefaulFuelConsumption = 3;

        public Car(int horsePower, double fuel)
            :base(horsePower, fuel)
        {
        }

        public override double FuelConsumption => DefaulFuelConsumption;
    }
}
