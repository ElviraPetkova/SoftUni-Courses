namespace OnlineRadioDatabase
{
    using Exceptions;
    using System.Linq;

    public class Song
    {
        private string artist;
        private string name;
        private int minutes;
        private int seconds;

        public Song(params string[] arguments)
        {
            ValidateArguments(arguments);
            this.Artist = arguments[0];
            this.Name = arguments[1];
            int[] lenghtSong = ValidateLenghtSong(arguments[2]);
            this.Minutes = lenghtSong[0];
            this.Seconds = lenghtSong[1];
        }

        private int[] ValidateLenghtSong(string value)
        {
            string[] time = value.Split(':');

            if(time.Length != 2 || time.Any(t=> !t.All(s => char.IsDigit(s))))
            {
                throw new InvalidSongLengthException();
            }

            return time.Select(int.Parse).ToArray();
        }

        private void ValidateArguments(string[] arguments)
        {
            if(arguments.Length != 3)
            {
                throw new InvalidSongException();
            }
        }

        private string Artist
        {
            set
            {
                if(value.Length < 3 || value.Length > 20)
                {
                    throw new InvalidArtistNameException();
                }

                this.artist = value;
            }
        }

        private string Name
        {
            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new InvalidSongNameException();
                }

                this.name = value;
            }
        }

        private int Minutes
        {
            set
            {
                if(value < 0 || value > 14)
                {
                    throw new InvalidSongMinutesException();
                }

                this.minutes = value;
            }
        }

        private int Seconds
        {
            set
            {
                if(value < 0 || value > 59)
                {
                    throw new InvalidSongSecondsException();
                }

                this.seconds = value;
            }
        }

        public int GetLenghtInSeconds() => (this.minutes * 60) + this.seconds;
    }
}
