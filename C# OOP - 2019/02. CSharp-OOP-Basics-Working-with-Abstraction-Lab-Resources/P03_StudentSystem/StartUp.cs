namespace P03_StudentSystem
{
    using System;

    class StartUp
    {
        static void Main()
        {
            StudentSystem studentSystem = new StudentSystem();
            Parser parser = new Parser();

            while (true)
            {
                string[] arguments = parser.ParseCommand();
                string extion = arguments[0];

                if(extion == "Create")
                {
                    string name = arguments[1];
                    int age = int.Parse(arguments[2]);
                    double grade = double.Parse(arguments[3]);

                    studentSystem.Add(name, age, grade);
                }
                else if(extion == "Show")
                {
                    string name = arguments[1];
                    Console.WriteLine(studentSystem.Show(name));
                }
                else if(extion == "Exit")
                {
                    break;
                }
            }
        }
    }
}
