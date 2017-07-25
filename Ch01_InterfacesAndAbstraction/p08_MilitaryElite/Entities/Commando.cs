namespace p08_MilitaryElite.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using p08_MilitaryElite.Interfaces;


    public class Commando : SpecialisedSoldier, ICommando
    {
        private IList<IMission> missions;

        public Commando(string id, string firstName, string lastName, double salary, string corps) : base(id, firstName, lastName, salary, corps)
        {
            this.Missions= new List<IMission>();
        }

        public IList<IMission> Missions { get; }

        public void AddMission(IMission mission)
        {
            this.Missions.Add(mission);
        }

        public override string ToString()
        {
            var sb = new StringBuilder($"{base.ToString()}" + Environment.NewLine);
            sb.AppendLine("Missions:");
            sb.AppendLine($"  {string.Join(Environment.NewLine + "  ", this.Missions)}");
            return sb.ToString().Trim();
        }

    }
}