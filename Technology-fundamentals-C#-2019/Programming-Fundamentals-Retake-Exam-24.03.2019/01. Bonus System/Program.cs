using System;
using System.Collections.Generic;

namespace _01._Bonus_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            int countOfLections = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine()) + 5;

            double maxBonuses = 0;
            int lections = 0;

            for (int i = 1; i <= countOfStudents; i++)
            {
                int attendances = int.Parse(Console.ReadLine());

                //{totalBoonus} = {studentAttendances} / {courseLectures} * (5 + {additionalBonus})
                //Math.Ceiling

                double currentBonus = (double)attendances / countOfLections * initialBonus;
                
                if(maxBonuses < currentBonus)
                {
                    maxBonuses = currentBonus;
                    lections = attendances;
                }
            }

            Console.WriteLine($"The maximum bonus score for this course is {Math.Ceiling(maxBonuses)}.The student has attended {lections} lectures.");
        }
    }
}
