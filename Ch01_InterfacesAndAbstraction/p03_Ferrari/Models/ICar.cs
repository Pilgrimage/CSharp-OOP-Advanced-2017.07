namespace p03_Ferrari.Models
{
    public interface ICar
    {
        string Model { get; }

        string Break();
        string GasPedal();
    }
}