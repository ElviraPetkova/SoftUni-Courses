namespace FootballTeam
{
    using System;

    public class Player
    {
        private string name;
        private Stats stats;

        public Player(string name, Stats stats)
        {
            this.Name = name;
            this.Stats = stats;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                this.name = value;
            }
        }

        private Stats Stats
        {
            set
            {
                this.stats = value;
            }
        }

        public int SkillLevel
        {
            //averange all stats skills
            get
            {
                return (int)Math.Round((this.stats.Dribble
                + this.stats.Endurance
                + this.stats.Passing
                + this.stats.Shooting
                + this.stats.Sprint)
                / 5.0);
            }

        }
    }
}
