namespace MilitaryElite.Models.Privates.SpecialisedSoldiers
{
    using System.Collections.Generic;
    using System.Text;
    using Interfaces;
    using System.Linq;

    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string id, string firstName, string lastName, decimal salary, string corps, HashSet<Mission> missions) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = missions;
        }

        public IReadOnlyCollection<Mission> Missions { get; }

        public void CompleteMission(string codeName)
        {
            Mission mission = this.Missions
                .FirstOrDefault(x => x.CodeName == codeName);

            if(mission != null)
            {
                mission.State = "Complete";
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(base.ToString())
                .AppendLine("Missions:");

            foreach (var mision in this.Missions)
            {
                stringBuilder.AppendLine($" {mision.ToString()}");
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
