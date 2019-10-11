using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Company_Roster
{
    class Employee
    {
        public Employee(string name, double salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }

        public string Name { get; set; }

        public double Salary { get; set; }

        public string Department { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEmpoyee = int.Parse(Console.ReadLine());

            Dictionary<string, List<Employee>> listOfEmpoyee = new Dictionary<string, List<Employee>>();
            //key = department, value = List of employee

            for (int i = 0; i < numberOfEmpoyee; i++)
            {
                string[] info = Console.ReadLine().Split();
                string name = info[0];
                double salary = double.Parse(info[1]);
                string department = info[2];

                Employee newEmployee = new Employee(name, salary, department);

                if(listOfEmpoyee.ContainsKey(department) == false)
                {
                    listOfEmpoyee.Add(department, new List<Employee>());
                }

                listOfEmpoyee[department].Add(newEmployee);
            }

            double averangeSalaryMax = 0;
            string bestDepartment = string.Empty;

            foreach (var kvp in listOfEmpoyee)
            {
                string department = kvp.Key;
                double salary = 0;
                foreach (var employee in kvp.Value)
                {
                    salary += employee.Salary;
                }

                salary /= kvp.Value.Count;

                if(averangeSalaryMax < salary)
                {
                    averangeSalaryMax = salary;
                    bestDepartment = department;
                }
            }

            Console.WriteLine($"Highest Average Salary: {bestDepartment}");

            var result = listOfEmpoyee.Where(x => x.Key == bestDepartment);

            foreach (var kvp in result)
            {
                foreach (var employee in kvp.Value.OrderByDescending(x=>x.Salary))
                {
                    Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
                }
                
            }
        }

    }
}
