namespace p08_MilitaryElite.Interfaces
{
    using System.Collections.Generic;

    public interface ICommando : ISpecialisedSoldier
    {
        IList<IMission> Missions { get; }

        //void CompleteMission();
    }
}