//If you can't sleep, just count sheep!!
//Task:

//Given a non-negative integer, 3 for example, return a string with a murmur: "1 sheep...2 sheep...3 sheep...". 
//Input will always be valid, i.e. no negative integers.

using System.Linq;

public static class Kata
{
  public static string CountSheep(int n)
  {
    return string.Join("", Enumerable.Range(0, n).Select(x => $"{x + 1} sheep..."));
  }
}
