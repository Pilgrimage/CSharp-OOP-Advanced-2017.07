namespace p05_BorderControl.Models
{
    public interface IEnterable
    {
        string Id { get; }

        bool IsDetained(string key);
    }

}