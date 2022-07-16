//Exclamation marks series #1: Remove an exclamation mark from the end of string
//Remove an exclamation mark from the end of a string. For a beginner kata, you can assume that the input data is always a string, no need to verify it.
//Examples

//remove("Hi!") === "Hi"
//remove("Hi!!!") === "Hi!!"
//remove("!Hi") === "!Hi"
//remove("!Hi!") === "!Hi"
//remove("Hi! Hi!") === "Hi! Hi"
//remove("Hi") === "Hi"

//Note

//Please don't post issue about difficulty or duplicate.
public class Kata
{
  public static string Remove(string s)
  {
    //coding and coding....
    return s[s.Length - 1] == '!' ? s.Substring(0, s.Length - 1) : s;
  }
}
