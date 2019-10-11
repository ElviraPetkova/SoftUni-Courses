using System.Text;

namespace FightingArena
{
    public class Gladiator
    {
        public string Name { get; set; }

        public Stat Stat { get; set; }

        public Weapon Weapon { get; set; }

        public Gladiator(string name, Stat stat, Weapon weapon)
        {
            this.Name = name;
            this.Stat = stat;
            this.Weapon = weapon;
        }

        public int GetTotalPower()
        {
            int sum = GetStatPower() + GetWeaponPower();
            return sum;
        }

        public int GetWeaponPower()
        {
            int sum = this.Weapon.Sharpness + this.Weapon.Size + this.Weapon.Solidity;
            return sum;
        }

        public int GetStatPower()
        {
            int sum = this.Stat.Agility + this.Stat.Flexibility + this.Stat.Intelligence 
                + this.Stat.Skills + this.Stat.Strength;
            return sum;
        }

        public override string ToString()
        {
            var tempateText = new StringBuilder();

            tempateText.Append($"[{this.Name}] - [{GetTotalPower()}]");
            tempateText.Append($"Weapon Power: [{GetWeaponPower()}]");
            tempateText.Append($"Stat Power: [{GetStatPower()}]");

            return tempateText.ToString();
        }
    }
}
