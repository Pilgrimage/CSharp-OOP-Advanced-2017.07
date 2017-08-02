namespace p02_BlackBoxInteger
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            BlackBoxIntegerTests newBlackBoxIntTests = new BlackBoxIntegerTests();
            string result = newBlackBoxIntTests.Run(typeof(BlackBoxInt));
            Console.WriteLine(result);
        }
    }
}