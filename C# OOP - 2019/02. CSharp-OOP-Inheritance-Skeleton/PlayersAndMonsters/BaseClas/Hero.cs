namespace PlayersAndMonsters
{
    public class Hero
    {
        public Hero(string username, int level)
        {
            this.Username = username;
            this.Level = level;
        }

        public string Username { get; protected set; }

        public int Level { get; protected set; }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }
    }
}
