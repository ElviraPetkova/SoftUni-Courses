using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_by_Age
{
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            var people = new List<Person>();

            for (int i = 0; i < counter; i++)
            {
                string[] information = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string name = information[0];
                int age = int.Parse(information[1]);
                Person newPerson = new Person()
                {
                    Name = name,
                    Age = age
                };
                people.Add(newPerson);
            }

            string condition = Console.ReadLine();
            int searchAge = int.Parse(Console.ReadLine());
            Func<Person, bool> tester = CreateTester(condition, searchAge);

            string format = Console.ReadLine();
            Action<Person> printer = CreatePrinter(format);

            PrintFilteredStudent(people, tester, printer);

        }

        private static void PrintFilteredStudent(List<Person> people, Func<Person, bool> tester, Action<Person> printer)
        {
            people
                .Where(tester)
                .ToList()
                .ForEach(printer);
        }

        private static Action<Person> CreatePrinter(string format)
        {
            if(format == "name")
            {
                return p => Console.WriteLine($"{p.Name}");
            }
            else if(format == "name age")
            {
                return p => Console.WriteLine($"{p.Name} - {p.Age}");
            }
            else if(format == "age name")
            {
                return p => Console.WriteLine($"{p.Age} - {p.Name}");
            }
            else if(format == "age")
            {
                return p => Console.WriteLine($"{p.Age}");
            }
            else
            {
                return null;
            }
        }

        private static Func<Person, bool> CreateTester(string condition, int searchAge)
        {
            if(condition == "older")
            {
                return x => x.Age >= searchAge;
            }
            else
            {
                return x => x.Age < searchAge;
            }
        }
    }
}
