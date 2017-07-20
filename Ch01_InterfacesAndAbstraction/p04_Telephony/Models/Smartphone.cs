using System.Linq;

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
            bool containsOnlyDigit = Regex.IsMatch(callNumber, "^\\d+$");
            //bool containsOnlyDigit = callNumber.All(char.IsDigit);        // Alternative method
            return containsOnlyDigit;

        }

        private bool ValidUrlAddress(string urlAddress)
        {
            bool containsDigit = Regex.IsMatch(urlAddress, "\\d");
            //bool containsDigit = urlAddress.Any(char.IsDigit);          // Alternative method
            return !containsDigit;
        }

    }
}
