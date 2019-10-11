using System;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudentsPerFisrtEmployee = int.Parse(Console.ReadLine());
            int countOfStudentsPerSecondEmployee = int.Parse(Console.ReadLine());
            int countOfStudentsPerThirdEmployee = int.Parse(Console.ReadLine());
            int totalStudents = int.Parse(Console.ReadLine());

            int countOfStudentPerOneHour = countOfStudentsPerFisrtEmployee + 
                    countOfStudentsPerSecondEmployee + countOfStudentsPerThirdEmployee;

            int totalHours = 0;

            while (totalStudents > 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    totalStudents -= countOfStudentPerOneHour;
                    totalHours++;
                    if (totalStudents <= 0)
                    {
                        break;
                    }
                }
                if (totalStudents <= 0)
                {
                    break;
                }
                totalHours++;
            }

            Console.WriteLine($"Time needed: {totalHours}h.");
        }
    }
}
