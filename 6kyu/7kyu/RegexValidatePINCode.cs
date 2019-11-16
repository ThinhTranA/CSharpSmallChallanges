using System.Text.RegularExpressions;

namespace _7kyu
{
    public class RegexValidatePINCode

    {
        public static bool ValidatePin(string pin)
        {
            Regex rx = new Regex(@"^(?=[0-9]*$)(?:.{4}|.{6})([^\n])$");

            return rx.IsMatch(pin);
        }
        /*
            ^      Start of string
         (?=    Assert that the following regex can be matched here: 
        [0-9]*  Any number of digits (and nothing but digits) 
            $   Until end of string ) # (End of lookahead) 
        (?:     Match either 
        .{4}    4 characters | # or 
        .{6}    6 characters ) # (End of alternation) 
          $       End of string
        
    */

    }
}
