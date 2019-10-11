using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Students_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listOfStudents = new List<Student>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                string[] info = input.Split();
                string firstName = info[0];
                string lastName = info[1];
                int age = int.Parse(info[2]);
                string town = info[3];

                if(IsStudentExisting(listOfStudents, firstName, lastName))
                {
                    Student oneStudent = GetStudent(listOfStudents, firstName, lastName);

                    oneStudent.FirstName = firstName;
                    oneStudent.LastName = lastName;
                    oneStudent.Age = age;
                    oneStudent.Town = town;
                }
                else
                {
                    Student oneStudent = new Student
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        Town = town
                    };

                    listOfStudents.Add(oneStudent);
                }
            }

            string searchTown = Console.ReadLine();

            var result = listOfStudents.Where(t => t.Town == searchTown).ToList();

            foreach (var student in result)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

        private static Student GetStudent(List<Student> listOfStudents, string firstName, string lastName)
        {
            Student existingStudent = null;
            foreach (var student in listOfStudents)
            {
                if(student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                    break;
                }
            }

            return existingStudent;
        }

        private static bool IsStudentExisting(List<Student> listOfStudents, string firstName, string lastName)
        {
            foreach (var student in listOfStudents)
            {
                if(student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
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
