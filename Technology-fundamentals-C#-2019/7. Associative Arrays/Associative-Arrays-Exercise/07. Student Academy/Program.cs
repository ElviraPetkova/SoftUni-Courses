using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfStudents = new Dictionary<string, List<double>>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if(listOfStudents.ContainsKey(name) == false)
                {
                    listOfStudents.Add(name, new List<double>());
                }

                listOfStudents[name].Add(grade);
            }

            var studentsAndAverangeGrade = new Dictionary<string, double>(); // key = name, value = averange grade

            foreach (var kvp in listOfStudents)
            {
                double averange = kvp.Value.Average();
                studentsAndAverangeGrade.Add(kvp.Key, averange);
            }

            var result = studentsAndAverangeGrade
                .Where(x => x.Value >= 4.50)
                .OrderByDescending(x => x.Value)
                .ToList();

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            }
        }
    }
}
