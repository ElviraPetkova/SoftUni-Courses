namespace Mankind
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] infoPerStudent = Console.ReadLine().Split();
            string studentFirstName = infoPerStudent[0];
            string studentLastName = infoPerStudent[1];
            string facNumber = infoPerStudent[2];

            string[] infoPerWorker = Console.ReadLine().Split();
            string workerFirstName = infoPerWorker[0];
            string workerLastName = infoPerWorker[1];
            double salary = double.Parse(infoPerWorker[2]);
            double hours = double.Parse(infoPerWorker[3]);

            try
            {
                Student student = new Student(studentFirstName, studentLastName, facNumber);
                Worker worker = new Worker(workerFirstName, workerLastName, salary, hours);

                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
