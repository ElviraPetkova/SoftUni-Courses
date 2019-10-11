using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> courses = Console.ReadLine()
                .Split(", ")
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "course start")
                {
                    for (int i = 0; i < courses.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}.{courses[i]}");
                    }
                    break;
                }

                string[] info = input.Split(':');

                string command = info[0];
                string lesson = info[1];

                if(command == "Add")
                {
                    if(courses.Contains(lesson) == false)
                    {
                        courses.Add(lesson);
                    }
                }
                else if(command == "Insert")
                {
                    int index = int.Parse(info[2]);

                    if(index >= 0 && index < courses.Count)
                    {
                        if(courses.Contains(lesson) == false)
                        {
                            courses.Insert(index, lesson);
                        }
                    }
                }
                else if(command == "Remove")
                {
                    if (courses.Contains(lesson))
                    {
                        courses.Remove(lesson);

                        string exercise = lesson + "-Exercise";
                        if (courses.Contains(exercise))
                        {
                            courses.Remove(exercise);
                        }
                    }
                }
                else if(command == "Swap")
                {
                    string secondLesson = info[2];

                    if(courses.Contains(lesson) && courses.Contains(secondLesson))
                    {
                        int indexFirstLesson = courses.IndexOf(lesson);
                        int indexSecondLesson = courses.IndexOf(secondLesson);

                        courses[indexFirstLesson] = secondLesson;
                        courses[indexSecondLesson] = lesson;

                        string firstExercise = lesson + "-Exercise";
                        string secondExercise = secondLesson + "-Exercise";

                        if(courses.Contains(firstExercise) && courses.Contains(secondExercise))
                        {
                            courses[indexFirstLesson + 1] = secondExercise;
                            courses[indexSecondLesson + 1] = firstExercise;
                        }
                        else if(courses.Contains(firstExercise) && courses.Contains(secondExercise) == false)
                        {
                            if(indexSecondLesson == courses.Count - 1)
                            {
                                courses.Add(firstExercise);
                            }
                            else
                            {
                                courses.Insert(indexSecondLesson, firstExercise);
                                courses.RemoveAt(indexFirstLesson + 1);
                            }
                        }
                        else if(courses.Contains(firstExercise) == false && courses.Contains(secondExercise))
                        {
                            courses.Insert(indexFirstLesson + 1, secondExercise);
                            courses.RemoveAt(indexSecondLesson + 2);
                        }
                    }
                }
                else if(command == "Exercise")
                {
                    string exercise = lesson + "-Exercise";

                    if(courses.Contains(lesson) == false)
                    {
                        courses.Add(lesson);
                        courses.Add(exercise);
                    }
                    else if(courses.Contains(lesson) && courses.Contains(exercise) == false)
                    {
                        int indexLesson = courses.IndexOf(lesson);
                        courses.Insert(indexLesson + 1, exercise);
                    }
                }
            }
        }
    }
}
