using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _7kyu
{
    public class RegexValidatePINCode

    {
        public static bool ValidatePin(string pin)
        {
            return Regex.IsMatch(pin, @"^(\d{6}|\d{4})\z");

            // Without using regex
            //return pin.All(n => Char.IsDigit(n)) && (pin.Length == 4 || pin.Length == 6);
        }
       


    }
}
