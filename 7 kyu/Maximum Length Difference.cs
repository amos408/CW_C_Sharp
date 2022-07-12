//Maximum Length Difference
//You are given two arrays a1 and a2 of strings. Each string is composed with letters from a to z. 
//Let x be any string in the first array and y be any string in the second array.

//Find max(abs(length(x) − length(y)))

//If a1 and/or a2 are empty return -1 in each language except in Haskell (F#) where you will return Nothing (None).
//Example:

//a1 = ["hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz"]
//a2 = ["cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww"]
//mxdiflg(a1, a2) --> 13

//Bash note:

    //input : 2 strings with substrings separated by ,
    //output: number as a string

using System;
using System.Linq;
public class MaxDiffLength 
{ 
    public static int Mxdiflg(string[] a1, string[] a2) 
    {
        // your code
             if(a1 == null || a2 == null)
        {
            return -1;
        }
        if(a1.Length == 0 || a2.Length == 0)
        {
            return -1;
        }
        
        string long1 = a2.OrderByDescending( q => q.Length ).First();
        string short1 = a1.OrderBy( q => q.Length ).First();
        int t1 = Math.Abs(long1.Length - short1.Length);
        string long2 = a1.OrderByDescending( q => q.Length ).First();
        string short2 = a2.OrderBy( q => q.Length ).First();
        int t2 = Math.Abs(long2.Length - short2.Length);
        if(t2 > t1)
        {
            return t2;
        }
        else
        {
            return t1;
    }
}
  }
