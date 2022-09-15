//Multiple of index
//Return a new array consisting of elements which are multiple of their own index in input array (length > 1).
//Some cases:

//[22, -6, 32, 82, 9, 25] =>  [-6, 32, 25]

//[68, -1, 1, -7, 10, 10] => [-1, 10]

//[-56,-85,72,-26,-14,76,-27,72,35,-21,-67,87,0,21,59,27,-92,68] => [-85, 72, 0, 68]

using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static List<int> MultipleOfIndex(List<int> xs)
  {
   var list = new List<int>();
            for (int i = 1; i < xs.Count(); i++)
            {
                if (xs[i] % i == 0)
                {
                    list.Add(xs[i]);
                }
            }
            return list;
  }
}
