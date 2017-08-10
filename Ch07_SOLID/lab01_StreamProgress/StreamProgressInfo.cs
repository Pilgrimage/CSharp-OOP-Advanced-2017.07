namespace lab01_StreamProgress
{
    public class StreamProgressInfo
    {
        private readonly IStreamable streamObject;

        public StreamProgressInfo(IStreamable streamObject)
        {
            this.streamObject = streamObject;
        }

        public int CalculateCurrentPercent()
        {
            return (this.streamObject.BytesSent * 100) / this.streamObject.Length;
        }
    }
}