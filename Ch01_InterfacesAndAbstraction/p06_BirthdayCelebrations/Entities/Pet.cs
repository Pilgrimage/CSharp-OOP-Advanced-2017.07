namespace p06_BirthdayCelebrations
{
    public class Pet : IPet, IBirthday
    {
        public Pet(string name, string birthDate)
        {
            this.Name = name;
            this.BirthDate = birthDate;
        }

        public string Name { get; }
        public string BirthDate { get; }

        public bool TakeDate(string year)
        {
            return this.BirthDate.EndsWith(year);
        }
    }
}
