using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Raw_Data
{
    class Car
    {
        public Car(string model, Engine engine, Cargo cargo)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }
    }

    class Engine
    {
        public Engine(int speed, int power)
        {
            this.EngineSpeed = speed;
            this.EnginePower = power;
        }

        public int EngineSpeed { get; set; }

        public int EnginePower { get; set; }
    }

    class Cargo
    {
        public Cargo(int weight, string type)
        {
            this.CargoWeight = weight;
            this.CargoType = type;
        }

        public int CargoWeight { get; set; }

        public string CargoType { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] info = Console.ReadLine().Split();

                string model = info[0];
                int speed = int.Parse(info[1]); //Engine=> speed and power
                int power = int.Parse(info[2]); 
                int weight = int.Parse(info[3]); //Cargo=> weight and type
                string type = info[4];

                Engine oneEngine = new Engine(speed, power);
                Cargo oneCargo = new Cargo(weight, type);
                Car oneCar = new Car(model, oneEngine, oneCargo);

                cars.Add(oneCar);
            }

            string typePerCargo = Console.ReadLine();

            if (typePerCargo == "fragile")
            {
                var result = cars
                    .Where(x => x.Cargo.CargoType == typePerCargo && x.Cargo.CargoWeight < 1000)
                    .ToList();

                foreach (var car in result)
                {
                    Console.WriteLine(car.Model);
                }
                
            }
            else if(typePerCargo == "flamable")
            {
                var result = cars
                    .Where(x => x.Cargo.CargoType == typePerCargo && x.Engine.EnginePower > 250)
                    .ToList();

                foreach (var car in result)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
