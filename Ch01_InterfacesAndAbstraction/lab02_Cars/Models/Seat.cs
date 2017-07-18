using System.Text;

public class Seat : ICar
{
    private string model;
    private string color;

    public Seat(string model, string color)
    {
        this.model = model;
        this.color = color;
    }
    public string Model
    {
        get
        {
            return this.model;
        }
    }
    public string Color
    {
        get { return this.color; }
    }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.Color} {this.GetType().Name} {this.Model}");
        sb.AppendLine(this.Start());
        sb.AppendLine(this.Stop());
        return sb.ToString().Trim();
    }
}

