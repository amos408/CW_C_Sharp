//Reverse words
//Complete the function that accepts a string parameter, and reverses each word in the string.
//All spaces in the string should be retained.
//Examples

//"This is an example!" ==> "sihT si na !elpmaxe"
//"double  spaces"      ==> "elbuod  secaps"

using System;

public static class Kata
{
    public static string ReverseWords(string str)
    {
        //Write your code here
        string[] arr = str.Split();
        for (int i = 0; i != arr.Length; i++)
        {
            char[] array = arr[i].ToCharArray();
            Array.Reverse(array);
            arr[i] = new String(array);
        }
        string result = string.Join(" ", arr);
        return result;


    }
}

