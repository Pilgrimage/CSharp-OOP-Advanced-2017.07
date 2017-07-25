namespace p08_MilitaryElite.Entities
{
    using p08_MilitaryElite.Interfaces;

    public class Repair : IRepair
    {
        public Repair(string partName, int hourWorked)
        {
            this.PartName = partName;
            this.HourWorked = hourWorked;
        }

        public string PartName { get; }
        public int HourWorked { get; }

        public override string ToString()
        {
            return $"Part Name: {this.PartName} Hours Worked: {this.HourWorked}";
        }
    }
}