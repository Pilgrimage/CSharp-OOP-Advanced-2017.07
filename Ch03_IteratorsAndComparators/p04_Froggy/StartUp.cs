namespace p04_Froggy
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] stones = Console.ReadLine()
                .Split(new char[] {',',' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Lake myLake = new Lake(stones);

            Console.WriteLine(string.Join(", ", myLake));
        }
    }
}
