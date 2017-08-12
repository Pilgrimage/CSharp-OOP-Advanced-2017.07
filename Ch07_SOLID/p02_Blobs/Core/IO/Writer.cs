namespace p02_Blobs.Core.IO
{
    using System;
    using p02_Blobs.Interfaces.IO;

    public class Writer : IWriter
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}