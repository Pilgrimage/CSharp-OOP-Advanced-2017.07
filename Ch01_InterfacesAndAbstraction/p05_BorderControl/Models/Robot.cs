namespace p05_BorderControl.Models
{
    public class Robot : Invader
    {
        public Robot(string id, string model) 
            : base(id)
        {
            this.Model = model;
        }

         string Model { get; }
    }
}