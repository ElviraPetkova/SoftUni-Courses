namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double moreConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) 
            : base(fuelQuantity, fuelConsumptionPerKm + moreConsumption, tankCapacity)
        {
        }
    }
}
