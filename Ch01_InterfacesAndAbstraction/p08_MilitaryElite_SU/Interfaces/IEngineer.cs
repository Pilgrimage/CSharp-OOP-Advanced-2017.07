using System.Collections.Generic;

namespace p08_MilitaryElite_SU
{
    public interface IEngineer : ISpecialisedSoldier
    {
        IList<IRepair> Parts { get; }
    }
}