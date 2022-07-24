//Alternate capitalization
//Given a string, capitalize the letters that occupy even indexes and odd indexes separately, and return as shown below. Index 0 will be considered even.

//For example, capitalize("abcdef") = ['AbCdEf', 'aBcDeF']. See test cases for more examples.

//The input will be a lowercase string with no spaces.

//Good luck!

//If you like this Kata, please try:

//Indexed capitalization

//Even-odd disparity

using System;

public static class Kata
{
  public static string[] Capitalize(string s)
  { 
             var first = "";
             var second = "";
        
             for (var y = 0; y < s.Length; y++)
             {
                 first = (y % 2 == 0) ? first + char.ToUpper(s[y]) : first + s[y];
                 second = (y % 2 != 0) ? second + char.ToUpper(s[y]) : second + s[y];
             }
        
             return new[] {first, second};
  }
}
