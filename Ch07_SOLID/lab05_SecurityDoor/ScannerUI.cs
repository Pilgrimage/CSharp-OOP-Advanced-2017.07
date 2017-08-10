namespace lab05_SecurityDoor
{
    using System;

    public class ScannerUI : ISecurityUI
    {
        public string RequestKeyCard()
        {
            Console.WriteLine("Slide your key card");
            return Console.ReadLine();
        }

        public int RequestPinCode()
        {
            Console.WriteLine("Enter your pin code:");
            return int.Parse(Console.ReadLine());
        }

        public int RequestCheckOption()
        {
            Console.WriteLine("Choose option: 1 - KeyCard, 2 - PinCode:");
            int option = int.Parse(Console.ReadLine());
            if (option!=1 && option!=2)
            {
                option = 0;
            }
            return option;
        }
    }
}