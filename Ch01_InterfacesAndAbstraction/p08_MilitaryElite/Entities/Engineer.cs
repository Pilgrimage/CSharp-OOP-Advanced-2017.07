namespace p08_MilitaryElite.Entities
{
    using System;
    using System.Collections.Generic;
    using p08_MilitaryElite.Interfaces;
    using System.Text;

    public class Engineer : SpecialisedSoldier , IEngineer
    {
        private IList<IRepair> repairs;

        public Engineer(string id, string firstName, string lastName, double salary, string corps) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.repairs = new List<IRepair>();
        }

        public IList<IRepair> Repairs
        {
            get {return this.repairs ; }
        }

        public void AddRepair(IRepair repair)
        {
            this.repairs.Add(repair);
        }

        public override string ToString()
        {
            var sb = new StringBuilder($"{base.ToString()}" + Environment.NewLine);
            sb.AppendLine("Repairs:");
            sb.AppendLine($"  {string.Join(Environment.NewLine + "  ", this.Repairs)}");
            return sb.ToString().Trim();
        }

    }
}