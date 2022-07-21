//Sum of all the multiples of 3 or 5
//Your task is to write function findSum.

//Upto and including n, this function will return the sum of all multiples of 3 and 5.

//For example:

//findSum(5) should return 8 (3 + 5)

//findSum(10) should return 33 (3 + 5 + 6 + 9 + 10)

using System;
using System.Linq;
namespace Solution
{
  public static class Program
  {
    public static int findSum(int n)
    {
      Func<int, int> MultiplesN = x => (x % 3 == 0 || x % 5 == 0) ? x : 0;
			return Enumerable.Range(1, n).Sum(MultiplesN);
    }
  }
}
