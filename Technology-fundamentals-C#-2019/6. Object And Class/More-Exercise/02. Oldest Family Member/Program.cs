using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Oldest_Family_Member
{
    class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }
    }

    class Family
    {
        public Family()
        {
            People = new List<Person>();
        }

        public List<Person> People { get; set; }

        public void AddMember(Person newPerson)
        {
            People.Add(newPerson);
        }

        public Person GetOldestMember()
        {
            int oldestMemberAge = People.Select(x => x.Age).Max();
            Person oldestMember = People.First(x => x.Age == oldestMemberAge);

            return oldestMember;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());

            Family newFamily = new Family()
            {
                People = new List<Person>()
            };

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] personInfo = Console.ReadLine().Split();
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);

                Person onePerson = new Person(name, age);

                newFamily.AddMember(onePerson);
            }

            Person oldestMember = newFamily.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
