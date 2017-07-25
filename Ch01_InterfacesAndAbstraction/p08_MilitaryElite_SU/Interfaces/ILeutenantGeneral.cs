using System.Collections.Generic;

namespace p08_MilitaryElite_SU
{
    public interface ILeutenantGeneral : IPrivate
    {
        IList<ISoldier> Soldiers { get; }
    }
}