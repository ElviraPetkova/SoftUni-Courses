using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_projects
{
    class Team
    {
        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }

        public Team()
        {
            List<string> Members = new List<string>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Team> listOfTeams = new List<Team>();

            int countOfTeams = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfTeams; i++)
            {
                string[] line = Console.ReadLine().Split('-');
                string creator = line[0];
                string team = line[1];

                var creators = listOfTeams.Select(x => x.Creator).ToList();
                var teams = listOfTeams.Select(x => x.Name).ToList();

                if (creators.Contains(creator) == false && teams.Contains(team) == false)
                {
                    Team newTeam = new Team
                    {
                        Name = team,
                        Creator = creator,
                        Members = new List<string>()
                    };

                    listOfTeams.Add(newTeam);

                    Console.WriteLine($"Team {team} has been created by {creator}!");
                }
                else if (teams.Contains(team))
                {
                    Console.WriteLine($"Team {team} was already created!");
                }
                else if (creators.Contains(creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }

            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of assignment")
                {
                    break;
                }

                string[] info = input.Split("->");
                string user = info[0];
                string teamName = info[1];

                var teams = listOfTeams.Select(x => x.Name).ToList();
                if (teams.Contains(teamName) == false)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                bool isExistingUser = listOfTeams.Any(x => x.Members.Contains(user));
                bool isExistingCreator = listOfTeams.Any(x => x.Creator == user);
                if (isExistingCreator || isExistingUser)
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    continue;
                }

                foreach (var team in listOfTeams)
                {
                    if (team.Name == teamName)
                    {
                        team.Members.Add(user);
                        break;
                    }
                }
            }

            var bannTeams = listOfTeams
                .Where(m => m.Members.Count == 0)
                .OrderBy(n => n.Name)
                .ToList();

            var resultTeams = listOfTeams
                .Where(m => m.Members.Count > 0)
                .OrderByDescending(m => m.Members.Count)
                .ThenBy(n => n.Name)
                .ToList();

            foreach (Team team in resultTeams)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");

                foreach (var member in team.Members.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (Team team in bannTeams)
            {
                Console.WriteLine(team.Name);
            }
        }
    }
}
