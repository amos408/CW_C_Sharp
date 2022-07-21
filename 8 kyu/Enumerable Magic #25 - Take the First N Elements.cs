//Enumerable Magic #25 - Take the First N Elements
//Create a function that accepts a list/array and a number n, and returns a list/array of the first n elements from the list/array.

//If you need help, here's a reference:

//https://docs.microsoft.com/en-us/dotnet/api/system.array?view=netcore-3.1
using System;
using System.Linq;
public static class Kata
{
    public static int[] Take(int[] arr, int n)
    {
          return arr.Take(n).ToArray();
    }
}
