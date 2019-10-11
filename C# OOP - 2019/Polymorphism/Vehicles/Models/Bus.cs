namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        private const double moreConsumption = 1.4;

        public Bus(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) 
            : base(fuelQuantity, fuelConsumptionPerKm + moreConsumption, tankCapacity)
        {
        }

        public string DriveEmpty(double distance)
        {
            this.FuelConsumptionPerKm -= moreConsumption;
            return base.Drive(distance);
        }
    }
}
