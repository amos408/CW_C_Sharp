//Simple multiplication
//This kata is about multiplying a given number by eight if it is an even number and by nine otherwise.
public class Multiplier
{
  public static int Multiply(int x) 
  {
    // your code........
    return x % 2 == 1 ? x * 9 : x * 8;
  }
}  
