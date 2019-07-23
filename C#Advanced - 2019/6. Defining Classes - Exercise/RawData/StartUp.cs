using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            List<Car> listOfCars = new List<Car>();

            for (int i = 0; i < counter; i++)
            {
                string[] information = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                //{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType} {tire1Pressure} {tire1Age}

                Car newCar = new Car(information[0],
                     int.Parse(information[1]), int.Parse(information[2]),
                     int.Parse(information[3]), information[4],
                     double.Parse(information[5]), int.Parse(information[6]),
                     double.Parse(information[7]), int.Parse(information[8]),
                     double.Parse(information[9]), int.Parse(information[10]),
                     double.Parse(information[11]), int.Parse(information[12]));

                listOfCars.Add(newCar);
            }

            string type = Console.ReadLine().ToLower();
            var resultList = Filter(listOfCars, type);

            foreach (var item in resultList)
            {
                Console.WriteLine(item.Model);
            }
        }

        private static List<Car> Filter(List<Car> listOfCars, string type)
        {
            List<Car> cars = new List<Car>();
            if (type == "fragile")
            {
                cars = listOfCars
                    .Where(x => x.Tires[1].Pressure < 1)
                    .ToList();
            }
            else if(type == "flamable")
            {
                cars = listOfCars
                    .Where(x => x.Engine.Power > 250)
                    .ToList();
            }

            return cars;
        }
    }
}
