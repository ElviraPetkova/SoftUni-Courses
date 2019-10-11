using System;
using System.Linq;
using System.Collections.Generic;

namespace _10.__SoftUni_Course_Planning
{
    class Program
    {
        static void Main()
        {
            List<string> listOfCourse = Console.ReadLine()
                .Split(", ")
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "course start")
                {
                    break;
                }

                string[] tokens = input.Split(':');

                string command = tokens[0];
                string lesson = tokens[1];

                if (command == "Add")
                {
                    if (listOfCourse.Contains(lesson) == false)
                    {
                        listOfCourse.Add(lesson);
                    }
                }
                else if(command == "Insert")
                {
                    int index = int.Parse(tokens[2]);
                    
                    if(index < 0 || index > listOfCourse.Count - 1)
                    {
                        continue;
                    }

                    if (listOfCourse.Contains(lesson) == false)
                    {
                        listOfCourse.Insert(index, lesson);
                    }
                }
                else if(command == "Remove") //Check foe Exercise
                {
                    if (listOfCourse.Contains(lesson))
                    {
                        listOfCourse.Remove(lesson);

                        string exercise = $"{lesson}-Exercise";
                        if (listOfCourse.Contains(exercise))
                        {
                            listOfCourse.Remove(exercise);
                        }
                    }
                }
                else if(command == "Swap")
                {
                    string lessonTwo = tokens[2];

                    string exercise = $"{lesson}-Exercise";
                    string exerciseTwo = $"{lessonTwo}-Exercise";

                    if (listOfCourse.Contains(lesson) && listOfCourse.Contains(lessonTwo))
                    {
                        int indexPerFirstLesson = listOfCourse.IndexOf(lesson);
                        int indexPerSecondLesson = listOfCourse.IndexOf(lessonTwo);

                        listOfCourse[indexPerFirstLesson] = lessonTwo;
                        listOfCourse[indexPerSecondLesson] = lesson;

                        if(listOfCourse.Contains(exercise) && listOfCourse.Contains(exerciseTwo) == false)
                        {
                            listOfCourse.RemoveAt(indexPerFirstLesson + 1);
                            if (indexPerSecondLesson == listOfCourse.Count - 1)
                            {
                                listOfCourse.Add(exercise);
                            }
                            else
                            {
                                listOfCourse.Insert(indexPerSecondLesson + 1, exercise);
                            }                            
                        }
                        else if(listOfCourse.Contains(exercise) == false && listOfCourse.Contains(exerciseTwo))
                        {
                            listOfCourse.RemoveAt(indexPerSecondLesson + 1);
                            listOfCourse.Insert(indexPerFirstLesson + 1, exerciseTwo);
                        }
                    }
                }
                else if(command == "Exercise")
                {
                    string exercise = $"{lesson}-Exercise";

                    if (listOfCourse.Contains(lesson) && listOfCourse.Contains(exercise) == false)
                    {
                        int indexLesson = listOfCourse.IndexOf(lesson);
                        listOfCourse.Insert(indexLesson + 1, exercise);
                    }
                    else if(listOfCourse.Contains(lesson) == false)
                    {
                        listOfCourse.Add(lesson);
                        listOfCourse.Add(exercise);
                    }
                }
            }

            for (int i = 0; i < listOfCourse.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{listOfCourse[i]}");
            }
        }
    }
}
