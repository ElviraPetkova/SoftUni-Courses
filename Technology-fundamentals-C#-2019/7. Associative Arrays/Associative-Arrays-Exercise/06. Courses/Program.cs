using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfCourses = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end")
                {
                    break;
                }

                string[] info = input.Split(" : ");
                string coursesName = info[0];
                string studentName = info[1];

                if(listOfCourses.ContainsKey(coursesName) == false)
                {
                    listOfCourses.Add(coursesName, new List<string>());
                    listOfCourses[coursesName].Add(studentName);
                }
                else
                {
                    if(listOfCourses[coursesName].Contains(studentName) == false)
                    {
                        listOfCourses[coursesName].Add(studentName);
                    }
                }
            }

            var result = listOfCourses.OrderByDescending(x => x.Value.Count).ToList();

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");

                var students = kvp.Value.OrderBy(x => x).ToList();
                foreach (var student in students)
                {
                    Console.WriteLine($"-- {student}");
                }
                
            }
        }
    }
}
