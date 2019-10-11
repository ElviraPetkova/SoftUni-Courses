using System.Text;

namespace Heroes
{
    public class Item
    {
        public Item(int strenght, int ability, int intelligence)
        {
            this.Strength = strenght;
            this.Ability = ability;
            this.Intelligence = intelligence;
        }

        public int Strength { get; set; }

        public int Ability { get; set; }

        public int Intelligence { get; set; }

        public override string ToString()
        {
            var heroesInfo = new StringBuilder();
            heroesInfo.AppendLine($"  * Strength: {this.Strength}");
            heroesInfo.AppendLine($"  * Ability: {this.Ability}");
            heroesInfo.Append($"  * Intelligence: {this.Intelligence}");

            return heroesInfo.ToString();
            //string result = $"\t* Strength: {this.Strength}\n\t* Ability: {this.Ability}\n\t* Intelligence: {this.Intelligence}";
            //return result;
        }
    }
}
