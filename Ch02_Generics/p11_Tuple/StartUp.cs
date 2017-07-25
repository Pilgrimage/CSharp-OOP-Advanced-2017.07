namespace p11_Tuple
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] inParams = Console.ReadLine().Split(' ');
            string names = $"{inParams[0]} {inParams[1]}";
            string address = inParams[2];
            Tuple<string, string> namesAdress = new Tuple<string, string>(names, address);
            Console.WriteLine(namesAdress);

            inParams = Console.ReadLine().Split(' ');
            string name = inParams[0];
            int liters = int.Parse(inParams[1]);
            Tuple<string, int> nameLiters = new Tuple<string, int>(name, liters);
            Console.WriteLine(nameLiters);

            inParams = Console.ReadLine().Split(' ');
            int intParam = int.Parse(inParams[0]);
            double doubleParam = double.Parse(inParams[1]);
            Tuple<int, double> intDouble = new Tuple<int, double>(intParam, doubleParam);
            Console.WriteLine(intDouble);
        }
    }
}
