//Name Shuffler
//Write a function that returns a string in which firstname is swapped with last name.

//Example(Input --> Output)

//"john McClane" --> "McClane john"

using System;

public class Kata
{   
  public static string NameShuffler(string str)
  {
    //your code here...
     var result = str.Split();
            Array.Reverse(result);
            return string.Join(" ", result);
  }
}
