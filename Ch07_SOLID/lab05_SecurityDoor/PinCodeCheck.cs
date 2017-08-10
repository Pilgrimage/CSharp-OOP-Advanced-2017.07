namespace lab05_SecurityDoor
{
    public class PinCodeCheck : SecurityCheck
    {
        private ISecurityUI securityUI;

        public PinCodeCheck(ISecurityUI securityUI)
        {
            this.securityUI = securityUI;
        }

        private bool IsValid(int pin)
        {
            return true;
        }

        public override bool ValidateUser()
        {
            int pin = this.securityUI.RequestPinCode();
            return IsValid(pin);
        }
    }
}