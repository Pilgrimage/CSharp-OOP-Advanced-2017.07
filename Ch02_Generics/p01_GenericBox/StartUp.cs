using System;

namespace p01_GenericBox
{
    public class StartUp
    {
        public static void Main()
        {
            Box<string> boxStr = new Box<string>(Console.ReadLine());

            Console.WriteLine(boxStr);
        }
    }
}
