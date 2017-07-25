namespace p01_GenericBox
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Box<string> boxStr = new Box<string>(Console.ReadLine());

            Console.WriteLine(boxStr);
        }
    }
}
