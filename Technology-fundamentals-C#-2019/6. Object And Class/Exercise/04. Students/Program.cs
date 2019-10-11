using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listOfStudents = new List<Student>();

            int numberOfInput = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInput; i++)
            {
                string[] info = Console.ReadLine().Split();
                string firstName = info[0];
                string lastName = info[1];
                double grade = double.Parse(info[2]);

                Student oneStudent = new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Grade = grade
                };

                listOfStudents.Add(oneStudent);
            }

            listOfStudents = listOfStudents.OrderByDescending(g => g.Grade).ToList();

            foreach (Student student in listOfStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
}
