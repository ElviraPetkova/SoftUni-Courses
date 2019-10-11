namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double moreFuelConsumption = 1.6;

        public Truck(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) 
            : base(fuelQuantity, fuelConsumptionPerKm + moreFuelConsumption, tankCapacity)
        {
        }

        public override void Refuel(double liters)
        {
            base.Refuel(liters);
            this.FuelQuantity -= liters * 0.05;
        }
    }
}
