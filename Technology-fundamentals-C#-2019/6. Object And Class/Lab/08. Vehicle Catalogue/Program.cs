using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Vehicle_Catalogue
{
    class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

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
                if(input == "end")
                {
                    break;
                }

                string[] info = input.Split('/');
                string type = info[0];
                string brand = info[1];
                string model = info[2];
                int power = int.Parse(info[3]);

                switch (type)
                {
                    case "Truck":
                        Truck oneTruck = new Truck()
                        {
                            Brand = brand,
                            Model = model,
                            Weight = power
                        };

                        vehicleCatalog.Trucks.Add(oneTruck);
                        break;
                    case "Car":
                        Car oneCar = new Car()
                        {
                            Brand = brand,
                            Model = model,
                            HorsePower = power
                        };
                        vehicleCatalog.Cars.Add(oneCar);
                        break;
                }

            }

            Console.WriteLine("Cars: ");
            foreach (var item in vehicleCatalog.Cars.OrderBy(b=>b.Brand))
            {
                Console.WriteLine($"{item.Brand}: {item.Model} - {item.HorsePower}hp");
            }

            Console.WriteLine("Trucks: ");
            foreach (var item in vehicleCatalog.Trucks.OrderBy(x=>x.Brand))
            {
                Console.WriteLine($"{item.Brand}: {item.Model} - {item.Weight}kg");
            }

        }
    }
}
