namespace Vehicles
{
    using System;

    public class Vehicle : IVehicle
    {
        private double fuelQuantity;

        public Vehicle(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public double FuelQuantity
        {
            get => this.fuelQuantity;

            set
            {
                if(value > this.TankCapacity)
                {
                    this.fuelQuantity = 0;
                }
                else
                {
                    this.fuelQuantity = value;
                }
            }
        }

        public double FuelConsumptionPerKm { get; protected set; }

        public double TankCapacity { get; protected set; }

        public virtual string Drive(double distance)
        {
            double needFuel = distance * this.FuelConsumptionPerKm;

            if (this.FuelQuantity >= needFuel)
            {
                this.FuelQuantity -= needFuel;
                return $"{GetType().Name} travelled {distance} km";
            }

            return $"{GetType().Name} needs refueling";
        }

        public virtual void Refuel(double liters)
        {
            if(liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }            
            else if((this.FuelQuantity + liters) > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                this.FuelQuantity += liters;
            }

        }

        public override string ToString()
        {
            return $"{GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
