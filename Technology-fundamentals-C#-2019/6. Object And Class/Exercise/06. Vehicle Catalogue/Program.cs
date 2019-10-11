using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Vehicle_Catalogue
{
    class Truck
    {
        public string Model { get; set; }

        public string Color { get; set; }

        public int HorsePower { get; set; }
    }

    class Car
    {
        public string Model { get; set; }

        public string Color { get; set; }

        public int HorsePower { get; set; }
    }

    class Catalog
    {
        public Catalog()
        {
            List<Truck> Trucks = new List<Truck>();
            List<Car> Cars = new List<Car>();
        }

        public List<Truck> Trucks { get; set; }

        public List<Car> Cars { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Catalog vehicleCatalog = new Catalog()
            {
                Trucks = new List<Truck>(),
                Cars = new List<Car>()
            };

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] info = input.Split();
                string type = info[0];
                string model = info[1];
                string color = info[2];
                int power = int.Parse(info[3]);

                switch (type)
                {
                    case "truck":
                        Truck oneTruck = new Truck()
                        {
                            Model = model,
                            Color = color,
                            HorsePower = power
                        };

                        vehicleCatalog.Trucks.Add(oneTruck);
                        break;
                    case "car":
                        Car oneCar = new Car()
                        {
                            Model = model,
                            Color = color,
                            HorsePower = power
                        };
                        vehicleCatalog.Cars.Add(oneCar);
                        break;
                }

            }

            while (true)
            {
                string modelOfInput = Console.ReadLine();
                if(modelOfInput == "Close the Catalogue")
                {
                    break;
                }

                bool isFound = false;

                foreach (var car in vehicleCatalog.Cars)
                {
                    if(car.Model == modelOfInput)
                    {
                        Console.WriteLine("Type: Car");
                        Console.WriteLine($"Model: {modelOfInput}");
                        Console.WriteLine($"Color: {car.Color}");
                        Console.WriteLine($"Horsepower: {car.HorsePower}");
                        isFound = true;
                        break;
                    }
                }

                if(isFound == false)
                {
                    foreach (var truck in vehicleCatalog.Trucks)
                    {
                        if (truck.Model == modelOfInput)
                        {
                            Console.WriteLine("Type: Truck");
                            Console.WriteLine($"Model: {modelOfInput}");
                            Console.WriteLine($"Color: {truck.Color}");
                            Console.WriteLine($"Horsepower: {truck.HorsePower}");
                            break;
                        }
                    }
                }
                
            }
            double averangePerCars = 0;
            if (vehicleCatalog.Cars.Count != 0)
            {
                averangePerCars = vehicleCatalog.Cars.Average(x => x.HorsePower);
            }

            double averangePerTrucks = 0;
            if (vehicleCatalog.Trucks.Count != 0)
            {
                averangePerTrucks = vehicleCatalog.Trucks.Average(x => x.HorsePower);
            }
            
            Console.WriteLine($"Cars have average horsepower of: {averangePerCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averangePerTrucks:f2}.");

        }
    }
}

