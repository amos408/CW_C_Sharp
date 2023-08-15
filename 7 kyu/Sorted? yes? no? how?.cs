//Sorted? yes? no? how?
//Complete the method which accepts an array of integers, and returns one of the following:
// "yes, ascending" - if the numbers in the array are sorted in an ascending order
// "yes, descending" - if the numbers in the array are sorted in a descending order
// "no" - otherwise
//You can assume the array will always be valid, and there will always be one correct answer.

using System.Linq;
public class Kata
{
  public static string IsSortedAndHow(int[] array)
  {
    return array.OrderBy(a => a).SequenceEqual(array) ? "yes, ascending" :
                array.OrderBy(a => -a).SequenceEqual(array) ? "yes, descending" : "no";
  }
}
