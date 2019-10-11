namespace Vehicles
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            for (int i = 0; i < 3; i++)
            {
                string[] information = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string typeVehicle = information[0];
                double quantity = double.Parse(information[1]);
                double litersPerKm = double.Parse(information[2]);
                double tankCapacity = double.Parse(information[3]);

                switch (typeVehicle)
                {
                    case "Car":
                        Car car = new Car(quantity, litersPerKm, tankCapacity);
                        vehicles.Add(car);
                        break;
                    case "Truck":
                        Truck truck = new Truck(quantity, litersPerKm, tankCapacity);
                        vehicles.Add(truck);
                        break;
                    case "Bus":
                        Bus bus = new Bus(quantity, litersPerKm, tankCapacity);
                        vehicles.Add(bus);
                        break;
                }
            }
            
            int countOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfCommands; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = input[0];
                string typeVechicle = input[1];
                double litersOrDistance = double.Parse(input[2]);

                try
                {
                    if (typeVechicle == "Car")
                    {
                        Car car = (Car)vehicles.FirstOrDefault(x => x.GetType().Name == "Car");
                        switch (command)
                        {
                            case "Drive": Console.WriteLine(car.Drive(litersOrDistance)); break;
                            case "Refuel": car.Refuel(litersOrDistance); break;
                        }
                    }
                    else if (typeVechicle == "Truck")
                    {
                        Truck truck = (Truck)vehicles.FirstOrDefault(x => x.GetType().Name == "Truck");
                        switch (command)
                        {
                            case "Drive": Console.WriteLine(truck.Drive(litersOrDistance)); break;
                            case "Refuel": truck.Refuel(litersOrDistance); break;
                        }
                    }
                    else if (typeVechicle == "Bus")
                    {
                        Bus bus = (Bus)vehicles.FirstOrDefault(x => x.GetType().Name == "Bus");
                        switch (command)
                        {
                            case "Drive": Console.WriteLine(bus.Drive(litersOrDistance)); break;
                            case "DriveEmpty": Console.WriteLine(bus.DriveEmpty(litersOrDistance)); break;
                            case "Refuel": bus.Refuel(litersOrDistance); break;
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }
            
        }
    }
}
