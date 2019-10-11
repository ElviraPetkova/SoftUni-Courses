namespace FootballTeam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] commands = input.Split(";");
                string firstCommand = commands[0];
                string teamName = commands[1];

                try
                {
                    if (firstCommand == "Team")
                    {
                        Team team = new Team(teamName);
                        teams.Add(team);
                    }
                    else if (firstCommand == "Add")
                    {
                        //Add;Arsenal;Kieran_Gibbs;75;85;84;92;67
                        Team currentTeam = ChekingTeams(teams, teamName);
                        string namePlayer = commands[2];
                        Stats stats = new Stats(int.Parse(commands[3]),
                            int.Parse(commands[4]),
                            int.Parse(commands[5]),
                            int.Parse(commands[6]),
                            int.Parse(commands[7]));
                        Player player = new Player(namePlayer, stats);

                        currentTeam.Add(player);
                    }
                    else if (firstCommand == "Remove")
                    {
                        Team currentTeam = ChekingTeams(teams, teamName);
                        string namePlayer = commands[2];

                        currentTeam.Remove(namePlayer);
                    }
                    else if (firstCommand == "Rating")
                    {
                        Team currentTeam = ChekingTeams(teams, teamName);

                        Console.WriteLine($"{currentTeam.Name} - {currentTeam.Rating}");
                    }
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static Team ChekingTeams(List<Team> teams, string teamName)
        {
            if(!teams.Exists(t=>t.Name == teamName))
            {
                throw new ArgumentException($"Team {teamName} does not exist.");
            }

            return teams.First(t => t.Name == teamName);
        }
    }
}
