//Grasshopper - Grade book
//Complete the function so that it finds the average of the three scores passed to it and returns the letter value associated with that grade.
//Numerical Score 	Letter Grade
//90 <= score <= 100 	'A'
//80 <= score < 90 	'B'
//70 <= score < 80 	'C'
//60 <= score < 70 	'D'
/0 <= score < 60 	'F'
//Tested values are all between 0 and 100. Theres is no need to check for negative values or values greater than 100.
using System;

public class Kata
{
  public static char GetGrade(int s1, int s2, int s3)
  {
    //Your code goes here...
     var sum = (s1 + s2 + s3) / 3;
        switch(sum)
        {
            case int n when (sum >= 90 && sum <= 100):
                return 'A';
            case int n when (sum >= 80 && sum < 90):
                return 'B';
            case int n when (sum >= 70 && sum < 80):
                return 'C';
            case int n when (sum >= 60 && sum < 70):
                return 'D';
        }
      return 'F';
  }
}
