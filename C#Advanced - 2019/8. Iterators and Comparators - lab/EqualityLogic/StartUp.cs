using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            HashSet<Person> hashPeople = new HashSet<Person>();
            SortedSet<Person> sortedPeople = new SortedSet<Person>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] information = Console.ReadLine()
                    .Split();

                string name = information[0];
                int age = int.Parse(information[1]);

                Person person = new Person(name, age);
                hashPeople.Add(person);
                sortedPeople.Add(person);
            }

            Console.WriteLine(hashPeople.Count);
            Console.WriteLine(sortedPeople.Count);
        }
    }
}
