namespace OnlineRadioDatabase
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Playlist
    {
        private List<Song> songs;

        public Playlist()
        {
            this.songs = new List<Song>();
        }

        public string AddSong(Song song)
        {
            this.songs.Add(song);

            return "Song added.";
        }

        public override string ToString()
        {
            int totalLenght = this.songs.Select(s => s.GetLenghtInSeconds()).Sum();

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Songs added: {this.songs.Count}")
                .Append($"Playlist length: {totalLenght / 3600}h {totalLenght / 60 % 60}m {totalLenght % 60}s");
            
            return stringBuilder.ToString();
        }
    }
}
