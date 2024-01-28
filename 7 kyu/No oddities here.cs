//No oddities here
//Write a small function that returns the values of an array that are not odd.
//All values in the array will be integers. Return the good values in the order they are given.
using System.Linq;
public class NoOddities
{
    public static int[] NoOdds(int[] values) => values.Where(v => v % 2 == 0).ToArray();
    
}
