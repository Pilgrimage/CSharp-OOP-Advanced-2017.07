namespace p01_GenericBox_chain
{
    public class Box<T>
    {
        public Box(T value)
        {
            this.Value = value;
        }

        public T Value { get; private set; }

        public override string ToString()
        {
            return $"{this.Value.GetType().FullName}: {this.Value}";
            //return $"{typeof(T).FullName}: {this.Value}";        // Alternative way
        }
    }
}
