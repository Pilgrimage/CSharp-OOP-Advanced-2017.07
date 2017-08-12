namespace p02_Blobs.Core.IO
{
    using System;
    using p02_Blobs.Interfaces.IO;

    public class Reader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}