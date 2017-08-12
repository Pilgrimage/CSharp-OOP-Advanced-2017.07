namespace p06_Twitter
{
    using p06_Twitter.Interfaces;
    using p06_Twitter.Models;

    public class StartUp
    {
        public static void Main()
        {
            IMessage tweet = new Tweet("test msg");
            IWriter console = new ConsoleWriter();
            IClient microwave = new MicrowaveOven(console);
            microwave.RetrieveMessage(tweet);
        }
    }
}
