using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            List<Person> peoples = new List<Person>();
            Family family = new Family();
            //{
            //    ListOfPeople = peoples
            //};

            for (int i = 0; i < counter; i++)
            {
                string[] information = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = string.Empty;
                int age = 0;

                if (information.Length > 1)
                {
                    name = information[0];
                    age = int.Parse(information[1]);
                }

                Person newPerson = new Person(name, age);
                family.AddMember(newPerson);
            }


            //Person oldest = family.GetOldestMember(family.ListOfPeople);
            Person oldest = family.GetOldestMember();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}
