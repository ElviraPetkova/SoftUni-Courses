
namespace RawData
{
    public class Cargo
    {
        public Cargo(int weight, string type)
        {
            this.Weight = weight;
            this.Type = type;
        }

        private string type;
        private int weight;

        public string Type
        {
            get { return this.type; }

            set { this.type = value; }
        }

        public int Weight
        {
            get { return this.weight; }

            set { this.weight = value; }
        }
    }
}
