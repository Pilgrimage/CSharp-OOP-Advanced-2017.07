using System;

namespace p03_Ferrari.Models
{
    public class Ferrari : ICar
    {
        public Ferrari(string driver)
        {
            this.Driver = driver;
            this.Model = "488-Spider";
        }

        public string Driver { get; }
        public string Model { get; }

        public string Break()
        {
            return "Brakes!";
        }

        public string GasPedal()
        {
            return "Zadu6avam sA!";
        }

        public override string ToString()
        {
            return $"{this.Model}/{this.Break()}/{this.GasPedal()}/{this.Driver}";
        }
    }
}
