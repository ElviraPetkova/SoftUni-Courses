using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listOfStudents = new List<Student>();

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "end")
                {
                    break;
                }

                string[] info = input.Split();
                string firstName = info[0];
                string lastName = info[1];
                int age = int.Parse(info[2]);
                string town = info[3];

                Student oneStudent = new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    Town = town
                };

                listOfStudents.Add(oneStudent);
            }

            string searchTown = Console.ReadLine();

            var result = listOfStudents.Where(t => t.Town == searchTown).ToList();

            foreach (var student in result)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Town { get; set; }
    }
}
