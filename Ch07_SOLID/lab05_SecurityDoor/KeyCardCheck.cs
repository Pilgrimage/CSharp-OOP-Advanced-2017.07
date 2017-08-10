namespace lab05_SecurityDoor
{
    public class KeyCardCheck : SecurityCheck
    {
        private ISecurityUI securityUI;

        public KeyCardCheck(ISecurityUI securityUI)
        {
            this.securityUI = securityUI;
        }

        private bool IsValid(string code)
        {
            return true;
        }

        public override bool ValidateUser()
        {
            string code = this.securityUI.RequestKeyCard();
            return IsValid(code);
        }
    }
}