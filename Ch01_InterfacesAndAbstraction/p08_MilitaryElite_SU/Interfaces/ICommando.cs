using System.Collections.Generic;

namespace p08_MilitaryElite_SU
{
    public interface ICommando : ISpecialisedSoldier
    {
        IList<IMission> Missions { get; }

        void CompleteMission();
    }
}