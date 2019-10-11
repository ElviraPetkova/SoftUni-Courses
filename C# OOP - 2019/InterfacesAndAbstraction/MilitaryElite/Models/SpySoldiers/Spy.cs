namespace MilitaryElite.Models.SpySoldiers
{
    using Interfaces;
    using System.Text;

    public class Spy : Soldier, ISpy
    {
        public Spy(string id, string firstName, string lastName, int codeNumber) 
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; private set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(base.ToString())
                .AppendLine($"Code Number: {this.CodeNumber}");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
