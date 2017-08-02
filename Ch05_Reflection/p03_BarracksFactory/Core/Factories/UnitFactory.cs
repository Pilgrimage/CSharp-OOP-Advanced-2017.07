namespace p03_BarracksFactory.Core.Factories
{
    using System;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        private const string UnitNameSpace = "p03_BarracksFactory.Models.Units.";

        public IUnit CreateUnit(string unitType)
        {
            Type typeUnit = Type.GetType(UnitNameSpace + unitType);     // Require FuulName
            IUnit unitInstance = (IUnit) Activator.CreateInstance(typeUnit);
            return unitInstance;
        }
    }
}
