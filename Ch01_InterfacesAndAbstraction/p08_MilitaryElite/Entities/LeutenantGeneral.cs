namespace p08_MilitaryElite.Entities
{
    using System;
    using System.Collections.Generic;
    using p08_MilitaryElite.Interfaces;
    using System.Text;

    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        private IList<ISoldier> privates;

        public LeutenantGeneral(string id, string firstName, string lastName, double salary) : base(id, firstName, lastName, salary)
        {
            this.privates = new List<ISoldier>();
        }

        public IList<ISoldier> Privates { get; }

        public void AddPrivate(ISoldier priv)
        {
            this.privates.Add(priv);
        }

        public override string ToString()
        {
            var sb = new StringBuilder($"{base.ToString()}" + Environment.NewLine);
            sb.AppendLine("Privates:");
            sb.AppendLine($"  {string.Join(Environment.NewLine + "  ", this.privates)}");
            return sb.ToString().Trim();
        }

    }
}