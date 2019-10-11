namespace MilitaryElite.Interfaces
{
    using System.Collections.Generic;
    using Models.Privates.SpecialisedSoldiers;

    public interface ICommando
    {
        IReadOnlyCollection<Mission> Missions { get; }

        void CompleteMission(string codeName);
    }
}
