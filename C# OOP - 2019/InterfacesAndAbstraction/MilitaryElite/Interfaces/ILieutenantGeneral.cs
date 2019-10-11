namespace MilitaryElite.Interfaces
{
    using System.Collections.Generic;
    using Models.Privates;

    public interface ILieutenantGeneral
    {
        IReadOnlyCollection<Private> Privates { get; }
    }
}
