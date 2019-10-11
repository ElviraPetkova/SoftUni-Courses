namespace MilitaryElite.Interfaces
{
    using System.Collections.Generic;
    using Models.Privates.SpecialisedSoldiers;

    public interface IEngineer
    {
        IReadOnlyCollection<Repair> Repairs { get; }
    }
}
