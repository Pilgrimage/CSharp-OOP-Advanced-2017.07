namespace p07_FoodShortage
{
    public interface IHuman : IBuyer
    {
        string Name { get; }
        int Age { get; }
    }
}