using System.Linq;
using Telephony.Interfaces;

namespace Telephony.Models
{
    public class SmartPhone : ICall, IBrowse
    {
        public string Browse(string site)
        {
            if (!site.Any(char.IsDigit))
            {
                return $"Browsing: {site}!";
            }
            return "Invalid URL!";
        }

        public string Call(string number)
        {
            if (number.All(char.IsDigit))
            {
                return $"Calling... {number}";
            }

            return "Invalid number!";
        }
    }
}
