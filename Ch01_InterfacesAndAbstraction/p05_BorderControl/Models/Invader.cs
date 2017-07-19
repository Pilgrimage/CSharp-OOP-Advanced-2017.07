namespace p05_BorderControl.Models
{
    public abstract class Invader : IEnterable
    {
        protected Invader(string id)
        {
            this.Id = id;
        }

        public string Id { get; }

        public bool IsDetained(string key)
        {
            return this.Id.EndsWith(key);
        }
    }
}