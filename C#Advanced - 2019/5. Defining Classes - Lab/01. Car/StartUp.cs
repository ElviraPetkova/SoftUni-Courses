using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Tire[]> listOfTires = new List<Tire[]>();

            while (input != "No more tires")
            {
                var splitedInput = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var collectionOfYears = new List<int>();
                var collectionOfPressures = new List<double>();

                for (int i = 0; i < splitedInput.Length - 1; i+=2)
                {
                    int currentYear = int.Parse(splitedInput[i]);
                    double currentPressure = double.Parse(splitedInput[i + 1]);
                    collectionOfYears.Add(currentYear);
                    collectionOfPressures.Add(currentPressure);
                }

                Tire[] tires = new Tire[4];
                for (int i = 0; i < collectionOfYears.Count; i++)
                {
                    tires[i] = new Tire(collectionOfYears[i], collectionOfPressures[i]);
                }

                listOfTires.Add(tires);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            List<Engine> listOfEngine = new List<Engine>();

            while (input != "Engines done")
            {
                var splitedInput = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int currentHorsePower = int.Parse(splitedInput[0]);
                double currentCubicCapacity = double.Parse(splitedInput[1]);

                Engine currentEngine = new Engine(currentHorsePower, currentCubicCapacity);
                listOfEngine.Add(currentEngine);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            List<Car> listOfCars = new List<Car>();

            while (input != "Show special")
            {
                //{make} {model} {year} {fuelQuantity} {fuelConsumption} {engineIndex} {tiresIndex}
                var splitedInput = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string make = splitedInput[0];
                string model = splitedInput[1];
                int year = int.Parse(splitedInput[2]);
                double fuelQuantity = double.Parse(splitedInput[3]);
                double fuelConsumption = double.Parse(splitedInput[4]);
                int engineIndex = int.Parse(splitedInput[5]);
                int tiresIndex = int.Parse(splitedInput[6]);

                if(engineIndex < 0 || engineIndex >= listOfEngine.Count 
                    || tiresIndex < 0 || tiresIndex >= listOfTires.Count)//=>invalid index
                {
                    continue;
                }

                Engine newEngine = listOfEngine[engineIndex];
                Tire[] newTires = listOfTires[tiresIndex];

                Car newCar = new Car(make, model, year, fuelQuantity, fuelConsumption, newEngine, newTires);
                listOfCars.Add(newCar);

                input = Console.ReadLine();
            }

            var resultCars = listOfCars
                .Where(x => x.Year >= 2017)
                .Where(x => x.Engine.HorsePower > 330) //pressure betwen 9 - 10;
                .Where(x=>x.Tires.Sum(y=>y.Pressure) > 9)
                .Where(x => x.Tires.Sum(y => y.Pressure) < 10)
                .ToList();

            //resultCars.ForEach(x => x.Drive(20));

            foreach (Car car in resultCars)
            {
                car.Drive(20);
                Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\n" +
                    $"Year: {car.Year}\nHorsePowers: {car.Engine.HorsePower}\n" +
                    $"FuelQuantity: {car.FuelQuantity:f1}");
            }
        }
    }
}
