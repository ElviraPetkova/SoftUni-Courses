namespace MilitaryElite.Models.Privates
{
    using Interfaces;
    using System.Collections.Generic;
    using System.Text;

    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private HashSet<Private> privates;

        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName, salary)
        {
            this.privates = new HashSet<Private>();
        }

        public IReadOnlyCollection<Private> Privates => this.privates;

        public void AddPrivates(Private currentPrivate)
        {
            this.privates.Add(currentPrivate);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(base.ToString())
                .AppendLine("Privates:");

            foreach (var @private in this.Privates)
            {
                stringBuilder.AppendLine($" {@private.ToString()}");
            }

            return stringBuilder.ToString().TrimEnd();
        }

    }
}
