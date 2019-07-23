using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int countOfCars = int.Parse(Console.ReadLine());
            List<Car> listOfCars = new List<Car>();

            for (int i = 0; i < countOfCars; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionPerKilometer = double.Parse(input[2]);

                Car newCar = new Car(model, fuelAmount, fuelConsumptionPerKilometer);
                
                listOfCars.Add(newCar);
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] line = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = line[0];
                string carModel = line[1];
                double amountOfKm = double.Parse(line[2]);

                bool isValidAction = ValidationAction(action);
                Car searhCar = ValidationCar(listOfCars, carModel);

                if (isValidAction && searhCar != null)
                {
                    searhCar.Drive(amountOfKm);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, listOfCars));
        }

        private static Car ValidationCar(List<Car> listOfCars, string carModel)
        {
            var searchCar = listOfCars.FirstOrDefault(x => x.Model == carModel);

            return searchCar;
        }

        private static bool ValidationAction(string action)
        {
            if(action == "Drive")
            {
                return true;
            }

            return false;
        }
    }
}
