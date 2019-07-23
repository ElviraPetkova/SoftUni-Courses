using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 0; i < counter; i++)
            {
                string[] information = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = information[0];
                int age = int.Parse(information[1]);

                Person newPerson = new Person(name, age);
                people.Add(newPerson);
            }

            people
                .Where(x => x.Age > 30)
                .OrderBy(x => x.Name)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Name} - {x.Age}"));

            
        }
    }
}
