//Isograms
//An isogram is a word that has no repeating letters, consecutive or non-consecutive.
//Implement a function that determines whether a string that contains only letters is an isogram.
//Assume the empty string is an isogram. Ignore letter case.

//Example: (Input-- > Output)

//"Dermatoglyphics"-- > true
//"aba"-- > false
//"moOse"-- > false(ignore letter case)

using System;
using System.Linq;

public class Kata
{
    public static bool IsIsogram(string str)
    {
        // Code on you crazy diamond!
        char[] arr = str.ToLower().ToCharArray();

        return (arr.Length != arr.Distinct().Count()) ? false : true;
    }
}
