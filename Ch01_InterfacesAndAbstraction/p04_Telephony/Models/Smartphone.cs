namespace p04_Telephony.Models
{
    using System.Text.RegularExpressions;

    public class Smartphone : ICallable, IBrowseable
    {
        
        public string Call(string callNumber)
        {
            return ValidCallNumber(callNumber) 
                ? $"Calling... {callNumber}" 
                : "Invalid number!";
        }

        public string Browse(string urlAddress)
        {
            return ValidUrlAddress(urlAddress) 
                ? $"Browsing: {urlAddress}!" 
                : "Invalid URL!";
        }

        private bool ValidCallNumber(string callNumber)
        {
            return Regex.IsMatch(callNumber, "^\\d+$");
        }

        private bool ValidUrlAddress(string urlAddress)
        {
            bool containsDigit = Regex.IsMatch(urlAddress, "\\d");
            return !containsDigit;
        }

    }
}
