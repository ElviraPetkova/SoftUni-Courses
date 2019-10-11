namespace PersonsInfo
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main(string[] args)
        {
            Team team = new Team("SoftUni");
                
            int lines = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    Person person = new Person(input[0],
                                           input[1],
                                           int.Parse(input[2]),
                                           decimal.Parse(input[3]));

                    people.Add(person);
                }
                catch(ArgumentException mess)
                {
                    Console.WriteLine(mess.Message);
                }
            }

            foreach (Person person in people)
            {
                team.AddPlayer(person);
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");

            //decimal percentage = decimal.Parse(Console.ReadLine());

            //people.ForEach(p => p.IncreaseSalary(percentage));
            //people.ForEach(p => Console.WriteLine(p));
        }
    }
}
