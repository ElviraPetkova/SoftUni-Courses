
using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    public class Car
    {
        public Car()
        {
            this.TravelledDistance = 0;
        }

        public Car(string model, double fuelAmout, double fuelConsumptionPerKilometer)
            : this()
        {
            this.Model = model;
            this.FuelAmount = fuelAmout;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        }

        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;

        public string Model
        {
            get { return this.model; }

            set { this.model = value;  }
        }

        public double FuelAmount
        {
            get { return this.fuelAmount; }

            set { this.fuelAmount = value; }
        }

        public double FuelConsumptionPerKilometer
        {
            get { return this.fuelConsumptionPerKilometer; }

            set { this.fuelConsumptionPerKilometer = value; }
        }

        public double TravelledDistance
        {
            get { return this.travelledDistance; }

            set { this.travelledDistance = value; }
        }

        public void Drive(double amoutOfKm)
        {
            bool canDriveCar = fuelAmount - (amoutOfKm * fuelConsumptionPerKilometer) >= 0;

            if (!canDriveCar)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                fuelAmount -= (amoutOfKm * fuelConsumptionPerKilometer);
                travelledDistance += amoutOfKm;
            }
        }

        public override string ToString()
        {
            string informationCar = $"{model} {fuelAmount:f2} {travelledDistance}";
            return informationCar.ToString();
        }
    }
}
