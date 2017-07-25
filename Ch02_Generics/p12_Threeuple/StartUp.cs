namespace p12_Threeuple
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] inParams = Console.ReadLine().Split(' ');
            string names = $"{inParams[0]} {inParams[1]}";
            string address = inParams[2];
            string town = inParams[3];
            Tuple<string, string, string> namesAdressTown = new Tuple<string, string, string>(names, address, town);
            Console.WriteLine(namesAdressTown);

            inParams = Console.ReadLine().Split(' ');
            string name = inParams[0];
            int liters = int.Parse(inParams[1]);
            bool drink = inParams[2]=="drunk";
            Tuple<string, int, bool> nameLitersDrink = new Tuple<string, int, bool>(name, liters, drink);
            Console.WriteLine(nameLitersDrink);

            inParams = Console.ReadLine().Split(' ');
            name = inParams[0];
            double amount = double.Parse(inParams[1]);
            string bank = inParams[2];
            Tuple<string, double, string> nameAmountBank = new Tuple<string, double, string>(name, amount, bank);
            Console.WriteLine(nameAmountBank);
        }
    }
}
