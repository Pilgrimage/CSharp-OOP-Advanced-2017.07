using System.Text;

public class Tesla : ICar, IElectricCar
{
    private string model;
    private string color;
    private int batteries;

    public Tesla(string model, string color, int batteries)
    {
        this.model = model;
        this.color = color;
        this.batteries = batteries;
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

    public int Batteries
    {
        get { return this.batteries; }
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
        sb.AppendLine($"{this.Color} {this.GetType().Name} {this.Model} with {this.Batteries} Batteries");
        sb.AppendLine(this.Start());
        sb.AppendLine(this.Stop());
        return sb.ToString().Trim();
    }

}

