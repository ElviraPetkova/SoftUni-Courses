using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Speed_Racing
{
    class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumation, int traveled)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionFor1km = fuelConsumation;
            this.DistanceTraveled = traveled;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionFor1km { get; set; }

        public int DistanceTraveled { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] info = Console.ReadLine().Split();
                string model = info[0];
                double fuelAmount = double.Parse(info[1]);
                double fuelConsumation = double.Parse(info[2]);

                Car oneCar = new Car(model, fuelAmount, fuelConsumation, 0);
                cars.Add(oneCar);
            }

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "End")
                {
                    break;
                }

                string[] info = input.Split();
                string model = info[1];
                int distance = int.Parse(info[2]); //may be distance is double

                Car searchCar = cars.First(x => x.Model == model);
                int indexCar = cars.IndexOf(searchCar);
                double fuelConsumation = searchCar.FuelConsumptionFor1km;
                double fuelAmount = searchCar.FuelAmount;

                double needFuel = distance * fuelConsumation;
                if(needFuel > fuelAmount)
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
                else
                {
                    fuelAmount -= needFuel;
                    cars[indexCar].FuelAmount = fuelAmount;
                    cars[indexCar].DistanceTraveled += distance;
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.DistanceTraveled}");
            }
        }
    }
}
