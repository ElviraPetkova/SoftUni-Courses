namespace ExplicitInterfaces
{
    using System;
    using Contracts;
    using Models;

    public class StartUp
    {
        static void Main(string[] args)
        {
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                //name, country, age
                Citizen citizen = new Citizen(arguments[0]);
                IResident rezident = citizen;
                IPerson person = citizen;

                Console.WriteLine($"{person.GetName()}");
                Console.WriteLine($"{rezident.GetName()}");
            }
        }
    }
}
