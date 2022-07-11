//Find Multiples of a Number
//In this simple exercise, you will build a program that takes a value, integer , and returns a list of its multiples up to another value, 
//limit . If limit is a multiple of integer, it should be included as well. There will only ever be positive integers passed into the function, 
//not consisting of 0. The limit will always be higher than the base.

//or example, if the parameters passed are (2, 6), the function should return [2, 4, 6] as 2, 4, and 6 are the multiples of 2 up to 6.

//If you can, try writing it in only one line of code.
using System.Collections.Generic;
public class Kata
{
  public static List<int> FindMultiples(int integer, int limit)
  {
    // Your code here!
     var res = new List<int>();
            for (var n = 1; integer * n <= limit; n++)
                res.Add(integer * n);
            return res;
  }
}
