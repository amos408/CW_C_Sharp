//Exes and Ohs
//Check to see if a string has the same amount of 'x's and 'o's.
//The method must return a boolean and be case insensitive. The string can contain any char.

//Examples input/output:

//XO("ooxx") => true
//XO("xooxx") => false
//XO("ooxXm") => true
//XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
//XO("zzoo") => false

using System.Linq;
using System;
public static class Kata
{
    public static bool XO(string input)
    {
        //Code it!
        var xCount = 0;
        var oCount = 0;

        foreach (var c in input.ToUpper())
        {
            if (c == 'X') xCount++;
            if (c == 'O') oCount++;
        }

        return xCount == oCount;
    }
}
