//Reverse List Order
In this kata you will create a function that takes in a list and returns a list with the reverse order.
Examples (Input -> Output)

* [1, 2, 3, 4]  -> [4, 3, 2, 1]
* [9, 2, 0, 7]  -> [7, 0, 2, 9]

using System.Collections.Generic;

public class Kata
{
  public static List<int> ReverseList(List<int> list)
  {
    // Return a new list with its elements in reverse order compared to the input list
    // Do not mutate the original list!
     var res = new List<int>(list);
            res.Reverse();
            return res;
  }
}
