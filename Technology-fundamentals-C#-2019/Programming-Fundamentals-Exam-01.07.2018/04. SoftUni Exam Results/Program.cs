using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsSubmits = new Dictionary<string, int>();
            var judjeSistems = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "exam finished")
                {
                    break;
                }

                var tokens = input.Split('-');
                string studentName = tokens[0];
                
                if(tokens[1] == "banned")
                {
                    if (studentsSubmits.ContainsKey(studentName))
                    {
                        studentsSubmits.Remove(studentName);
                    }
                }
                else
                {
                    string language = tokens[1];
                    int points = int.Parse(tokens[2]);

                    if (studentsSubmits.ContainsKey(studentName) == false)
                    {
                        studentsSubmits.Add(studentName, points);
                    }
                    else
                    {
                        if(studentsSubmits[studentName] < points)
                        {
                            studentsSubmits[studentName] = points;
                        }
                    }

                    if(judjeSistems.ContainsKey(language) == false)
                    {
                        judjeSistems.Add(language, 0);
                    }

                    judjeSistems[language]++;
                }
            }

            Console.WriteLine("Results:");
            foreach (var kvp in studentsSubmits.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var kvp in judjeSistems.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
