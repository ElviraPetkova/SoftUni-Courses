using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    public class StartUp
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string input = Console.ReadLine();
                var splitedInput = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = splitedInput[0];

                if(command == "END")
                {
                    break;
                }

                Person currentPerson = new Person(splitedInput[0], int.Parse(splitedInput[1]), splitedInput[2]);
                people.Add(currentPerson);
            }

            int positionOfThePerson = int.Parse(Console.ReadLine());

            Person person = people[positionOfThePerson - 1];

            int equalPeople = ChekingEqualPeople(person, people);
            if (equalPeople > 1)
            {
                Console.WriteLine($"{equalPeople} {people.Count - equalPeople} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }

        }

        public static int ChekingEqualPeople(Person person, List<Person> people)
        {
            int equalPeople = 0;

            foreach (var currentPerson in people)
            {
                if(currentPerson.CompareTo(person) == 0)
                {
                    equalPeople++;
                }
            }

            return equalPeople;
        }
    }
}
