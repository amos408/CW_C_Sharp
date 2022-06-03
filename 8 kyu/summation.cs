//Grasshopper - Summation
//Write a program that finds the summation of every number from 1 to num.
//The number will always be a positive integer greater than 0.

//For example:

//summation(2)-> 3
//1 + 2

//summation(8)-> 36
//1 + 2 + 3 + 4 + 5 + 6 + 7 + 8

using System;

public static class Kata
{
    public static int summation(int num)
    {
        //Code here
        int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum += i;
            }
            return sum;
        
    }
}
