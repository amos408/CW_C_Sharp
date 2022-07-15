//Third Angle of a Triangle
//You are given two interior angles (in degrees) of a triangle.

//Write a function to return the 3rd.

//Note: only positive integers will be tested.

using System;

public static class Kata
{
  public static int OtherAngle(int a, int b)
  {
    return 180 - (a + b);
  }
}
