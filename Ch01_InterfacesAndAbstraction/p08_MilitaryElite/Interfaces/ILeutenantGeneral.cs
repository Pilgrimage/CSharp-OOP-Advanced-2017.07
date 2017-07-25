namespace p08_MilitaryElite.Interfaces
{
    using System.Collections.Generic;

    public interface ILeutenantGeneral : IPrivate
    {
        IList<ISoldier> Privates { get; }
    }
}