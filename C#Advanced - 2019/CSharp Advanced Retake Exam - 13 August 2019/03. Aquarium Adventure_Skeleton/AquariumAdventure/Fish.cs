using System.Text;

namespace AquariumAdventure
{
    public class Fish
    {
        public Fish(string name, string color, int fins)
        {
            this.Name = name;
            this.Color = color;
            this.Fins = fins;
        }

        public string Name { get; set; }

        public string Color { get; set; }

        public int Fins { get; set; }

        public override string ToString()
        {
            var information = new StringBuilder();

            information.AppendLine($"Fish: {this.Name}");
            information.AppendLine($"Color: {this.Color}");
            information.Append($"Number of fins: {this.Fins}");

            return information.ToString();
        }
    }
}
