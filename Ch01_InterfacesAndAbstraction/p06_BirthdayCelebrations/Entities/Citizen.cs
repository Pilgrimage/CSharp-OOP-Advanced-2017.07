namespace p06_BirthdayCelebrations
{
    public class Citizen : IHuman, IIdable, IBirthday
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.BirthDate = birthdate;
            this.Food = 0;
        }

        public string Name { get; }
        public int Age { get;  }
        public string Id { get;  }
        public string BirthDate { get; }
        public int Food { get; private set; }
        
        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
