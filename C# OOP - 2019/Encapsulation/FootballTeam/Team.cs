namespace FootballTeam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                this.name = value;
            }
        }

        public int Rating
        {
            get
            {
                return this.players.Count == 0 ? 0 : Convert.ToInt32((this.players.Average(p => p.SkillLevel)));
                //double allSkillLevels = 0;
                //this.players.ForEach(p => allSkillLevels += p.SkillLevel());

                //return (int)(allSkillLevels) / this.players.Count();
            }
        }

        public void Add(Player player)
        {
            this.players.Add(player);
        }

        public void Remove(string playerName)
        {
            if (!this.players.Exists(p=>p.Name == playerName))
            {
                throw new ArgumentException($"Player {playerName} is not in {this.Name} team.");
            }

            this.players.Remove(this.players.First(p => p.Name == playerName));
        }

        private IReadOnlyCollection<Player> Players => this.players.AsReadOnly();
    }
}
