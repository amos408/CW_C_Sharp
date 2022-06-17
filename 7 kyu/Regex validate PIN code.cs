//Regex validate PIN code
//ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything
//but exactly 4 digits or exactly 6 digits.

//If the function is passed a valid PIN string, return true, else return false.
//Examples (Input --> Output)

//"1234"-- > true
//"12345"-- > false
//"a234"-- > false

using System.Linq;

public class Kata
{
    public static bool ValidatePin(string pin)
    {
        return (pin.Length == 4 || pin.Length == 6) && pin.All(char.IsDigit);
    }
}
