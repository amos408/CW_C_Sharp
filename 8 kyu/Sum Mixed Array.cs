//Sum Mixed Array
//Given an array of integers as strings and numbers, return the sum of the array values as if all were numbers.

//Return your answer as a number.
using System;
using System.Linq;
public class Kata
  {
public static int SumMix(object[] x) => x.Where(c => c is IConvertible).Sum(Convert.ToInt32);
}
