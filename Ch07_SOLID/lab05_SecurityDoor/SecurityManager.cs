namespace lab05_SecurityDoor
{
    using System;

    public class SecurityManager
    {
        private KeyCardCheck keyCardCheck;
        private PinCodeCheck pinCodeCheck;

        public SecurityManager(KeyCardCheck keyCardCheck, PinCodeCheck pinCodeCheck)
        {
            this.keyCardCheck = keyCardCheck;
            this.pinCodeCheck = pinCodeCheck;
        }

        public void Check(int option)
        {
            switch (option)
            {
                case 1:
                    Console.WriteLine(this.keyCardCheck.ValidateUser());
                    break;
                case 2:
                    Console.WriteLine(this.pinCodeCheck.ValidateUser());
                    break;
                default:
                    Console.WriteLine(Boolean.FalseString);
                    break;
            }
        }
    }
}