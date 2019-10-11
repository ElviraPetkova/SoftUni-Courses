namespace Animals
{
    using System;
    using System.Collections.Generic;
    using Cats;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            string animalType;

            while ((animalType = Console.ReadLine()) != "Beast!")
            {
                string[] line = Console.ReadLine().Split();

                try
                {
                    string name = line[0];
                    int age = int.Parse(line[1]);
                    string gender = string.Empty;

                    switch (animalType)
                    {
                        case "Cat":
                            gender = line[2];
                            Cat cat = new Cat(name, age, gender);
                            animals.Add(cat);
                            break;
                        case "Dog":
                            gender = line[2];
                            Dog dog = new Dog(name, age, gender);
                            animals.Add(dog);
                            break;
                        case "Frog":
                            gender = line[2];
                            Frog frog = new Frog(name, age, gender);
                            animals.Add(frog);
                            break;
                        case "Kitten":
                            Kitten kitten = new Kitten(name, age);
                            animals.Add(kitten);
                            break;
                        case "Tomcat":
                            Tomcat tomcat = new Tomcat(name, age);
                            animals.Add(tomcat);
                            break;
                        default:
                            throw new ArgumentException("Invalid input!");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            animals.ForEach(Console.WriteLine);
        }
    }
}
