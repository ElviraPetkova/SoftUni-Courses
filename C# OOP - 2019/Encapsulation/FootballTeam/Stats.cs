using System;

namespace FootballTeam
{
    public class Stats
    {
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Stats(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public int Endurance
        {
            get => this.endurance;
            private set
            {
                Validation(value, nameof(Endurance));
                this.endurance = value;
            }
        }

        public  int Sprint
        {
            get => this.sprint;
            private set
            {
                Validation(value, nameof(Sprint));
                this.sprint = value;
            }
        }

        public int Dribble
        {
            get => this.dribble;
            private set
            {
                Validation(value, nameof(Dribble));
                this.dribble = value;
            }
        }

        public  int Passing
        {
            get => this.passing;
            private set
            {
                Validation(value, nameof(Passing));
                this.passing = value;
            }
        }

        public  int Shooting
        {
            get => this.shooting;
            private set
            {
                Validation(value, nameof(Shooting));
                this.shooting = value;
            }
        }

        private void Validation(int value, string statsName)
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"{statsName} should be between 0 and 100.");
            }
        }
    }
}
