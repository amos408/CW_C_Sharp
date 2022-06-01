//A Needle in the Haystack
//Can you find the needle in the haystack?

//Write a function findNeedle() that takes an array full of junk but containing one "needle"

//After your function finds the needle it should return a message (as a string) that says:

//"found the needle at position " plus the index it found the needle, so: 
//find_needle(['hay', 'junk', 'hay', 'hay', 'moreJunk', 'needle', 'randomJunk'])
//should return "found the needle at position 5"(in COBOL "found the needle at position 6")

using System;
public class Kata
{
    public static string FindNeedle(object[] haystack)
    {
        //Code goes here!
        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] != null)
            {
                if (haystack[i].ToString().ToLower() == "needle")
                {
                    return string.Format("found the needle at position {0}", i.ToString());
                }
            }
        }
        return "needle missing";
    }
}
