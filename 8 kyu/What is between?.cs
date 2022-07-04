//What is between?
//Complete the function that takes two integers (a, b, where a < b) and return an array of all integers between the input parameters, including them.
//For example:

//a = 1
//b = 4
//--> [1, 2, 3, 4]

using System.Collections.Generic;
public class Kata {
  public static int[] Between(int a, int b) {
    // your code here
     var min = a < b ? a : b;
            var max = a > b ? a : b;
            var r = new List<int>();
            for (var i = min; i <= max; i++)
                r.Add(i);
            return r.ToArray();
  }
}
