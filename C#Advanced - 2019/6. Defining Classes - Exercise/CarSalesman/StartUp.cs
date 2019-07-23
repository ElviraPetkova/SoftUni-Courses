using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int countOfEngine = int.Parse(Console.ReadLine());

            List<Engine> listOfEngine = new List<Engine>();

            for (int i = 0; i < countOfEngine; i++)
            {
                string[] information = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                //"{model} {power} {displacement} {efficiency}"

                Engine newEngine = new Engine(information[0], int.Parse(information[1]));

                if(information.Length == 3)
                {
                    int number;
                    bool success = int.TryParse(information[2], out number);
                    if (success)
                    {
                        newEngine.Displacement = information[2];
                    }
                    else
                    {
                        newEngine.Efficiency = information[2];
                    }
                    
                }
                else if(information.Length == 4)
                {
                    newEngine.Displacement = information[2];
                    newEngine.Efficiency = information[3];
                }

                listOfEngine.Add(newEngine);
            }

            int countOfCars = int.Parse(Console.ReadLine());

            List<Car> listOfCars = new List<Car>();

            for (int i = 0; i < countOfCars; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                //"{model} {engine} {weight} {color}

                string modelCar = input[0];
                string modelEngine = input[1];

                var currentEngine = listOfEngine
                    .FirstOrDefault(x => x.Model == modelEngine);
                if(currentEngine == null) //I don't know what happend this case?
                {
                    continue;
                }

                Car newCar = new Car(modelCar, currentEngine);

                if(input.Length == 3)
                {
                    int number;
                    bool success = int.TryParse(input[2], out number);
                    if (success)
                    {
                        newCar.Weight = input[2];
                    }
                    else
                    {
                        newCar.Color = input[2];
                    }
                }
                else if(input.Length == 4)
                {
                    newCar.Weight = input[2];
                    newCar.Color = input[3];
                }

                listOfCars.Add(newCar);
            }

            foreach (var item in listOfCars)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
