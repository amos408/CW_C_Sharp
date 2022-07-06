//Write Number in Expanded Form

//You will be given a number and you will need to return it as a string in Expanded Form. For example:

//Kata.ExpandedForm(12); # Should return "10 + 2"
//Kata.ExpandedForm(42); # Should return "40 + 2"
//Kata.ExpandedForm(70304); # Should return "70000 + 300 + 4"

//NOTE: All numbers will be whole numbers greater than 0.

//If you liked this kata, check out part 2!!

using System;

public static class Kata 
{
    public static string ExpandedForm(long num) 
    {
        string numString = num.ToString();
      string blah = "";      
      for (int a = 0; a < numString.Length; a++)
      {
        if (numString[a] != '0')
        {
          blah += numString[a];
          blah += new String('0', numString.Length - a - 1);
          blah += " + ";
        }
      }
      return blah.Substring(0, blah.Length - 3);
    }
}
