namespace Rabbits
{
    public class Rabbit
    {
        public Rabbit(string name, string species)
        {
            this.Name = name;
            this.Species = species;
            this.Available = true;
        }

        public string Name { get; private set; }

        public string Species { get; private set; }

        public bool Available { get; set; }

        public override string ToString()
        {
            return $"Rabbit ({this.Species}): {this.Name}";
        }
    }
}
