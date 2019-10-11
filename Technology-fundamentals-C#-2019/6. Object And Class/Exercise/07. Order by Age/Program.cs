using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }

        public string Name { get; set; }

        public string Id { get; set; }

        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "End")
                {
                    break;
                }

                string[] info = input.Split();
                string name = info[0];
                string idPerPerson = info[1];
                int age = int.Parse(info[2]);

                Person onePerson = new Person(name, idPerPerson, age);
                people.Add(onePerson);
            }

            people = people.OrderBy(p => p.Age).ToList();

            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
}
