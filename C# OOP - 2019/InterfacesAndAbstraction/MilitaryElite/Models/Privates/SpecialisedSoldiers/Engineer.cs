namespace MilitaryElite.Models.Privates.SpecialisedSoldiers
{
    using Interfaces;
    using System.Collections.Generic;
    using System.Text;

    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string id, string firstName, string lastName, decimal salary, string corps, HashSet<Repair> repairs)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Repairs = repairs;
        }

        public IReadOnlyCollection<Repair> Repairs { get; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(base.ToString())
                .AppendLine("Repairs:");

            foreach (var repair in this.Repairs)
            {
                stringBuilder.AppendLine($" {repair.ToString()}");
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
