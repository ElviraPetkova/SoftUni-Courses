namespace WildFarm
{
    using System;
    using System.Collections.Generic;
    using Models.Animals;
    using Models.Animals.Birds;
    using Models.Animals.Mammals;
    using Models.Animals.Mammals.Felines;
    using Models.Foods;
    using System.Linq;

    public class Startup
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string line = string.Empty;

            List<Animal> animals = new List<Animal>();

            while ((line = Console.ReadLine()) != "End")
            {
                var information = line.Split(" ");

                counter++;

                if (counter % 2 != 0)
                {
                    string type = information[0];
                    string name = information[1];
                    double weight = double.Parse(information[2]);

                    Animal animal = null;

                    switch (type)
                    {
                        case "Owl":
                            double wingSize = double.Parse(information[3]);
                            animal = new Owl(name, weight, wingSize);
                            break;
                        case "Hen":
                            double wingSizes = double.Parse(information[3]);
                            animal = new Hen(name, weight, wingSizes);
                            break;
                        case "Mouse":
                            string livingRegion = information[3];
                            animal = new Mouse(name, weight, livingRegion);
                            break;
                        case "Dog":
                            string livingRegiones = information[3];
                            animal = new Dog(name, weight, livingRegiones);
                            break;
                        case "Cat":
                            string livingRegions = information[3];
                            string breed = information[4];
                            animal = new Cat(name, weight, livingRegions, breed);
                            break;
                        case "Tiger":
                            string livingRegionse = information[3];
                            string breeds = information[4];
                            animal = new Tiger(name, weight, livingRegionse, breeds);
                            break;
                    }

                    animals.Add(animal);
                }
                else
                {
                    string foodName = information[0];
                    int quantity = int.Parse(information[1]);

                    Food food = null;

                    switch (foodName)
                    {
                        case "Vegetable": food = new Vegetable(quantity); break;
                        case "Seeds": food = new Seeds(quantity); break;
                        case "Meat": food = new Meat(quantity); break;
                        case "Fruit": food =  new Fruit(quantity); break;

                    }

                    Animal currentAnimal = animals[(counter/ 2) - 1];
                    Console.WriteLine(currentAnimal.AskFood());

                    try
                    {
                        currentAnimal.Feed(food);

                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
