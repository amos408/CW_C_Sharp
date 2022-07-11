//Reversed sequence 
//Build a function that returns an array of integers from n to 1 where n>0.

//Example : n=5 --> [5,4,3,2,1]

using System.Linq;
public static class Kata
{
   public static int[] ReverseSeq(int n) => Enumerable.Range(1, n).Reverse().ToArray();

}
