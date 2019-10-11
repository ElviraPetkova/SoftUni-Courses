namespace P01_RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
   
    public class StartUp
    {
        static void Main(string[] args)
        {
            RawData cars = new RawData();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string model = parameters[0];
                int engineSpeed = int.Parse(parameters[1]);
                int enginePower = int.Parse(parameters[2]);
                int cargoWeight = int.Parse(parameters[3]);
                string cargoType = parameters[4];
                
                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Tire[] tires = new Tire[4];
                ComposeTires(tires, parameters.Skip(5).ToArray());

                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);

            }

            string command = Console.ReadLine();

            List<string> filterCars = cars.FilterCars(command);

            Console.WriteLine(string.Join(Environment.NewLine, filterCars));

        }

        private static void ComposeTires(Tire[] tires, string[] parameters)
        {
            int index = 0;

            for (int i = 0; i < parameters.Length; i+=2)
            {
                double pressure = double.Parse(parameters[i]);
                int age = int.Parse(parameters[i + 1]);
                tires[index] = new Tire(pressure, age);
                index++;
            }
        }
    }
}
