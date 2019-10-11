using System;
using System.Linq;
using System.Collections.Generic;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            var infoForStudents = new Dictionary<string, int>();
            var infoForSubmits = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input== "exam finished")
                {
                    break;
                }

                string[] info = input.Split('-');
                string studentName = info[0];
                string language = info[1];

                if(language == "banned")
                {
                    if (infoForStudents.ContainsKey(studentName))
                    {
                        infoForStudents.Remove(studentName);
                    }
                    continue;
                }

                int currentPoints = int.Parse(info[2]);

                if (infoForStudents.ContainsKey(studentName) == false)
                {
                    infoForStudents.Add(studentName, currentPoints);
                }
                else
                {
                    int points = infoForStudents[studentName];
                    if (currentPoints > points)
                    {
                        infoForStudents[studentName] = currentPoints;
                    }
                }

                if(infoForSubmits.ContainsKey(language) == false)
                {
                    infoForSubmits.Add(language, 0);
                }

                infoForSubmits[language]++;
            }

            var resultInfoForStudents = infoForStudents
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToList();

            var resultSubmits = infoForSubmits
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToList();

            Console.WriteLine("Results:");
            foreach (var student in resultInfoForStudents)
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var language in resultSubmits)
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}
